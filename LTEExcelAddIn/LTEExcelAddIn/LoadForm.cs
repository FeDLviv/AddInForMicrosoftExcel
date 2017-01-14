using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace LTEExcelAddIn
{
    public partial class LoadForm : Form
    {
        private string query;
        private string title;
        private bool cancel = false;

        public LoadForm(string query, string title)
        {
            //ПІДСВІТКА ЗАПИТА В ПІДКАЗЦІ (ГРУПОВИЙ РЕГУЛЯРНИЙ ВИРАЗ + ДРОБОВІ ЧИСЛА(КОМА) + ЦИФРИ(ОКРЕМО))
            //ЦЕНТРУВАННЯ НАЗВИ КОЛОНОК
            //"РОЗМАЗУВАННЯ" ВІКНА ПРИ ВИКОНАННІ ЗАПИТА?
            //ЛОКАЛІЗАЦІЯ ВІКНА ПОМИЛОК
            //МЕРЕХТІННЯ КУРСОРА ПРИ ВИКОНАННІ ЗАПИТА
            //ДОВГЕ ЗАПОВНЕННЯ ТАБЛИЦІ
            //КОМЕНТАРІ
            
            //ВІДМІНА ЗАПИТУ (ПОВІДОМЛЕННЯ ПРО ВІДМІНУ, ЗНИКАЄ ПРОГРЕС-ВІКНО, ЯКЩО ПОМИЛКА)
            //MySqlConnectionStringBuilder binding
            
            InitializeComponent();

            this.query = query;
            this.title = title;
            backgroundWorker.RunWorkerAsync();
            timer.Start();
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                timer.Stop();
                cancel = true;
                backgroundWorker.CancelAsync();
            }
        }

        private void SetTitleText(string text)
        {
            if (IsHandleCreated)
            {
                Invoke(new Action(() => { Text = text; }));
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {   
                //SetTitleText("З'єднання з БД...");
                using (MySqlConnection connect = new MySqlConnection(Ribbon.connectString.ConnectionString))
                {
                    connect.Open();
                    if (backgroundWorker.CancellationPending)
                    {
                        cancel = true;
                        return;
                    }
                    SetTitleText("Виконання запита...");
                    MySqlCommand command = new MySqlCommand(query, connect);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        EnableExcelSettings(false);
                        CreateTable(reader, query, title);
                    }
                    command.Dispose();
                }
            }

            catch (Exception ex)
            {
                if (cancel)
                {
                    return;
                }
                timer.Stop();
                var dialogType = typeof(Form).Assembly.GetType("System.Windows.Forms.PropertyGridInternal.GridErrorDlg");
                var dialog = (Form) Activator.CreateInstance(dialogType, new PropertyGrid());
                dialog.Text = "Помилка";
                dialogType.GetProperty("Message").SetValue(dialog, ex.Message, null);
                dialogType.GetProperty("Details").SetValue(dialog, ex.StackTrace, null);
                dialog.ShowDialog();
            }
        }

        private void EnableExcelSettings(bool enable)
        {
            //DEBUG ERROR (В ЦЬОМУ МЕТОДІ) ЗАПИТ ПРИ ВІДКРИТОМУ КОМЕНТАРІ
            Globals.ThisAddIn.Application.ScreenUpdating = enable;
            Globals.ThisAddIn.Application.DisplayStatusBar = enable;
            Globals.ThisAddIn.Application.EnableEvents = enable; //DEBUG ERROR ЗАПИТ ПРИ ВІДКРИТОМУ КОМЕНТАРІ
            Globals.ThisAddIn.Application.DisplayAlerts = enable; //DEBUG ERROR ЗАПИТ ПРИ ВІДКРИТОМУ КОМЕНТАРІ
            //Globals.ThisAddIn.Application.ActiveSheet.DisplayPageBreaks = enable;
            Globals.ThisAddIn.Application.Calculation = enable ? Excel.XlCalculation.xlCalculationAutomatic : Excel.XlCalculation.xlCalculationManual; //DEBUG ERROR ЗАПИТ ПРИ ВІДКРИТОМУ КОМЕНТАРІ
        }

        private void CreateTable(MySqlDataReader reader, string query, string title)
        {
            SetTitleText("Заповнення таблиці...");
            int row = 2;
            int col = 1;

            Excel.Worksheet sheet = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets.Add();

            for (; col <= reader.FieldCount; col++)
            {
                sheet.Cells[row, col] = reader.GetName(col - 1);
            }
            col--;
            bool[] arrColumn = Enumerable.Repeat(true, col).ToArray();

            for (row++; reader.Read(); row++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    return;
                }
                for (int i = 0; i < col; i++)
                {
                    if (reader.IsDBNull(i))
                    {
                        sheet.Cells[row, i + 1] = string.Empty;
                        arrColumn[i] = false;
                    }
                    else
                    {
                        sheet.Cells[row, i + 1] = reader.GetString(i);
                    }
                }
            }
            row--;

            SetTitleText("Завершення...");
            CreateCommentAndTitle(sheet, query, title, col);

            Excel.Range range = sheet.Range[sheet.Cells[2, 1], sheet.Cells[row, col]];
            Excel.ListObject table = range.Worksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, range, System.Type.Missing, Excel.XlYesNoGuess.xlYes);
            table.TableStyle = "TableStyleMedium8";
            table.ShowTotals = true;
            table.ListColumns[col].TotalsCalculation = Excel.XlTotalsCalculation.xlTotalsCalculationNone;
            int column = Array.IndexOf(arrColumn, true) + 1;
            if (column != 0)
            {
                table.ListColumns[column].TotalsCalculation = Excel.XlTotalsCalculation.xlTotalsCalculationCount;
            }

            sheet.Columns.AutoFit();
        }

        private void CreateCommentAndTitle(Excel.Worksheet sheet, string query, string title, int columnCount)
        {
            sheet.Range["A1"].AddComment(query);
            sheet.Range["A1"].Comment.Visible = false;
            sheet.Range["A1"].Comment.Shape.TextFrame.AutoSize = true;
            foreach (Match x in Ribbon.rgx1.Matches(query))
            {
                sheet.Range["A1"].Comment.Shape.TextFrame.Characters(x.Index + 1, x.Length).Font.Color = Ribbon.colorBlue;
            }

            foreach (Match x in Ribbon.rgx2.Matches(query))
            {
                sheet.Range["A1"].Comment.Shape.TextFrame.Characters(x.Index + 1, x.Length).Font.Color = Ribbon.colorRed;
            }

            Excel.Range range = sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, columnCount]];
            range.Merge();
            range.HorizontalAlignment = Excel.Constants.xlCenter;
            range.Font.Bold = true;
            range.Value = title;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableExcelSettings(true);
            timer.Stop();
            if (IsHandleCreated)
            {
                Invoke(new Action(() => { Close(); }));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invoke( new Action(() => { label.Text = (int.Parse(label.Text) + 1).ToString("D2"); }));
        }
    }
}