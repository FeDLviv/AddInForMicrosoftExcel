using LTEExcelAddIn.WPF.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Windows.Markup;
using System.IO;
using System.Reflection;

namespace LTEExcelAddIn
{
    public partial class WiloForm : Form
    {
        public WiloForm()
        {
            InitializeComponent();
            elementHost.Child = CreateControlFromFile();
        }

        private System.Windows.Controls.UserControl CreateControlFromFile()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream str = assembly.GetManifestResourceStream("LTEExcelAddIn.WPF.Views.WiloView.xaml"))
            {
                System.Windows.Controls.UserControl control = (System.Windows.Controls.UserControl) XamlReader.Load(str);
                control.DataContext = new MainViewModel();
                return control;
            }
        }
    }
}