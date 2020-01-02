using System;
using System.Reflection;
using System.Windows.Forms;

namespace ImageBond.Modal
{
    /// <summary>
    /// VersionInfoFormClass
    /// </summary>
    public partial class VersionInfoModal : Form
    {
        /// <summary>
        /// init
        /// </summary>
        public VersionInfoModal()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// onLoad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onLoad(object sender, EventArgs e)
        {
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
            productName.Text = appProductName + " : version " + appVersion;
            copyright.Text = appCopyright;
        }
    }
}
