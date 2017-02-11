using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBond
{
    public partial class VersionInfo : Form
    {
        public VersionInfo()
        {
            InitializeComponent();

            Assembly mainAssembly = Assembly.GetEntryAssembly();
            AssemblyName mainAssemName = mainAssembly.GetName();
            Version appVersion = mainAssemName.Version; 

            string appProductName = Application.ProductName;
            
            string appCopyright = "-";
            object[] CopyrightArray =
               mainAssembly.GetCustomAttributes(
                 typeof(AssemblyCopyrightAttribute), false);
            if ((CopyrightArray != null) && (CopyrightArray.Length > 0))
            {
                appCopyright =
                  ((AssemblyCopyrightAttribute)CopyrightArray[0]).Copyright;
            }
            
            Text = appProductName + " のバージョン情報";
            label1.Text = appProductName + " : Version " + appVersion;
            label2.Text = appCopyright;
        }
    }
}
