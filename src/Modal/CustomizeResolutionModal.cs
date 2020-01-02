using System;
using System.Windows.Forms;

namespace ImageBond.Modal
{
    public partial class CustomizeResolutionModal : Form
    {
        /// <summary>
        /// init
        /// </summary>
        public CustomizeResolutionModal()
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
            width.Value = decimal.Parse(Properties.Settings.Default.width);
            height.Value = decimal.Parse(Properties.Settings.Default.height);
        }

        /// <summary>
        /// onFormClosed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.width = width.Value.ToString();
            Properties.Settings.Default.height = height.Value.ToString();
        }
    }
}
