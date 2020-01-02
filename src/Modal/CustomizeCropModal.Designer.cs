namespace ImageBond.Modal
{
    partial class CustomizeCropModal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cropY = new System.Windows.Forms.NumericUpDown();
            this.cropX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cropY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropX)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // cropY
            // 
            this.cropY.Location = new System.Drawing.Point(115, 11);
            this.cropY.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.cropY.Name = "cropY";
            this.cropY.Size = new System.Drawing.Size(60, 19);
            this.cropY.TabIndex = 5;
            this.cropY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cropX
            // 
            this.cropX.Location = new System.Drawing.Point(31, 11);
            this.cropX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.cropX.Name = "cropX";
            this.cropX.Size = new System.Drawing.Size(60, 19);
            this.cropX.TabIndex = 4;
            this.cropX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CustomizeCropModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 40);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cropY);
            this.Controls.Add(this.cropX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeCropModal";
            this.Text = "クロップ設定";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.cropY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cropY;
        private System.Windows.Forms.NumericUpDown cropX;
    }
}