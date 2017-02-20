using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LTEExcelAddIn
{
    public partial class Ribbon
    {
        //ДОБАВИТИ КАЛЬКУЛЯЦІЮ - ЛИСТОК-ШАБЛОН
        //КОМЕНТАРІ

        private readonly static string pattern1 = @"\b(ADD|ALL|ALTER|ANALYZE|AND|AS|ASC|ASENSITIVE|AUTO_INCREMENT|BDB|BEFORE|BERKELEYDB|BETWEEN|BIGINT|BINARY|BLOB|BOTH|BY|CALL|CASCADE|CASE|CHANGE|CHAR|CHARACTER|CHECK|COLLATE|COLUMN|COLUMNS|CONDITION|CONNECTION|CONSTRAINT|CONTINUE|CREATE|CROSS|CURRENT_DATE|CURRENT_TIME|CURRENT_TIMESTAMP|CURSOR|DATABASE|DATABASES|DAY_HOUR|DAY_MICROSECOND|DAY_MINUTE|DAY_SECOND|DEC|DECIMAL|DECLARE|DEFAULT|DELAYED|DELETE|DESC|DESCRIBE|DETERMINISTIC|DISTINCT|DISTINCTROW|DIV|DOUBLE|DROP|ELSE|ELSEIF|ENCLOSED|ESCAPED|EXISTS|EXIT|EXPLAIN|FALSE|FETCH|FIELDS|FLOAT|FOR|FORCE|FOREIGN|FOUND|FRAC_SECOND|FROM|FULLTEXT|GRANT|GROUP|HAVING|HIGH_PRIORITY|HOUR_MICROSECOND|HOUR_MINUTE|HOUR_SECOND|IF|IGNORE|IN|INDEX|INFILE|INNER|INNODB|INOUT|INSENSITIVE|INSERT|INT|INTEGER|INTERVAL|INTO|IO_THREAD|IS|ITERATE|JOIN|KEY|KEYS|KILL|LEADING|LEAVE|LEFT|LIKE|LIMIT|LINES|LOAD|LOCALTIME|LOCALTIMESTAMP|LOCK|LONG|LONGBLOB|LONGTEXT|LOOP|LOW_PRIORITY|MASTER_SERVER_ID|MATCH|MEDIUMBLOB|MEDIUMINT|MEDIUMTEXT|MIDDLEINT|MINUTE_MICROSECOND|MINUTE_SECOND|MOD|NATURAL|NOT|NO_WRITE_TO_BINLOG|NULL|NUMERIC|ON|OPTIMIZE|OPTION|OPTIONALLY|OR|ORDER|OUT|OUTER|OUTFILE|PRECISION|PRIMARY|PRIVILEGES|PROCEDURE|PURGE|READ|REAL|REFERENCES|REGEXP|RENAME|REPEAT|REPLACE|REQUIRE|RESTRICT|RETURN|REVOKE|RIGHT|RLIKE|SECOND_MICROSECOND|SELECT|SENSITIVE|SEPARATOR|SET|SHOW|SMALLINT|SOME|SONAME|SPATIAL|SPECIFIC|SQL|SQLEXCEPTION|SQLSTATE|SQLWARNING|SQL_BIG_RESULT|SQL_CALC_FOUND_ROWS|SQL_SMALL_RESULT|SQL_TSI_DAY|SQL_TSI_FRAC_SECOND|SQL_TSI_HOUR|SQL_TSI_MINUTE|SQL_TSI_MONTH|SQL_TSI_QUARTER|SQL_TSI_SECOND|SQL_TSI_WEEK|SQL_TSI_YEAR|SSL|STARTING|STRAIGHT_JOIN|STRIPED|TABLE|TABLES|TERMINATED|THEN|TIMESTAMPADD|TIMESTAMPDIFF|TINYBLOB|TINYINT|TINYTEXT|TO|TRAILING|TRUE|UNDO|UNION|UNIQUE|UNLOCK|UNSIGNED|UPDATE|USAGE|USE|USER_RESOURCES|USING|UTC_DATE|UTC_TIME|UTC_TIMESTAMP|VALUES|VARBINARY|VARCHAR|VARCHARACTER|VARYING|WHEN|WHERE|WHILE|WITH|WRITE|XOR|YEAR_MONTH|ZEROFILL)\b";
        private readonly static string pattern2 = "\".*?\"|\'.*?\'";
        private readonly static SQLQueryForm queryForm = new SQLQueryForm();
        
        public readonly static MySqlConnectionStringBuilder connectString = new MySqlConnectionStringBuilder();
        public readonly static Regex rgx1 = new Regex(pattern1, RegexOptions.IgnoreCase);
        public readonly static Regex rgx2 = new Regex(pattern2, RegexOptions.IgnoreCase);
        public readonly static int colorBlue = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
        public readonly static int colorRed = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.OrangeRed);

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            connectString.Server = Properties.Settings.Default.Server;
            connectString.Database = Properties.Settings.Default.Database;
            connectString.UserID = Properties.Settings.Default.User;
            connectString.Password = Properties.Settings.Default.Password;
            connectString.CharacterSet = Properties.Settings.Default.Character;
        }

        private void insertHomeFunction(string nameFunction)
        {
            Microsoft.Office.Interop.Excel.Range range = Globals.ThisAddIn.Application.Selection;
            if (range != null)
            {
                range.Formula = "=" + nameFunction + "()";
                Globals.ThisAddIn.Application.Dialogs[Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogFunctionWizard].Show();
                range.Style = "Currency";
            }
        }

        private void buttonSQLSettings_Click(object sender, RibbonControlEventArgs e)
        {
            new SQLSettingsForm().ShowDialog();
        }

        private void buttonSQLQuery_Click(object sender, RibbonControlEventArgs e)
        {
           queryForm.ShowDialog();
        }

        private void buttonWilo_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                new WiloForm().ShowDialog();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonContractsInformation_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    region AS 'район', 
    type AS 'тип', 
    address AS 'адреса', 
    organization AS 'договір з',
    contract AS 'номер договору',
    FORMAT(power, 2) AS 'договірна потужність (кВт)',
    objects.category AS 'категорія надійності'
FROM 
    objects
WHERE
    type <> 'склад'
ORDER BY
    FIELD(organization, 'ЛТЕ', 'решта', 'ОСББ', 'освіта', 'ЖЕК', 'ЛОЕ') DESC,
    organization,
    contract,
    region,
    FIELD(type, 'гуртожиток', 'майстерня', 'ТК', 'ІТП', 'ЦТП', 'котельня') DESC,
    type,
    SUBSTRING_INDEX(address, ',', 1) COLLATE utf8_unicode_ci, 
    CAST(SUBSTRING_INDEX(address, ',', -1) AS unsigned);
            ", buttonContractsInformation.Label).ShowDialog();
        }

        private void buttonGroupByContracts_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    IFNULL(organization, 'без договору') AS 'договір з',
    COUNT(*) AS ""кількість об'єктів""
FROM 
    objects
WHERE
    type <> 'склад'
GROUP BY
    organization
ORDER BY
    organization IS NULL,
    `кількість об'єктів` DESC;
            ", buttonGroupByContracts.Label).ShowDialog();
        }

        private void buttonMotorsInObjects_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    motors_lte.idMotorsLTE AS 'ID', 
    objects.region AS 'район', 
    objects.type AS 'тип', 
    objects.address AS 'адреса', 
    missions.mission AS 'призначення двигуна', 
    motors_lte.series AS 'серія двигуна', 
    motors_lte.type AS 'тип двигуна', 
    FORMAT(motors_lte.power, 3) AS 'P(кВт)', 
    CASE 
        WHEN motors_lte.threePhase IS NULL THEN NULL
        WHEN motors_lte.threePhase = 0 THEN '1~'
        ELSE '3~'
    END AS 'кількість фаз', 
    motors_lte.speed AS 'r/min', 
    motors_lte.inventory AS 'інвентарний номер', 
    motors_lte.bearing1 AS 'підшипник (перед/низ)', 
    motors_lte.bearing2 AS 'підшипник (зад/верх)',
    (SELECT DATE_FORMAT(MAX(dateRepair), '%m-%Y р.') FROM motorRepairs WHERE motorRepairs.idMotorsLTE = motors_lte.idMotorsLTE) AS 'останній ремонт', 
    (SELECT typeRepair FROM motorRepairs WHERE motorRepairs.idMotorsLTE = motors_lte.idMotorsLTE ORDER BY dateRepair DESC LIMIT 1) AS 'тип ремонта',
    DATE_FORMAT(motors_lte.dateChange, '%d.%m.%Y %T') AS 'дата зміни інформації'
FROM 
    objects INNER JOIN motors_lte USING (idObject) 
        INNER JOIN missions USING (idMission)
ORDER BY 
    motors_lte.idMotorsLTE;
            ", buttonMotorsInObjects.Label).ShowDialog();
        }

        private void buttonGroupByMiniMotors_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    type AS 'тип',
    COUNT(*) AS 'кількість'
FROM
    motors_lte
WHERE
    type REGEXP '^DAB VA +|^DAB A +|^IMPPUMPS GHN +|^LFP LESZNO [0-9]{2}P+|^Lowara EV +|^Lowara TLC +|^Lowara TCR +|^Lowara TC +|^NOCCHI R2C +|Sprut GPD +|^Viessmann +|^Grundfos MAGNA +|^Grundfos UP +|^Grundfos UPBASIC +|^Grundfos UPS +|^Grundfos UPER +|^Wilo RS +|^Wilo Star+|^Wilo TOP-+'
GROUP BY
    type
ORDER BY
    FIELD(series, 'Grundfos', 'Wilo') DESC,
    series,
    кількість DESC,
    тип;
            ", buttonGroupByMiniMotors.Label).ShowDialog();
        }

        private void buttonGroupByPower_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    CASE
        WHEN power < 0.6 THEN 'до 0.6'
        WHEN power BETWEEN 0.6 AND 3 THEN '0.6 - 3'
        WHEN power BETWEEN 3.1 AND 5 THEN '3.1 - 5'
        WHEN power BETWEEN 5.1 AND 10 THEN '5.1 - 10'
        WHEN power BETWEEN 10.1 AND 15 THEN '10.1 - 15'
        WHEN power BETWEEN 15.1 AND 20 THEN '15.1 - 20'
        WHEN power BETWEEN 20.1 AND 30 THEN '20.1 - 30'
        WHEN power BETWEEN 30.1 AND 40 THEN '30.1 - 40'
        WHEN power BETWEEN 40.1 AND 55 THEN '40.1 - 55'
        WHEN power BETWEEN 55.1 AND 75 THEN '55.1 - 75'
        WHEN power BETWEEN 75.1 AND 100 THEN '75.1 - 100'
        WHEN power BETWEEN 100.1 AND 125 THEN '100.1 - 125'
        WHEN power > 125 THEN 'більше 125'
        ELSE 'решта'
    END AS 'потужність',
    COUNT(*) AS 'штук'
FROM 
    motors_lte
GROUP BY
    потужність 
ORDER BY
    FIELD(потужність, 'решта', 'до 0.6', '0.6 - 3', '3.1 - 5', '5.1 - 10', '10.1 - 15', '15.1 - 20', '20.1 - 30', '30.1 - 40', '40.1 - 55', '55.1 - 75', '75.1 - 100', '100.1 - 125', 'більше 125');
            ", buttonGroupByPower.Label).ShowDialog();
        }

        private void buttonSumPowerOfObjects_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    objects.region AS 'район', 
    objects.type AS 'тип', 
    objects.address AS 'адреса', 
    objects.organization AS 'договір з', 
    FORMAT(SUM(motors_lte.power), 3) AS 'потужність' 
FROM 
    objects INNER JOIN motors_lte USING(idObject)
WHERE
    objects.type <> 'склад' 
GROUP BY 
    objects.type, 
    objects.address 
ORDER BY 
    CAST(FORMAT(SUM(motors_lte.power), 3) AS DECIMAL(6,3)) DESC;
            ", buttonSumPowerOfObjects.Label).ShowDialog();
        }

        private void buttonDecommissionedMotors_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT  
    region AS 'район', 
    type AS 'тип', 
    address AS 'адреса',
    mission AS 'призначення двигуна', 
    series AS 'серія двигуна', 
    typeMotor AS 'тип двигуна', 
    FORMAT(power, 3) AS 'P(кВт)',
    speed AS 'r/min',
    CASE 
        WHEN threePhase IS NULL THEN NULL
        WHEN threePhase = 0 THEN '1~'
        ELSE '3~'
    END AS 'кількість фаз',
    inventory AS 'інвентарний номер', 
    bearing1 AS 'підшипник №1', 
    bearing2 AS 'підшипник №2', 
    DATE_FORMAT(lastRepair, '%Y р.') AS 'останній ремонт', 
    DATE_FORMAT(dateTrash, '%d.%m.%Y %T') AS 'дата видалення'  
FROM
    trash_motors_lte;
            ", buttonDecommissionedMotors.Label).ShowDialog();
        }

        private void buttonMotorsHistory_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    idMotorsLTE AS 'ID двигуна',
    CONCAT_WS(' ', type, address) AS ""об'єкт"",  
    DATE_FORMAT(dateTrash, '%d.%m.%Y') AS 'знятий'
FROM 
    motors_lte_history
ORDER BY
    idMotorsLTE,
    dateTrash;
            ", buttonMotorsHistory.Label).ShowDialog();
        }

        private void buttonMotorRepairs_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    idMotorsLTE AS 'ID двигуна',
    typeRepair AS 'тип ремонта',  
    DATE_FORMAT(dateRepair, '%d.%m.%Y') AS 'дата ремонта'
FROM 
    motorRepairs
ORDER BY
    idMotorsLTE,
    dateRepair;
            ", buttonMotorRepairs.Label).ShowDialog();
        }

        private void buttonMiniWiloMotors_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    motors_lte.idMotorsLTE AS 'ID', 
    objects.region AS 'район',   
    objects.type AS 'тип',   
    objects.address AS 'адреса',   
    missions.mission AS 'призначення двигуна',   
    motors_lte.type AS 'тип двигуна',
    FORMAT(motors_lte.power, 3) AS 'P(кВт)',   
    CASE       
        WHEN motors_lte.threePhase IS NULL THEN NULL      
        WHEN motors_lte.threePhase = 0 THEN '1~'      
        ELSE '3~'  
    END AS 'кількість фаз',  
    motors_lte.idWiloArt AS 'артикул',   
    motors_lte.inventory AS 'інвентарний номер',   
    (SELECT DATE_FORMAT(MAX(dateRepair), '%m-%Y р.') FROM motorRepairs WHERE motorRepairs.idMotorsLTE = motors_lte.idMotorsLTE) AS 'останній ремонт', 
    (SELECT typeRepair FROM motorRepairs WHERE motorRepairs.idMotorsLTE = motors_lte.idMotorsLTE ORDER BY dateRepair DESC LIMIT 1) AS 'тип ремонта',
    DATE_FORMAT(motors_lte.dateChange, '%d.%m.%Y %T') AS 'дата зміни інформації'
FROM 
    objects INNER JOIN motors_lte USING (idObject) 
        INNER JOIN missions USING (idMission)
WHERE
    motors_lte.type REGEXP '^Wilo RS +|^Wilo Star+|^Wilo TOP-+'
ORDER BY 
    objects.region,     
    SUBSTRING_INDEX(objects.address, ',', 1) COLLATE utf8_unicode_ci,   
    CAST(SUBSTRING_INDEX(objects.address, ',', -1) AS unsigned);
            ", buttonMiniWiloMotors.Label).ShowDialog();
        }

        private void buttonGroupByMiniWiloMotors_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    type AS 'тип',
    COUNT(*) AS 'кількість'
FROM
    motors_lte
WHERE
    type REGEXP '^Wilo RS +|^Wilo Star+|^Wilo TOP-+'
GROUP BY
    type
ORDER BY
    кількість DESC,
    тип;
            ", buttonGroupByMiniMotors.Label).ShowDialog();
        }

        private void buttonGroupByRotorsMiniWiloMotor_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    CAST(IFNULL(wiloRotors.idRotor, 'невідомо') AS CHAR) AS 'артикул ротора',
    IFNULL(wiloRotors.type, 'невідомо') AS 'тип ротора',
    IF(wiloRotors.idRotor IS NOT NULL, IF(wiloRotors.typeWheel IS NULL, 'ні', 'так'), 'невідомо') AS 'ротор з крильчаткою',
    (SELECT COUNT(*) FROM wiloRotors_lte WHERE wiloRotors_lte.idRotor = wiloRotors.idRotor AND wiloRotors_lte.IsUsed = 0) AS 'на складі',
    (SELECT COUNT(*) FROM wiloRotors_lte WHERE wiloRotors_lte.idRotor = wiloRotors.idRotor AND wiloRotors_lte.IsUsed <> 0) AS 'у використанні',
    COUNT(*) AS 'кількість двигунів'
FROM 
    motors_lte LEFT OUTER JOIN wiloCharacteristics USING (idWiloArt) 
        LEFT OUTER JOIN wiloRotors USING(idRotor) 
WHERE
    motors_lte.type REGEXP '^Wilo RS +|^Wilo Star+|^Wilo TOP-+'
GROUP BY
    wiloRotors.idRotor,
    wiloRotors.type
ORDER BY
    wiloRotors.idRotor IS NULL,
    `кількість двигунів` DESC,
    wiloRotors.idRotor;
            ", buttonGroupByRotorsMiniWiloMotor.Label).ShowDialog();
        }

        private void buttonWiloSpareParts_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    wiloCharacteristics.idWiloArt AS 'артикул насоса',
    wiloCharacteristics.type AS 'тип насоса',
    wiloCharacteristics.idRotor AS 'артикул ротора',
    wiloRotors.type AS 'тип ротора',
    wiloWheels.idWheel AS 'артикул крильчатки',
    CASE
        WHEN wiloWheels.type IS NULL THEN wiloRotors.typeWheel
        ELSE wiloWheels.type
    END AS 'тип крильчатки',
    wiloCharacteristics.height AS 'довжина',
    wiloCharacteristics.diametr AS 'різьба/фланець',
    wiloCharacteristics.capacitor AS 'конденсатор'
FROM 
    wiloCharacteristics LEFT OUTER JOIN wiloRotors USING(idRotor) 
        LEFT OUTER JOIN wiloWheels USING(idWheel)
ORDER BY
    wiloCharacteristics.idWiloArt; 
            ", buttonWiloSpareParts.Label).ShowDialog();
        }

        private void buttonMetersDescriptions_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    type AS 'тип', 
    IF(connectTC, 'трансформаторного', 'прямого') AS 'тип ввімкнення', 
    minCurrent AS 'min', 
    maxCurrent AS 'max', 
    IF(threePhase, 'трьохфазний', 'однофазний') AS 'к-сть фаз', 
    IF(impKWh IS NULL, '', IF(impKWh>0, CONVERT(impKWh, CHAR), 'немає')) AS 'imp/kW*h', 
    IF(rs485 IS NULL, '', IF(rs485, 'є', 'немає')) AS 'RS-485', 
    meters.limit AS 'термін ДП' 
FROM 
    meters; 
            ", buttonWiloSpareParts.Label).ShowDialog();
        }

        private void buttonMetersInObjects_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    objects.region AS 'район', 
    objects.type AS 'тип', 
    objects.address AS 'адреса', 
    meters.type AS 'лічильник', 
    IF(meters.connectTC, 'трансформаторне', 'пряме') AS 'ввімкнення',   
    meters_lte.numberMeter AS 'номер лічильника',   
    meters_lte.testYear AS 'рік ДП', 
    meters_lte.testQuarter AS 'квартал ДП', 
    meters.limit + meters_lte.testYear AS 'рік наступної ДП', 
    objects.organization AS 'договір з', 
    IF(meters_lte.mustTesting, 'так', 'ні') AS 'ЛТЕ проводить ДП', 
    meters_lte.page AS 'сторінка' 
FROM 
    meters INNER JOIN meters_lte USING (idMeter) 
        INNER JOIN objects USING(idObject) 
ORDER BY  
    meters_lte.mustTesting, 
    meters.limit + meters_lte.testYear, 
    meters_lte.testQuarter, 
    objects.region, 
    objects.type, 
    SUBSTRING_INDEX(objects.address, ',', 1) COLLATE utf8_unicode_ci, 
    CAST(SUBSTRING_INDEX(objects.address, ',', -1) AS unsigned);
            ", buttonMetersInObjects.Label).ShowDialog();
        }

        private void buttonObjectsHasNotMeters_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    objects.region AS 'район',
    objects.type AS 'тип',
    objects.address AS 'адреса',
    objects.organization AS 'договір з'
FROM
    objects LEFT OUTER JOIN meters_lte ON objects.idObject = meters_lte.idObject
WHERE
    meters_lte.idObject IS NULL AND objects.type <> 'склад'
ORDER BY
    region,
    FIELD(type, 'гуртожиток', 'майстерня', 'ТК','ІТП', 'ЦТП', 'котельня') DESC,
    type, 
    SUBSTRING_INDEX(address, ',', 1) COLLATE utf8_unicode_ci, 
    CAST(SUBSTRING_INDEX(address, ',', -1) AS unsigned);
            ", buttonObjectsHasNotMeters.Label).ShowDialog();
        }

        private void buttonGroupMetersByContracts_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    IFNULL(objects.organization, 'без договору') AS 'договір з',
    COUNT(meters_lte.idMeter) AS ""кількість лічильників""
FROM 
    objects LEFT OUTER JOIN meters_lte USING (idObject)
GROUP BY
    objects.organization
ORDER BY
    objects.organization IS NULL,
    `кількість лічильників` DESC;
            ", buttonGroupMetersByContracts.Label).ShowDialog();
        }

        private void buttonMetersHistory_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    meters_lte_history.numberMeter AS 'номер лічильника',
    meters.type AS 'тип', 
    IF(meters.connectTC, 'трансформаторного', 'прямого') AS 'тип ввімкнення', 
    IF(meters.threePhase, 'трьохфазний', 'однофазний') AS 'к-сть фаз', 
    CONCAT_WS(' ', meters_lte_history.type, meters_lte_history.address) AS ""об'єкт"",  
    DATE_FORMAT(meters_lte_history.dateTrash, '%d.%m.%Y') AS 'знятий'
FROM 
    meters INNER JOIN meters_lte_history USING (idMeter)
ORDER BY
    meters_lte_history.numberMeter,
    meters.type,
    meters_lte_history.dateTrash;
            ", buttonMetersHistory.Label).ShowDialog();
        }

        private void buttonJointInspection_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    objects.region AS 'район', 
    objects.type AS 'тип', 
    objects.address AS 'адреса', 
    tableMeters.metersYear AS 'наступна ДП (лічильник+ТС)'
FROM
    (
        SELECT 
            meters_lte.idObject,
            meters.limit + meters_lte.testYear AS 'metersYear'
        FROM 
            meters INNER JOIN meters_lte USING (idMeter)
    ) AS tableMeters 
    INNER JOIN
    (
        SELECT
            tc_lte.idObject,
            tc.limit + tc_lte.testYear AS 'tcYear'
        FROM 
            tc INNER JOIN tc_lte USING (idTC) 
    ) AS tableTC
    USING (idObject) 
        INNER JOIN objects USING (idObject)
WHERE 
    tableTC.tcYear = tableMeters.metersYear 
GROUP BY 
    objects.idObject
ORDER BY 
    tableMeters.metersYear, 
    objects.region, 
    objects.type, 
    SUBSTRING_INDEX(objects.address, ',', 1) COLLATE utf8_unicode_ci, 
    CAST(SUBSTRING_INDEX(objects.address, ',', -1) AS unsigned);
            ", buttonJointInspection.Label).ShowDialog();
        }

        private void buttonTCDescriptions_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    type AS 'тип', 
    coefficient AS 'коефіцієнт', 
    tc.limit AS 'термін ДП' 
FROM 
    tc;
            ", buttonTCDescriptions.Label).ShowDialog();
        }

        private void buttonTCInObjects_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    objects.region AS 'район', 
    objects.type AS 'тип', 
    objects.address AS 'адреса', 
    CONCAT_WS(' ', tc.type, tc.coefficient) AS 'ТС', 
    tc_lte.numberTC AS 'номер ТС', 
    tc_lte.testYear AS 'рік ДП',
    tc_lte.testQuarter AS 'квартал ДП',
    tc.limit + tc_lte.testYear AS 'рік наступної ДП',
    objects.organization AS 'договір з', 
    IF(tc_lte.mustTesting, 'так', 'ні') AS 'ЛТЕ проводить ДП'
FROM 
    tc INNER JOIN tc_lte USING (idTC) 
        INNER JOIN objects USING(idObject)
ORDER BY
    tc_lte.mustTesting,
    tc.limit + tc_lte.testYear, 
    tc_lte.testQuarter, 
    objects.region, 
    objects.type, 
    SUBSTRING_INDEX(objects.address, ',', 1) COLLATE utf8_unicode_ci, 
    CAST(SUBSTRING_INDEX(objects.address, ',', -1) AS unsigned);
            ", buttonTCInObjects.Label).ShowDialog();
        }

        private void buttonTCHistory_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    tc_lte_history.numberTC AS 'номер ТС',
    CONCAT_WS(' ', tc.type, tc.coefficient) AS 'тип', 
    CONCAT_WS(' ', tc_lte_history.type, tc_lte_history.address) AS ""об'єкт"",  
    DATE_FORMAT(tc_lte_history.dateTrash, '%d.%m.%Y') AS 'знятий'
FROM 
    tc INNER JOIN tc_lte_history USING (idTC)
ORDER BY
    tc_lte_history.numberTC,
    tc.type,
    tc.coefficient,
    tc_lte_history.dateTrash;
            ", buttonTCHistory.Label).ShowDialog();
        }

        private void buttonCondensersInObjects_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    objects.region AS 'район',
    objects.type AS 'тип',
    objects.address AS 'адреса',
    FORMAT(condensers_lte.kvar, 2) AS 'кВАр',
    condensers_lte.type AS 'тип КУ',
    condensers_lte.notes AS 'примітки',
    DATE_FORMAT(condensers_lte.dateChange , '%d.%m.%Y %T') AS 'дата зміни інформації'
FROM
    condensers_lte INNER JOIN objects USING(idObject);
            ", buttonCondensersInObjects.Label).ShowDialog();
        }

        private void buttonTSAtObjects_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT
    objects.region AS 'район', 
    objects.type AS 'тип', 
    objects.address AS 'адреса',
    ts.number AS 'ТП' ,
    ts_lte.notes AS 'джерело живлення'
FROM
    ts INNER JOIN ts_lte USING(idTS) 
        RIGHT OUTER JOIN objects USING(idObject)
ORDER BY
    ts.number IS NULL,
    objects.region,
    FIELD(objects.type, 'гуртожиток', 'майстерня', 'ТК', 'ІТП', 'ЦТП', 'котельня') DESC,
    objects.type,
    SUBSTRING_INDEX(objects.address, ',', 1) COLLATE utf8_unicode_ci, 
    CAST(SUBSTRING_INDEX(objects.address, ',', -1) AS unsigned);
            ", buttonTSAtObjects.Label).ShowDialog();
        }

        private void buttonEmployeesES_Click(object sender, RibbonControlEventArgs e)
        {
            new LoadForm(@"
SELECT 
    staff.boardNumber AS 'табельний', 
    staff.idNumber AS 'ідентифікаційний', 
    CONCAT_WS(' ', staff.lastName, staff.firstName, staff.middleName) AS 'працівник', 
    CONCAT_WS(' ', profession.preSpecialty, profession.specialty) AS 'посада', 
    profession.postSpecialty AS 'розряд/категорія', 
    staff.notesProfession AS 'примітки', 
    staff.electricGroup AS 'група з електробезпеки', 
    staff.region AS 'приналежність', 
    staff.phone AS 'телефон', 
    DATE_FORMAT(staff.birthday, '%d.%m.%Y') AS 'дата народження', 
    TIMESTAMPDIFF(YEAR, staff.birthday, CURDATE()) AS 'вік', 
    DATE_FORMAT(staff.beginningDate, '%d.%m.%Y') AS 'дата прийому', 
    TIMESTAMPDIFF(YEAR, staff.beginningDate, CURDATE()) AS 'стаж', 
    staff.height AS 'зріст', 
    staff.clothingSize AS 'розмір одягу', 
    staff.shoeSize AS 'розмір взуття', 
    DATE_FORMAT(staff.dateChange, '%d.%m.%Y %T') AS 'останні зміни' 
FROM 
    staff LEFT OUTER JOIN profession USING (idProfession) 
ORDER BY 
    staff.lastName COLLATE utf8_unicode_ci, 
    staff.firstName COLLATE utf8_unicode_ci, 
    staff.middleName COLLATE utf8_unicode_ci;
            ", buttonEmployeesES.Label).ShowDialog();
        }

        private void buttonElectricPowerDoubleZones_Click(object sender, RibbonControlEventArgs e)
        {
            insertHomeFunction("ЕЛЕКТРОЕНЕРГІЯ_ДВОХЗОННИЙ_09_16");
        }

        private void buttonGas_Click(object sender, RibbonControlEventArgs e)
        {
            insertHomeFunction("ГАЗ_05_16");
        }
    }
}