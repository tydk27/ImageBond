using System;
using System.Windows.Forms;

namespace ImageBond
{
    static class ImageBondMain
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ImageBondForm());

            Properties.Settings.Default.Save();
        }
    }
}
