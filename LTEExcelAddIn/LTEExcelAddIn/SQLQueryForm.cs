using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Specialized;

namespace LTEExcelAddIn
{
    public partial class SQLQueryForm : Form
    {
        //ДООПРАЦЮВАТИ ВІКНО ЗАПИТІВ (ПІДКАЗКИ ДО КЛЮЧОВИХ СЛІВ)
        //КОМЕНТАРІ

        private readonly StringCollection listWords = new StringCollection() { "ADD", "ALL", "ALTER", "ANALYZE", "AND", "AS", "ASC", "ASENSITIVE", "AUTO_INCREMENT", "BDB", "BEFORE", "BERKELEYDB", "BETWEEN", "BIGINT", "BINARY", "BLOB", "BOTH", "BY", "CALL", "CASCADE", "CASE", "CHANGE", "CHAR", "CHARACTER", "CHECK", "COLLATE", "COLUMN", "COLUMNS", "CONDITION", "CONNECTION", "CONSTRAINT", "CONTINUE", "CREATE", "CROSS", "CURRENT_DATE", "CURRENT_TIME", "CURRENT_TIMESTAMP", "CURSOR", "DATABASE", "DATABASES", "DAY_HOUR", "DAY_MICROSECOND", "DAY_MINUTE", "DAY_SECOND", "DEC", "DECIMAL", "DECLARE", "DEFAULT", "DELAYED", "DELETE", "DESC", "DESCRIBE", "DETERMINISTIC", "DISTINCT", "DISTINCTROW", "DIV", "DOUBLE", "DROP", "ELSE", "ELSEIF", "ENCLOSED", "ESCAPED", "EXISTS", "EXIT", "EXPLAIN", "FALSE", "FETCH", "FIELDS", "FLOAT", "FOR", "FORCE", "FOREIGN", "FOUND", "FRAC_SECOND", "FROM", "FULLTEXT", "GRANT", "HAVING", "HIGH_PRIORITY", "HOUR_MICROSECOND", "HOUR_MINUTE", "HOUR_SECOND", "IF", "IGNORE", "IN", "INDEX", "INFILE", "INNER", "INNODB", "INOUT", "INSENSITIVE", "INSERT", "INT", "INTEGER", "INTERVAL", "INTO", "IO_THREAD", "IS", "ITERATE", "JOIN", "KEY", "KEYS", "KILL", "LEADING", "LEAVE", "LEFT", "LIKE", "LIMIT", "LINES", "LOAD", "LOCALTIME", "LOCALTIMESTAMP", "LOCK", "LONG", "LONGBLOB", "LONGTEXT", "LOOP", "LOW_PRIORITY", "MASTER_SERVER_ID", "MATCH", "MEDIUMBLOB", "MEDIUMINT", "MEDIUMTEXT", "MIDDLEINT", "MINUTE_MICROSECOND", "MINUTE_SECOND", "MOD", "NATURAL", "NOT", "NO_WRITE_TO_BINLOG", "NULL", "NUMERIC", "ON", "OPTIMIZE", "OPTION", "OPTIONALLY", "OR", "OUT", "OUTER", "OUTFILE", "PRECISION", "PRIMARY", "PRIVILEGES", "PROCEDURE", "PURGE", "READ", "REAL", "REFERENCES", "REGEXP", "RENAME", "REPEAT", "REPLACE", "REQUIRE", "RESTRICT", "RETURN", "REVOKE", "RIGHT", "RLIKE", "SECOND_MICROSECOND", "SENSITIVE", "SEPARATOR", "SET", "SHOW", "SMALLINT", "SOME", "SONAME", "SPATIAL", "SPECIFIC", "SQL", "SQLEXCEPTION", "SQLSTATE", "SQLWARNING", "SQL_BIG_RESULT", "SQL_CALC_FOUND_ROWS", "SQL_SMALL_RESULT", "SQL_TSI_DAY", "SQL_TSI_FRAC_SECOND", "SQL_TSI_HOUR", "SQL_TSI_MINUTE", "SQL_TSI_MONTH", "SQL_TSI_QUARTER", "SQL_TSI_SECOND", "SQL_TSI_WEEK", "SQL_TSI_YEAR", "SSL", "STARTING", "STRAIGHT_JOIN", "STRIPED", "TABLE", "TABLES", "TERMINATED", "THEN", "TIMESTAMPADD", "TIMESTAMPDIFF", "TINYBLOB", "TINYINT", "TINYTEXT", "TO", "TRAILING", "TRUE", "UNDO", "UNION", "UNIQUE", "UNLOCK", "UNSIGNED", "UPDATE", "USAGE", "USE", "USER_RESOURCES", "USING", "UTC_DATE", "UTC_TIME", "UTC_TIMESTAMP", "VALUES", "VARBINARY", "VARCHAR", "VARCHARACTER", "VARYING", "WHEN", "WHERE", "WHILE", "WITH", "WRITE", "XOR", "YEAR_MONTH", "ZEROFILL" };
        private readonly Dictionary<string, string> listWordsToolTip = new Dictionary<string, string>() 
        { 
            {"SELECT", "Конструкція:\nSELECT ім'я_стовбця, ... FROM ім'я_таблиці, ... \n[WHERE ...]\n[UNION ...]\n[GROUP BY ...]\n[HAVING ...]\n[ORDER BY ...];"}, 
            {"GROUP", "Агрегатні функції (GROUP BY):\nAVG()\nBIT_AND()\nBIT_OR()\nBIT_XOR()\nCOUNT()\nCOUNT(DISTINCT)\nGROUP_CONCAT()\nGROUP_CONCAT()\nMAX()\nMIN()\nSTD()\nSTDDEV()\nSTDDEV_POP()\nSTDDEV_SAMP()\nSUM()\nVAR_POP()\nVAR_SAMP()\nVARIANCE()"},
            {"ORDER", "Сортування (ORDER BY):\nASC - по зростанню (за замовчуванням)\nDESC - по спаданню"}
        };

        public SQLQueryForm()
        {
            InitializeComponent();
            SetAutocompleteMenu();
        }

        private void SQLQueryForm_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.LocationSQLQueryForm;
            Size = Properties.Settings.Default.SizeSQLQueryForm;
        }

        private void CreateQueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Reload();
            Properties.Settings.Default.LocationSQLQueryForm = Location;
            Properties.Settings.Default.SizeSQLQueryForm = Size;
            Properties.Settings.Default.Save();
        }

        private void fastColoredTextBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            FastColoredTextBoxNS.FastColoredTextBox temp = sender as FastColoredTextBoxNS.FastColoredTextBox;
            if (temp != null)
            {
                if (string.IsNullOrWhiteSpace(temp.Text))
                {
                    button.Enabled = false;
                }
                else
                {
                    button.Enabled = true;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
            new LoadForm(Properties.Settings.Default.Query, textBox.Text).ShowDialog();
        }

        private void SetAutocompleteMenu()
        {
            foreach (string x in listWords)
            {
                autocompleteMenu.AddItem(new MySQLWord(x));
            }
            foreach (var x in listWordsToolTip)
            {
                autocompleteMenu.AddItem(new MySQLWord(x.Key, x.Value));
            }
        }

        internal class MySQLWord : AutocompleteMenuNS.AutocompleteItem
        {
            public MySQLWord(string word, string toolTip = null, string title = "Ключове слово")
                : base(word)
            {
                Text = word;
                ImageIndex = 0;
                if (toolTip != null)
                {
                    ToolTipTitle = title;
                    ToolTipText = toolTip;
                }
            }
        }
    }
}