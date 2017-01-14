using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Data;
using System.Drawing; 
using System.Windows.Forms; 
using System.ComponentModel;


namespace LTEExcelAddIn
{
    public partial class SQLSettingsForm : Form
    {
        //КОМЕНТАРІ

        public SQLSettingsForm()
        {
            InitializeComponent();
        }

        private void SQLSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void textBoxServer_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                IPAddress.Parse(textBoxServer.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Введіть коректну IP адресу сервера.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button.Focus();
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (temp != null)
            {
                if (string.IsNullOrWhiteSpace(temp.Text))
                {
                    e.Cancel = true;
                    MessageBox.Show("Введіть будь-ласка дані в текстове поле.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button.Focus();
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Ribbon.connectString.Server = Properties.Settings.Default.Server;
            Ribbon.connectString.Database = Properties.Settings.Default.Database;
            Ribbon.connectString.UserID = Properties.Settings.Default.User;
            Ribbon.connectString.Password = Properties.Settings.Default.Password;
            Close();
        }
    }
}