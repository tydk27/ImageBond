namespace ImageBond
{
    partial class ImageBondForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.output = new System.Windows.Forms.TextBox();
            this.selectSaveFolderButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.cropY = new System.Windows.Forms.TextBox();
            this.cropLabel = new System.Windows.Forms.Label();
            this.cropX = new System.Windows.Forms.TextBox();
            this.resizeMultiLabel = new System.Windows.Forms.Label();
            this.resizeLabel = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bottomLeftBox = new System.Windows.Forms.PictureBox();
            this.bottomRightBox = new System.Windows.Forms.PictureBox();
            this.topLeftBox = new System.Windows.Forms.PictureBox();
            this.topRightBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(8, 18);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(296, 19);
            this.output.TabIndex = 9;
            // 
            // selectSaveFolderButton
            // 
            this.selectSaveFolderButton.Location = new System.Drawing.Point(310, 16);
            this.selectSaveFolderButton.Name = "selectSaveFolderButton";
            this.selectSaveFolderButton.Size = new System.Drawing.Size(42, 23);
            this.selectSaveFolderButton.TabIndex = 10;
            this.selectSaveFolderButton.Text = "選択";
            this.selectSaveFolderButton.UseVisualStyleBackColor = true;
            this.selectSaveFolderButton.Click += new System.EventHandler(this.SelectSaveFolderButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.versionToolStripMenuItem.Text = "バージョン(&V)";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectSaveFolderButton);
            this.groupBox1.Controls.Add(this.output);
            this.groupBox1.Location = new System.Drawing.Point(376, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "保存先";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yLabel);
            this.groupBox2.Controls.Add(this.xLabel);
            this.groupBox2.Controls.Add(this.cropY);
            this.groupBox2.Controls.Add(this.cropLabel);
            this.groupBox2.Controls.Add(this.cropX);
            this.groupBox2.Controls.Add(this.resizeMultiLabel);
            this.groupBox2.Controls.Add(this.resizeLabel);
            this.groupBox2.Controls.Add(this.height);
            this.groupBox2.Controls.Add(this.width);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 96);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "画像の設定";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(160, 24);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(12, 12);
            this.yLabel.TabIndex = 13;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(102, 24);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 12);
            this.xLabel.TabIndex = 12;
            this.xLabel.Text = "X";
            // 
            // cropY
            // 
            this.cropY.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ImageBond.Properties.Settings.Default, "cropY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cropY.Location = new System.Drawing.Point(178, 21);
            this.cropY.Name = "cropY";
            this.cropY.Size = new System.Drawing.Size(25, 19);
            this.cropY.TabIndex = 4;
            this.cropY.Text = global::ImageBond.Properties.Settings.Default.cropY;
            this.cropY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cropLabel
            // 
            this.cropLabel.AutoSize = true;
            this.cropLabel.Location = new System.Drawing.Point(6, 24);
            this.cropLabel.Name = "cropLabel";
            this.cropLabel.Size = new System.Drawing.Size(38, 12);
            this.cropLabel.TabIndex = 10;
            this.cropLabel.Text = "クロップ";
            // 
            // cropX
            // 
            this.cropX.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ImageBond.Properties.Settings.Default, "cropX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cropX.Location = new System.Drawing.Point(120, 21);
            this.cropX.Name = "cropX";
            this.cropX.Size = new System.Drawing.Size(25, 19);
            this.cropX.TabIndex = 3;
            this.cropX.Text = global::ImageBond.Properties.Settings.Default.cropX;
            this.cropX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resizeMultiLabel
            // 
            this.resizeMultiLabel.AutoSize = true;
            this.resizeMultiLabel.Location = new System.Drawing.Point(160, 60);
            this.resizeMultiLabel.Name = "resizeMultiLabel";
            this.resizeMultiLabel.Size = new System.Drawing.Size(17, 12);
            this.resizeMultiLabel.TabIndex = 7;
            this.resizeMultiLabel.Text = "×";
            // 
            // resizeLabel
            // 
            this.resizeLabel.AutoSize = true;
            this.resizeLabel.Location = new System.Drawing.Point(6, 60);
            this.resizeLabel.Name = "resizeLabel";
            this.resizeLabel.Size = new System.Drawing.Size(92, 12);
            this.resizeLabel.TabIndex = 6;
            this.resizeLabel.Text = "リサイズ後のサイズ";
            // 
            // height
            // 
            this.height.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ImageBond.Properties.Settings.Default, "hight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.height.Location = new System.Drawing.Point(183, 57);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(50, 19);
            this.height.TabIndex = 8;
            this.height.Text = global::ImageBond.Properties.Settings.Default.hight;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // width
            // 
            this.width.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ImageBond.Properties.Settings.Default, "width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.width.Location = new System.Drawing.Point(104, 57);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(50, 19);
            this.width.TabIndex = 7;
            this.width.Text = global::ImageBond.Properties.Settings.Default.width;
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bottomLeftBox);
            this.groupBox4.Controls.Add(this.bottomRightBox);
            this.groupBox4.Controls.Add(this.topLeftBox);
            this.groupBox4.Controls.Add(this.topRightBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(722, 427);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "画像をドラッグアンドドロップ";
            // 
            // bottomLeftBox
            // 
            this.bottomLeftBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.bottomLeftBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeftBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bottomLeftBox.Location = new System.Drawing.Point(357, 217);
            this.bottomLeftBox.Name = "bottomLeftBox";
            this.bottomLeftBox.Size = new System.Drawing.Size(352, 198);
            this.bottomLeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomLeftBox.TabIndex = 20;
            this.bottomLeftBox.TabStop = false;
            this.bottomLeftBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.bottomLeftBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // bottomRightBox
            // 
            this.bottomRightBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.bottomRightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRightBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bottomRightBox.Location = new System.Drawing.Point(6, 217);
            this.bottomRightBox.Name = "bottomRightBox";
            this.bottomRightBox.Size = new System.Drawing.Size(352, 198);
            this.bottomRightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomRightBox.TabIndex = 19;
            this.bottomRightBox.TabStop = false;
            this.bottomRightBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.bottomRightBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // topLeftBox
            // 
            this.topLeftBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.topLeftBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeftBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.topLeftBox.Location = new System.Drawing.Point(357, 20);
            this.topLeftBox.Name = "topLeftBox";
            this.topLeftBox.Size = new System.Drawing.Size(352, 198);
            this.topLeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topLeftBox.TabIndex = 18;
            this.topLeftBox.TabStop = false;
            this.topLeftBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.topLeftBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // topRightBox
            // 
            this.topRightBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.topRightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRightBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.topRightBox.Location = new System.Drawing.Point(6, 20);
            this.topRightBox.Name = "topRightBox";
            this.topRightBox.Size = new System.Drawing.Size(352, 198);
            this.topRightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topRightBox.TabIndex = 17;
            this.topRightBox.TabStop = false;
            this.topRightBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.topRightBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(578, 562);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(659, 562);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 11;
            this.outputButton.Text = "出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // ImageBondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 598);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageBondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageBond";
            this.Load += new System.EventHandler(this.ImageBondForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button selectSaveFolderButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox topRightBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label resizeLabel;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.PictureBox bottomLeftBox;
        private System.Windows.Forms.PictureBox bottomRightBox;
        private System.Windows.Forms.PictureBox topLeftBox;
        private System.Windows.Forms.TextBox cropY;
        private System.Windows.Forms.Label cropLabel;
        private System.Windows.Forms.TextBox cropX;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label resizeMultiLabel;
    }
}

