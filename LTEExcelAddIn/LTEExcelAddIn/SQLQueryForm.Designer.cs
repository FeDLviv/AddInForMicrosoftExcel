namespace LTEExcelAddIn
{
    partial class SQLQueryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLQueryForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.autocompleteMenu = new AutocompleteMenuNS.AutocompleteMenu();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.fastColoredTextBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.button, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(432, 308);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // fastColoredTextBox
            // 
            this.fastColoredTextBox.AutoCompleteBrackets = true;
            this.fastColoredTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.autocompleteMenu.SetAutocompleteMenu(this.fastColoredTextBox, this.autocompleteMenu);
            this.fastColoredTextBox.AutoIndentCharsPatterns = "";
            this.fastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(164, 64);
            this.fastColoredTextBox.BackBrush = null;
            this.fastColoredTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBox.CharHeight = 16;
            this.fastColoredTextBox.CharWidth = 9;
            this.tableLayoutPanel.SetColumnSpan(this.fastColoredTextBox, 2);
            this.fastColoredTextBox.CommentPrefix = "--";
            this.fastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LTEExcelAddIn.Properties.Settings.Default, "Query", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox.Font = new System.Drawing.Font("Courier New", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fastColoredTextBox.IndentBackColor = System.Drawing.Color.LightGray;
            this.fastColoredTextBox.IsReplaceMode = false;
            this.fastColoredTextBox.Language = FastColoredTextBoxNS.Language.SQL;
            this.fastColoredTextBox.LeftBracket = '(';
            this.fastColoredTextBox.LineNumberColor = System.Drawing.Color.DarkSlateGray;
            this.fastColoredTextBox.Location = new System.Drawing.Point(10, 45);
            this.fastColoredTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.fastColoredTextBox.Name = "fastColoredTextBox";
            this.fastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox.RightBracket = ')';
            this.fastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox.ServiceColors")));
            this.fastColoredTextBox.Size = new System.Drawing.Size(412, 210);
            this.fastColoredTextBox.TabIndex = 0;
            this.fastColoredTextBox.Text = global::LTEExcelAddIn.Properties.Settings.Default.Query;
            this.fastColoredTextBox.Zoom = 100;
            this.fastColoredTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox_TextChanged);
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel.SetColumnSpan(this.button, 2);
            this.button.Location = new System.Drawing.Point(347, 275);
            this.button.Margin = new System.Windows.Forms.Padding(10);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Запит";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(10, 13);
            this.label.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 13);
            this.label.TabIndex = 2;
            this.label.Text = "назва запита:";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Запит"});
            this.autocompleteMenu.SetAutocompleteMenu(this.textBox, null);
            this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox.Location = new System.Drawing.Point(121, 10);
            this.textBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(301, 20);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "Запит";
            // 
            // autocompleteMenu
            // 
            this.autocompleteMenu.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu.Colors")));
            this.autocompleteMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu.ImageList = this.imageList;
            this.autocompleteMenu.Items = new string[0];
            this.autocompleteMenu.TargetControlWrapper = null;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "mysql.png");
            // 
            // SQLQueryForm
            // 
            this.AcceptButton = this.button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 308);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "SQLQueryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Створення запита";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateQueryForm_FormClosing);
            this.Load += new System.EventHandler(this.SQLQueryForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ImageList imageList;

    }
}