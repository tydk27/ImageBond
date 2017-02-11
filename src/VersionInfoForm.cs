using System;
using System.Reflection;
using System.Windows.Forms;

namespace ImageBond
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VersionInfoForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public VersionInfoForm()
        {
            InitializeComponent();

            Assembly mainAssembly = Assembly.GetEntryAssembly();
            AssemblyName mainAssemName = mainAssembly.GetName();
            Version appVersion = mainAssemName.Version; 

            string appProductName = Application.ProductName;
            
            string appCopyright = "-";
            object[] CopyrightArray = mainAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

            if ((CopyrightArray != null) && (CopyrightArray.Length > 0))
            {
                appCopyright = ((AssemblyCopyrightAttribute)CopyrightArray[0]).Copyright;
            }
            
            Text = appProductName + " のバージョン情報";
            label1.Text = appProductName + " : version " + appVersion;
            label2.Text = appCopyright;
        }
    }
}
