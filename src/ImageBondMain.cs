using System;
using System.Windows.Forms;

namespace ImageBond
{
    static class ImageBondMain
    {
        /// <summary>
        /// Main
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Main.ImageBondForm());

            Properties.Settings.Default.Save();
        }
    }
}
