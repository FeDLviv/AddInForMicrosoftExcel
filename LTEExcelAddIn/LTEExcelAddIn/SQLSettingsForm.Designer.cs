namespace LTEExcelAddIn
{
    partial class SQLSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.textBoxDataBase, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxUser, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelServer, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelUser, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelPassword, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelDatabase, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.button, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxServer, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(261, 176);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxDataBase
            // 
            this.textBoxDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataBase.AutoCompleteCustomSource.AddRange(new string[] {
            "lte_energo"});
            this.textBoxDataBase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDataBase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDataBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LTEExcelAddIn.Properties.Settings.Default, "Database", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDataBase.Location = new System.Drawing.Point(98, 100);
            this.textBoxDataBase.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDataBase.MinimumSize = new System.Drawing.Size(150, 4);
            this.textBoxDataBase.Name = "textBoxDataBase";
            this.textBoxDataBase.Size = new System.Drawing.Size(153, 20);
            this.textBoxDataBase.TabIndex = 3;
            this.textBoxDataBase.Text = global::LTEExcelAddIn.Properties.Settings.Default.Database;
            this.textBoxDataBase.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LTEExcelAddIn.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPassword.Location = new System.Drawing.Point(98, 70);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(150, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(153, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = global::LTEExcelAddIn.Properties.Settings.Default.Password;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUser.AutoCompleteCustomSource.AddRange(new string[] {
            "wges"});
            this.textBoxUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LTEExcelAddIn.Properties.Settings.Default, "User", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUser.Location = new System.Drawing.Point(98, 40);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUser.MinimumSize = new System.Drawing.Size(150, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(153, 20);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.Text = global::LTEExcelAddIn.Properties.Settings.Default.User;
            this.textBoxUser.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // labelServer
            // 
            this.labelServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServer.Location = new System.Drawing.Point(10, 13);
            this.labelServer.Margin = new System.Windows.Forms.Padding(5);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(53, 13);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "сервер:";
            this.labelServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(10, 43);
            this.labelUser.Margin = new System.Windows.Forms.Padding(5);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(78, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "користувач:";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(10, 73);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "пароль:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDatabase
            // 
            this.labelDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDatabase.Location = new System.Drawing.Point(10, 103);
            this.labelDatabase.Margin = new System.Windows.Forms.Padding(5);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(77, 13);
            this.labelDatabase.TabIndex = 3;
            this.labelDatabase.Text = "база даних:";
            this.labelDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.SetColumnSpan(this.button, 2);
            this.button.Location = new System.Drawing.Point(93, 145);
            this.button.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 4;
            this.button.Text = "Зберегти";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServer.AutoCompleteCustomSource.AddRange(new string[] {
            "192.168.1.4"});
            this.textBoxServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LTEExcelAddIn.Properties.Settings.Default, "Server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxServer.Location = new System.Drawing.Point(98, 10);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxServer.MinimumSize = new System.Drawing.Size(150, 4);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(153, 20);
            this.textBoxServer.TabIndex = 0;
            this.textBoxServer.Text = global::LTEExcelAddIn.Properties.Settings.Default.Server;
            this.textBoxServer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxServer_Validating);
            // 
            // SQLSettingsForm
            // 
            this.AcceptButton = this.button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(261, 176);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQLSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Налаштування з\'єднання з БД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQLSettingsForm_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxServer;
    }
}