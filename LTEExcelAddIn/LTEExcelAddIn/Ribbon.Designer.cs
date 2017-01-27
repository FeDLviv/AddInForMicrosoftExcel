namespace LTEExcelAddIn
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.tab = this.Factory.CreateRibbonTab();
            this.groupSQL = this.Factory.CreateRibbonGroup();
            this.groupFunctions = this.Factory.CreateRibbonGroup();
            this.groupOther = this.Factory.CreateRibbonGroup();
            this.buttonSQLSettings = this.Factory.CreateRibbonButton();
            this.buttonSQLQuery = this.Factory.CreateRibbonButton();
            this.menuContracts = this.Factory.CreateRibbonMenu();
            this.buttonContractsInformation = this.Factory.CreateRibbonButton();
            this.buttonGroupByContracts = this.Factory.CreateRibbonButton();
            this.menuMotors = this.Factory.CreateRibbonMenu();
            this.buttonMotorsInObjects = this.Factory.CreateRibbonButton();
            this.buttonGroupByMiniMotors = this.Factory.CreateRibbonButton();
            this.buttonGroupByPower = this.Factory.CreateRibbonButton();
            this.buttonSumPowerOfObjects = this.Factory.CreateRibbonButton();
            this.buttonDecommissionedMotors = this.Factory.CreateRibbonButton();
            this.buttonMotorsHistory = this.Factory.CreateRibbonButton();
            this.menuWilo = this.Factory.CreateRibbonMenu();
            this.buttonMiniWiloMotors = this.Factory.CreateRibbonButton();
            this.buttonGroupByMiniWiloMotors = this.Factory.CreateRibbonButton();
            this.buttonGroupByRotorsMiniWiloMotor = this.Factory.CreateRibbonButton();
            this.buttonWiloSpareParts = this.Factory.CreateRibbonButton();
            this.menuMeters = this.Factory.CreateRibbonMenu();
            this.buttonMetersDescriptions = this.Factory.CreateRibbonButton();
            this.buttonMetersInObjects = this.Factory.CreateRibbonButton();
            this.buttonObjectsHasNotMeters = this.Factory.CreateRibbonButton();
            this.buttonGroupMetersByContracts = this.Factory.CreateRibbonButton();
            this.buttonMetersHistory = this.Factory.CreateRibbonButton();
            this.buttonJointInspection = this.Factory.CreateRibbonButton();
            this.menuTC = this.Factory.CreateRibbonMenu();
            this.buttonTCDescriptions = this.Factory.CreateRibbonButton();
            this.buttonTCInObjects = this.Factory.CreateRibbonButton();
            this.buttonTCHistory = this.Factory.CreateRibbonButton();
            this.buttonJointInspection2 = this.Factory.CreateRibbonButton();
            this.menuCondensers = this.Factory.CreateRibbonMenu();
            this.buttonCondensersInObjects = this.Factory.CreateRibbonButton();
            this.menuTS = this.Factory.CreateRibbonMenu();
            this.buttonTSAtObjects = this.Factory.CreateRibbonButton();
            this.menuEmployees = this.Factory.CreateRibbonMenu();
            this.buttonEmployeesES = this.Factory.CreateRibbonButton();
            this.buttonWilo = this.Factory.CreateRibbonButton();
            this.menuHomeFunctions = this.Factory.CreateRibbonMenu();
            this.buttonElectricPowerDoubleZones = this.Factory.CreateRibbonButton();
            this.buttonGas = this.Factory.CreateRibbonButton();
            this.buttonCalculation = this.Factory.CreateRibbonButton();
            this.buttonMotorRepairs = this.Factory.CreateRibbonButton();
            this.tab.SuspendLayout();
            this.groupSQL.SuspendLayout();
            this.groupFunctions.SuspendLayout();
            this.groupOther.SuspendLayout();
            // 
            // tab
            // 
            this.tab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab.Groups.Add(this.groupSQL);
            this.tab.Groups.Add(this.groupFunctions);
            this.tab.Groups.Add(this.groupOther);
            this.tab.Label = "TabAddIns";
            this.tab.Name = "tab";
            // 
            // groupSQL
            // 
            this.groupSQL.Items.Add(this.buttonSQLSettings);
            this.groupSQL.Items.Add(this.buttonSQLQuery);
            this.groupSQL.Items.Add(this.menuContracts);
            this.groupSQL.Items.Add(this.menuMotors);
            this.groupSQL.Items.Add(this.menuWilo);
            this.groupSQL.Items.Add(this.menuMeters);
            this.groupSQL.Items.Add(this.menuTC);
            this.groupSQL.Items.Add(this.menuCondensers);
            this.groupSQL.Items.Add(this.menuTS);
            this.groupSQL.Items.Add(this.menuEmployees);
            this.groupSQL.Items.Add(this.buttonWilo);
            this.groupSQL.Label = "База даних";
            this.groupSQL.Name = "groupSQL";
            // 
            // groupFunctions
            // 
            this.groupFunctions.Items.Add(this.menuHomeFunctions);
            this.groupFunctions.Label = "Формули";
            this.groupFunctions.Name = "groupFunctions";
            // 
            // groupOther
            // 
            this.groupOther.Items.Add(this.buttonCalculation);
            this.groupOther.Label = "Решта";
            this.groupOther.Name = "groupOther";
            // 
            // buttonSQLSettings
            // 
            this.buttonSQLSettings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonSQLSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSQLSettings.Image")));
            this.buttonSQLSettings.Label = "Налаштування з\'єднання";
            this.buttonSQLSettings.Name = "buttonSQLSettings";
            this.buttonSQLSettings.ScreenTip = "Налаштування";
            this.buttonSQLSettings.ShowImage = true;
            this.buttonSQLSettings.SuperTip = "Форма, для налаштування підключення до СУБД MySQL";
            this.buttonSQLSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSQLSettings_Click);
            // 
            // buttonSQLQuery
            // 
            this.buttonSQLQuery.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonSQLQuery.Image = ((System.Drawing.Image)(resources.GetObject("buttonSQLQuery.Image")));
            this.buttonSQLQuery.Label = "Створення запита";
            this.buttonSQLQuery.Name = "buttonSQLQuery";
            this.buttonSQLQuery.ScreenTip = "Запит";
            this.buttonSQLQuery.ShowImage = true;
            this.buttonSQLQuery.SuperTip = "Форма для надсилання запиту до СУБД MySQL";
            this.buttonSQLQuery.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSQLQuery_Click);
            // 
            // menuContracts
            // 
            this.menuContracts.Image = ((System.Drawing.Image)(resources.GetObject("menuContracts.Image")));
            this.menuContracts.Items.Add(this.buttonContractsInformation);
            this.menuContracts.Items.Add(this.buttonGroupByContracts);
            this.menuContracts.Label = "Договори";
            this.menuContracts.Name = "menuContracts";
            this.menuContracts.ScreenTip = "Договори";
            this.menuContracts.ShowImage = true;
            this.menuContracts.SuperTip = "Запити до БД, щодо договорів";
            // 
            // buttonContractsInformation
            // 
            this.buttonContractsInformation.Image = ((System.Drawing.Image)(resources.GetObject("buttonContractsInformation.Image")));
            this.buttonContractsInformation.Label = "Договори та об\'єкти";
            this.buttonContractsInformation.Name = "buttonContractsInformation";
            this.buttonContractsInformation.ScreenTip = "Договори та об\'єкти";
            this.buttonContractsInformation.ShowImage = true;
            this.buttonContractsInformation.SuperTip = "Запит до БД, який показує інформацію по договорах на об\'єктах";
            this.buttonContractsInformation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonContractsInformation_Click);
            // 
            // buttonGroupByContracts
            // 
            this.buttonGroupByContracts.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroupByContracts.Image")));
            this.buttonGroupByContracts.Label = "Об\'єкти згруповані по договорах";
            this.buttonGroupByContracts.Name = "buttonGroupByContracts";
            this.buttonGroupByContracts.ScreenTip = "Об\'єкти згруповані по договорах";
            this.buttonGroupByContracts.ShowImage = true;
            this.buttonGroupByContracts.SuperTip = "Запит до БД, який групує об\'єкти по договорах  та підраховує їх кількість";
            this.buttonGroupByContracts.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGroupByContracts_Click);
            // 
            // menuMotors
            // 
            this.menuMotors.Image = ((System.Drawing.Image)(resources.GetObject("menuMotors.Image")));
            this.menuMotors.Items.Add(this.buttonMotorsInObjects);
            this.menuMotors.Items.Add(this.buttonGroupByMiniMotors);
            this.menuMotors.Items.Add(this.buttonGroupByPower);
            this.menuMotors.Items.Add(this.buttonSumPowerOfObjects);
            this.menuMotors.Items.Add(this.buttonDecommissionedMotors);
            this.menuMotors.Items.Add(this.buttonMotorsHistory);
            this.menuMotors.Items.Add(this.buttonMotorRepairs);
            this.menuMotors.Label = "Двигуни";
            this.menuMotors.Name = "menuMotors";
            this.menuMotors.ScreenTip = "Двигуни";
            this.menuMotors.ShowImage = true;
            this.menuMotors.SuperTip = "Запити до БД, щодо двигунів";
            // 
            // buttonMotorsInObjects
            // 
            this.buttonMotorsInObjects.Image = ((System.Drawing.Image)(resources.GetObject("buttonMotorsInObjects.Image")));
            this.buttonMotorsInObjects.Label = "Двигуни на об\'єктах";
            this.buttonMotorsInObjects.Name = "buttonMotorsInObjects";
            this.buttonMotorsInObjects.ScreenTip = "Двигуни на об\'єктах";
            this.buttonMotorsInObjects.ShowImage = true;
            this.buttonMotorsInObjects.SuperTip = "Запит до БД, який показує інформацію  по двигунах на об\'єктах";
            this.buttonMotorsInObjects.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMotorsInObjects_Click);
            // 
            // buttonGroupByMiniMotors
            // 
            this.buttonGroupByMiniMotors.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroupByMiniMotors.Image")));
            this.buttonGroupByMiniMotors.Label = "Згруповані двигуни з мокрим ротором";
            this.buttonGroupByMiniMotors.Name = "buttonGroupByMiniMotors";
            this.buttonGroupByMiniMotors.ScreenTip = "Згруповані двигуни з мокрим ротором";
            this.buttonGroupByMiniMotors.ShowImage = true;
            this.buttonGroupByMiniMotors.SuperTip = "Запит до БД, який вибирає двигуни  з мокрим ротором та групує їх по типу ЗАПИТ ПО" +
                "ТРІБНО ПОНОВЛЮВАТИ (24.12.2016)";
            this.buttonGroupByMiniMotors.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGroupByMiniMotors_Click);
            // 
            // buttonGroupByPower
            // 
            this.buttonGroupByPower.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroupByPower.Image")));
            this.buttonGroupByPower.Label = "Двигуни згруповані по потужності";
            this.buttonGroupByPower.Name = "buttonGroupByPower";
            this.buttonGroupByPower.ScreenTip = "Двигуни згруповані по потужності";
            this.buttonGroupByPower.ShowImage = true;
            this.buttonGroupByPower.SuperTip = "Запит до БД, який групує двигуни по потужності та підраховує їх кількість (для пі" +
                "драхунку КРС)";
            this.buttonGroupByPower.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGroupByPower_Click);
            // 
            // buttonSumPowerOfObjects
            // 
            this.buttonSumPowerOfObjects.Image = ((System.Drawing.Image)(resources.GetObject("buttonSumPowerOfObjects.Image")));
            this.buttonSumPowerOfObjects.Label = "Сумарна потужність двигунів на об\'єктах";
            this.buttonSumPowerOfObjects.Name = "buttonSumPowerOfObjects";
            this.buttonSumPowerOfObjects.ScreenTip = "Сумарна потужність двигунів на об\'єктах";
            this.buttonSumPowerOfObjects.ShowImage = true;
            this.buttonSumPowerOfObjects.SuperTip = "Запит до БД, який підраховує сумарну потужність двигунів на об\'єктах, та сортує с" +
                "умарну потужність об\'єктів по спаданню";
            this.buttonSumPowerOfObjects.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSumPowerOfObjects_Click);
            // 
            // buttonDecommissionedMotors
            // 
            this.buttonDecommissionedMotors.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecommissionedMotors.Image")));
            this.buttonDecommissionedMotors.Label = "Списані двигуни";
            this.buttonDecommissionedMotors.Name = "buttonDecommissionedMotors";
            this.buttonDecommissionedMotors.ScreenTip = "Списані двигуни";
            this.buttonDecommissionedMotors.ShowImage = true;
            this.buttonDecommissionedMotors.SuperTip = "Запит до БД, який показує списані двигуни";
            this.buttonDecommissionedMotors.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonDecommissionedMotors_Click);
            // 
            // buttonMotorsHistory
            // 
            this.buttonMotorsHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonMotorsHistory.Image")));
            this.buttonMotorsHistory.Label = "Двигуни (історія переміщень)";
            this.buttonMotorsHistory.Name = "buttonMotorsHistory";
            this.buttonMotorsHistory.ScreenTip = "Двигуни (історія переміщень)";
            this.buttonMotorsHistory.ShowImage = true;
            this.buttonMotorsHistory.SuperTip = "Запит до БД, який показує інформацію по переміщенню електродвигунів між об\'єктами" +
                " (історія)";
            this.buttonMotorsHistory.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMotorsHistory_Click);
            // 
            // menuWilo
            // 
            this.menuWilo.Image = ((System.Drawing.Image)(resources.GetObject("menuWilo.Image")));
            this.menuWilo.Items.Add(this.buttonMiniWiloMotors);
            this.menuWilo.Items.Add(this.buttonGroupByMiniWiloMotors);
            this.menuWilo.Items.Add(this.buttonGroupByRotorsMiniWiloMotor);
            this.menuWilo.Items.Add(this.buttonWiloSpareParts);
            this.menuWilo.Label = "Двигуни Wilo";
            this.menuWilo.Name = "menuWilo";
            this.menuWilo.ScreenTip = "Двигуни Wilo";
            this.menuWilo.ShowImage = true;
            this.menuWilo.SuperTip = "Запити до БД, щодо двигунів Wilo";
            // 
            // buttonMiniWiloMotors
            // 
            this.buttonMiniWiloMotors.Image = ((System.Drawing.Image)(resources.GetObject("buttonMiniWiloMotors.Image")));
            this.buttonMiniWiloMotors.Label = "Двигуни Wilo з мокрим ротором";
            this.buttonMiniWiloMotors.Name = "buttonMiniWiloMotors";
            this.buttonMiniWiloMotors.ScreenTip = "Двигуни Wilo з мокрим ротором";
            this.buttonMiniWiloMotors.ShowImage = true;
            this.buttonMiniWiloMotors.SuperTip = "Запит до БД, який вибирає двигуни Wilo  з мокрим ротором ЗАПИТ ПОТРІБНО ПОНОВЛЮВА" +
                "ТИ (24.12.2016)";
            this.buttonMiniWiloMotors.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMiniWiloMotors_Click);
            // 
            // buttonGroupByMiniWiloMotors
            // 
            this.buttonGroupByMiniWiloMotors.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroupByMiniWiloMotors.Image")));
            this.buttonGroupByMiniWiloMotors.Label = "Згруповані двигуни Wilo з мокрим ротором";
            this.buttonGroupByMiniWiloMotors.Name = "buttonGroupByMiniWiloMotors";
            this.buttonGroupByMiniWiloMotors.ScreenTip = "Згруповані двигуни Wilo з мокрим ротором";
            this.buttonGroupByMiniWiloMotors.ShowImage = true;
            this.buttonGroupByMiniWiloMotors.SuperTip = "Запит до БД, який вибирає двигуни  Wilo з мокрим ротором та групує їх по типу ЗАП" +
                "ИТ ПОТРІБНО ПОНОВЛЮВАТИ (24.12.2016)";
            this.buttonGroupByMiniWiloMotors.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGroupByMiniWiloMotors_Click);
            // 
            // buttonGroupByRotorsMiniWiloMotor
            // 
            this.buttonGroupByRotorsMiniWiloMotor.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroupByRotorsMiniWiloMotor.Image")));
            this.buttonGroupByRotorsMiniWiloMotor.Label = "Згруповані двигуни Wilo з мокрим ротором  по типу ротора";
            this.buttonGroupByRotorsMiniWiloMotor.Name = "buttonGroupByRotorsMiniWiloMotor";
            this.buttonGroupByRotorsMiniWiloMotor.ScreenTip = "Згруповані двигуни Wilo з мокрим ротором  по типу ротора";
            this.buttonGroupByRotorsMiniWiloMotor.ShowImage = true;
            this.buttonGroupByRotorsMiniWiloMotor.SuperTip = "Запит до БД, який вибирає двигуни  Wilo з мокрим ротором та групує їх по типу рот" +
                "ора ЗАПИТ ПОТРІБНО ПОНОВЛЮВАТИ (24.12.2016)";
            this.buttonGroupByRotorsMiniWiloMotor.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGroupByRotorsMiniWiloMotor_Click);
            // 
            // buttonWiloSpareParts
            // 
            this.buttonWiloSpareParts.Image = global::LTEExcelAddIn.Properties.Resources.query;
            this.buttonWiloSpareParts.Label = "Запасні частини Wilo";
            this.buttonWiloSpareParts.Name = "buttonWiloSpareParts";
            this.buttonWiloSpareParts.ScreenTip = "Запасні частини Wilo";
            this.buttonWiloSpareParts.ShowImage = true;
            this.buttonWiloSpareParts.SuperTip = "Запит до БД, який вибирає  запасні частини до насосів Wilo";
            this.buttonWiloSpareParts.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonWiloSpareParts_Click);
            // 
            // menuMeters
            // 
            this.menuMeters.Image = global::LTEExcelAddIn.Properties.Resources.meters;
            this.menuMeters.Items.Add(this.buttonMetersDescriptions);
            this.menuMeters.Items.Add(this.buttonMetersInObjects);
            this.menuMeters.Items.Add(this.buttonObjectsHasNotMeters);
            this.menuMeters.Items.Add(this.buttonGroupMetersByContracts);
            this.menuMeters.Items.Add(this.buttonMetersHistory);
            this.menuMeters.Items.Add(this.buttonJointInspection);
            this.menuMeters.Label = "Лічильники";
            this.menuMeters.Name = "menuMeters";
            this.menuMeters.ScreenTip = "Лічильники";
            this.menuMeters.ShowImage = true;
            this.menuMeters.SuperTip = "Запити до БД, щодо лічильників електроенергії";
            // 
            // buttonMetersDescriptions
            // 
            this.buttonMetersDescriptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMetersDescriptions.Image")));
            this.buttonMetersDescriptions.Label = "Технічні характеристики лічильників";
            this.buttonMetersDescriptions.Name = "buttonMetersDescriptions";
            this.buttonMetersDescriptions.ScreenTip = "Технічні характеристики лічильників";
            this.buttonMetersDescriptions.ShowImage = true;
            this.buttonMetersDescriptions.SuperTip = "Запит до БД, який виводить технічні характеристики лічильників";
            this.buttonMetersDescriptions.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMetersDescriptions_Click);
            // 
            // buttonMetersInObjects
            // 
            this.buttonMetersInObjects.Image = ((System.Drawing.Image)(resources.GetObject("buttonMetersInObjects.Image")));
            this.buttonMetersInObjects.Label = "Лічильники на об\'єктах";
            this.buttonMetersInObjects.Name = "buttonMetersInObjects";
            this.buttonMetersInObjects.ScreenTip = "Лічильники на об\'єктах";
            this.buttonMetersInObjects.ShowImage = true;
            this.buttonMetersInObjects.SuperTip = "Запит до БД, який показує інформацію по лічильниках на об\'єктах";
            this.buttonMetersInObjects.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMetersInObjects_Click);
            // 
            // buttonObjectsHasNotMeters
            // 
            this.buttonObjectsHasNotMeters.Image = ((System.Drawing.Image)(resources.GetObject("buttonObjectsHasNotMeters.Image")));
            this.buttonObjectsHasNotMeters.Label = "Об\'єкти без лічильників";
            this.buttonObjectsHasNotMeters.Name = "buttonObjectsHasNotMeters";
            this.buttonObjectsHasNotMeters.ScreenTip = "Об\'єкти без лічильників";
            this.buttonObjectsHasNotMeters.ShowImage = true;
            this.buttonObjectsHasNotMeters.SuperTip = "Запит до БД, який показує інформацію по об\'єктах на яких не встановлені лічильник" +
                "и (не має даних по лічильниках)";
            this.buttonObjectsHasNotMeters.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonObjectsHasNotMeters_Click);
            // 
            // buttonGroupMetersByContracts
            // 
            this.buttonGroupMetersByContracts.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroupMetersByContracts.Image")));
            this.buttonGroupMetersByContracts.Label = "Лічильники згруповані по договорах";
            this.buttonGroupMetersByContracts.Name = "buttonGroupMetersByContracts";
            this.buttonGroupMetersByContracts.ScreenTip = "Лічильники згруповані по договорах";
            this.buttonGroupMetersByContracts.ShowImage = true;
            this.buttonGroupMetersByContracts.SuperTip = "Запит до БД, який групує лічильники по договорах  та підраховує їх кількість";
            this.buttonGroupMetersByContracts.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGroupMetersByContracts_Click);
            // 
            // buttonMetersHistory
            // 
            this.buttonMetersHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonMetersHistory.Image")));
            this.buttonMetersHistory.Label = "Лічильники (історія переміщень)";
            this.buttonMetersHistory.Name = "buttonMetersHistory";
            this.buttonMetersHistory.ScreenTip = "Лічильники (історія переміщень)";
            this.buttonMetersHistory.ShowImage = true;
            this.buttonMetersHistory.SuperTip = "Запит до БД, який показує інформацію по переміщенню лічильників між об\'єктами (іс" +
                "торія)";
            this.buttonMetersHistory.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMetersHistory_Click);
            // 
            // buttonJointInspection
            // 
            this.buttonJointInspection.Image = ((System.Drawing.Image)(resources.GetObject("buttonJointInspection.Image")));
            this.buttonJointInspection.Label = "Спільна держповірка";
            this.buttonJointInspection.Name = "buttonJointInspection";
            this.buttonJointInspection.ScreenTip = "Спільна держповірка";
            this.buttonJointInspection.ShowImage = true;
            this.buttonJointInspection.SuperTip = "Запит до БД, який показує об\'єкти, на яких, рік держповірки лічильника(ів) та тра" +
                "нсформатора(ів) струму збігається";
            this.buttonJointInspection.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonJointInspection_Click);
            // 
            // menuTC
            // 
            this.menuTC.Image = global::LTEExcelAddIn.Properties.Resources.tc;
            this.menuTC.Items.Add(this.buttonTCDescriptions);
            this.menuTC.Items.Add(this.buttonTCInObjects);
            this.menuTC.Items.Add(this.buttonTCHistory);
            this.menuTC.Items.Add(this.buttonJointInspection2);
            this.menuTC.Label = "ТС";
            this.menuTC.Name = "menuTC";
            this.menuTC.ScreenTip = "Трансформатори струму";
            this.menuTC.ShowImage = true;
            this.menuTC.SuperTip = "Запити до БД, щодо трансформаторів струму";
            // 
            // buttonTCDescriptions
            // 
            this.buttonTCDescriptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonTCDescriptions.Image")));
            this.buttonTCDescriptions.Label = "Технічні характеристики трансформаторів стуму";
            this.buttonTCDescriptions.Name = "buttonTCDescriptions";
            this.buttonTCDescriptions.ScreenTip = "Технічні характеристики трансформаторів струму";
            this.buttonTCDescriptions.ShowImage = true;
            this.buttonTCDescriptions.SuperTip = "Запит до БД, який виводить технічні характеристики трансофрматорів струму";
            this.buttonTCDescriptions.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonTCDescriptions_Click);
            // 
            // buttonTCInObjects
            // 
            this.buttonTCInObjects.Image = ((System.Drawing.Image)(resources.GetObject("buttonTCInObjects.Image")));
            this.buttonTCInObjects.Label = "Трансформатори струму на об\'єктах";
            this.buttonTCInObjects.Name = "buttonTCInObjects";
            this.buttonTCInObjects.ScreenTip = "Трансформатори струму на об\'єктах";
            this.buttonTCInObjects.ShowImage = true;
            this.buttonTCInObjects.SuperTip = "Запит до БД, який показує інформацію по трансформаторах струму на об\'єктах";
            this.buttonTCInObjects.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonTCInObjects_Click);
            // 
            // buttonTCHistory
            // 
            this.buttonTCHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonTCHistory.Image")));
            this.buttonTCHistory.Label = "Трансформатори струму (історія переміщень)";
            this.buttonTCHistory.Name = "buttonTCHistory";
            this.buttonTCHistory.ScreenTip = "Трансформатори струму (історія переміщень)";
            this.buttonTCHistory.ShowImage = true;
            this.buttonTCHistory.SuperTip = "Запит до БД, який показує інформацію по переміщенню трансформаторів струму між об" +
                "\'єктами (історія)";
            this.buttonTCHistory.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonTCHistory_Click);
            // 
            // buttonJointInspection2
            // 
            this.buttonJointInspection2.Image = ((System.Drawing.Image)(resources.GetObject("buttonJointInspection2.Image")));
            this.buttonJointInspection2.Label = "Спільна держповірка";
            this.buttonJointInspection2.Name = "buttonJointInspection2";
            this.buttonJointInspection2.ScreenTip = "Спільна держповірка";
            this.buttonJointInspection2.ShowImage = true;
            this.buttonJointInspection2.SuperTip = "Запит до БД, який показує об\'єкти, на яких, рік держповірки лічильника(ів) та тра" +
                "нсформатора(ів) струму збігається";
            this.buttonJointInspection2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonJointInspection_Click);
            // 
            // menuCondensers
            // 
            this.menuCondensers.Image = global::LTEExcelAddIn.Properties.Resources.condensers;
            this.menuCondensers.Items.Add(this.buttonCondensersInObjects);
            this.menuCondensers.Label = "КУ";
            this.menuCondensers.Name = "menuCondensers";
            this.menuCondensers.ScreenTip = "Конденсаторні установки";
            this.menuCondensers.ShowImage = true;
            this.menuCondensers.SuperTip = "Запити до БД, щодо конденсаторних установок";
            // 
            // buttonCondensersInObjects
            // 
            this.buttonCondensersInObjects.Image = ((System.Drawing.Image)(resources.GetObject("buttonCondensersInObjects.Image")));
            this.buttonCondensersInObjects.Label = "Конденсаторні установки на об\'єктах";
            this.buttonCondensersInObjects.Name = "buttonCondensersInObjects";
            this.buttonCondensersInObjects.ScreenTip = "Конденсаторні установки на об\'єктах";
            this.buttonCondensersInObjects.ShowImage = true;
            this.buttonCondensersInObjects.SuperTip = "Запит до БД, який показує інформацію по конденсаторних установках на об\'єктах";
            this.buttonCondensersInObjects.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCondensersInObjects_Click);
            // 
            // menuTS
            // 
            this.menuTS.Image = global::LTEExcelAddIn.Properties.Resources.ts;
            this.menuTS.Items.Add(this.buttonTSAtObjects);
            this.menuTS.Label = "ТП";
            this.menuTS.Name = "menuTS";
            this.menuTS.ScreenTip = "Трансформаторні підстанції";
            this.menuTS.ShowImage = true;
            this.menuTS.SuperTip = "Запити до БД, щодо трансформаторних підстанцій";
            // 
            // buttonTSAtObjects
            // 
            this.buttonTSAtObjects.Image = ((System.Drawing.Image)(resources.GetObject("buttonTSAtObjects.Image")));
            this.buttonTSAtObjects.Label = "Живлення об\'єктів від ТП";
            this.buttonTSAtObjects.Name = "buttonTSAtObjects";
            this.buttonTSAtObjects.ScreenTip = "Живлення об\'єктів від ТП";
            this.buttonTSAtObjects.ShowImage = true;
            this.buttonTSAtObjects.SuperTip = "Запит до БД, який показує від яких трансформаторних підстанції живляться об\'єкти";
            this.buttonTSAtObjects.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonTSAtObjects_Click);
            // 
            // menuEmployees
            // 
            this.menuEmployees.Image = global::LTEExcelAddIn.Properties.Resources.employees;
            this.menuEmployees.Items.Add(this.buttonEmployeesES);
            this.menuEmployees.Label = "Працівники";
            this.menuEmployees.Name = "menuEmployees";
            this.menuEmployees.ScreenTip = "Працівники";
            this.menuEmployees.ShowImage = true;
            this.menuEmployees.SuperTip = "Запити до БД, щодо працівників";
            // 
            // buttonEmployeesES
            // 
            this.buttonEmployeesES.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployeesES.Image")));
            this.buttonEmployeesES.Label = "Працівники енергетичної служби";
            this.buttonEmployeesES.Name = "buttonEmployeesES";
            this.buttonEmployeesES.ScreenTip = "Працівники енергетичної служби";
            this.buttonEmployeesES.ShowImage = true;
            this.buttonEmployeesES.SuperTip = "Запит до БД, який показує інформацію про всіх працівників енергетичної служби";
            this.buttonEmployeesES.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonEmployeesES_Click);
            // 
            // buttonWilo
            // 
            this.buttonWilo.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonWilo.Image = global::LTEExcelAddIn.Properties.Resources.wilo;
            this.buttonWilo.Label = "Запчастини Wilo";
            this.buttonWilo.Name = "buttonWilo";
            this.buttonWilo.ShowImage = true;
            this.buttonWilo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonWilo_Click);
            // 
            // menuHomeFunctions
            // 
            this.menuHomeFunctions.Image = ((System.Drawing.Image)(resources.GetObject("menuHomeFunctions.Image")));
            this.menuHomeFunctions.Items.Add(this.buttonElectricPowerDoubleZones);
            this.menuHomeFunctions.Items.Add(this.buttonGas);
            this.menuHomeFunctions.Label = "ЖЕК";
            this.menuHomeFunctions.Name = "menuHomeFunctions";
            this.menuHomeFunctions.ScreenTip = " ЖЕК";
            this.menuHomeFunctions.ShowImage = true;
            this.menuHomeFunctions.SuperTip = "Формули, для підрахунку комунальних витрат";
            // 
            // buttonElectricPowerDoubleZones
            // 
            this.buttonElectricPowerDoubleZones.Image = ((System.Drawing.Image)(resources.GetObject("buttonElectricPowerDoubleZones.Image")));
            this.buttonElectricPowerDoubleZones.Label = "ЕЛЕКТРОЕНЕРГІЯ_ДВОХЗОННИЙ_09_16";
            this.buttonElectricPowerDoubleZones.Name = "buttonElectricPowerDoubleZones";
            this.buttonElectricPowerDoubleZones.ScreenTip = "Формула ЕЛЕКТРОЕНЕРГІЯ_ДВОХЗОННИЙ_09_16";
            this.buttonElectricPowerDoubleZones.ShowImage = true;
            this.buttonElectricPowerDoubleZones.SuperTip = "Формула, яка рахує суму за спожиту електроенергію за двозонним лічильником";
            this.buttonElectricPowerDoubleZones.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonElectricPowerDoubleZones_Click);
            // 
            // buttonGas
            // 
            this.buttonGas.Image = global::LTEExcelAddIn.Properties.Resources.gas;
            this.buttonGas.Label = "ГАЗ_05_16";
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.ScreenTip = "Формула ГАЗ_05_16";
            this.buttonGas.ShowImage = true;
            this.buttonGas.SuperTip = "Формула, яка рахує суму за спожитий газ";
            this.buttonGas.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGas_Click);
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCalculation.Image = global::LTEExcelAddIn.Properties.Resources.calculation;
            this.buttonCalculation.Label = "Калькуляція субспоживачів";
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.ScreenTip = "Калькуляція субспоживачів";
            this.buttonCalculation.ShowImage = true;
            this.buttonCalculation.SuperTip = "Завантажується форма, для створення калькуляції витрат на технічне обслуговування" +
                " за передачу електроенергії субспоживачу";
            // 
            // buttonMotorRepairs
            // 
            this.buttonMotorRepairs.Image = ((System.Drawing.Image)(resources.GetObject("buttonMotorRepairs.Image")));
            this.buttonMotorRepairs.Label = "Двигуни (історія ремонтів)";
            this.buttonMotorRepairs.Name = "buttonMotorRepairs";
            this.buttonMotorRepairs.ScreenTip = "Двигуни (історія ремонтів)";
            this.buttonMotorRepairs.ShowImage = true;
            this.buttonMotorRepairs.SuperTip = "Запит до БД, який показує інформацію по ремонту електродвигунів (історія)";
            this.buttonMotorRepairs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMotorRepairs_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.groupSQL.ResumeLayout(false);
            this.groupSQL.PerformLayout();
            this.groupFunctions.ResumeLayout(false);
            this.groupFunctions.PerformLayout();
            this.groupOther.ResumeLayout(false);
            this.groupOther.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSQL;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuContracts;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonContractsInformation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSQLSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSQLQuery;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuMotors;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMotorsInObjects;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMiniWiloMotors;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupFunctions;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuHomeFunctions;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonElectricPowerDoubleZones;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGas;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGroupByContracts;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuWilo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGroupByMiniMotors;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGroupByMiniWiloMotors;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGroupByPower;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSumPowerOfObjects;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonDecommissionedMotors;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonWiloSpareParts;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGroupByRotorsMiniWiloMotor;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuMeters;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMetersDescriptions;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMetersInObjects;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonObjectsHasNotMeters;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGroupMetersByContracts;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMetersHistory;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonJointInspection;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuTC;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonTCDescriptions;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonTCInObjects;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonTCHistory;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonJointInspection2;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuCondensers;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCondensersInObjects;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuTS;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonTSAtObjects;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuEmployees;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonEmployeesES;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonWilo;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupOther;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCalculation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMotorsHistory;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMotorRepairs;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
