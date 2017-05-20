using System;
using System.Windows.Forms;

namespace ImageBond.Views.Modal
{
    public partial class CustomizeCropModal : Form
    {
        /// <summary>
        /// init
        /// </summary>
        public CustomizeCropModal()
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
            cropX.Value = decimal.Parse(Properties.Settings.Default.cropX);
            cropY.Value = decimal.Parse(Properties.Settings.Default.cropY);
        }

        /// <summary>
        /// onFormClosed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.cropX = cropX.Value.ToString();
            Properties.Settings.Default.cropY = cropY.Value.ToString();
        }
    }
}
