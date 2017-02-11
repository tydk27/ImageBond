namespace ImageBond
{
    partial class ImageBond
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
            this.saveFolderTextBox = new System.Windows.Forms.TextBox();
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
            this.intY = new System.Windows.Forms.TextBox();
            this.cropLabel = new System.Windows.Forms.Label();
            this.intX = new System.Windows.Forms.TextBox();
            this.resizeMultiLabel = new System.Windows.Forms.Label();
            this.resizeLabel = new System.Windows.Forms.Label();
            this.postHeight = new System.Windows.Forms.TextBox();
            this.postWidth = new System.Windows.Forms.TextBox();
            this.sizeMultiLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.preHeight = new System.Windows.Forms.TextBox();
            this.preWidth = new System.Windows.Forms.TextBox();
            this.oneFileBond = new System.Windows.Forms.RadioButton();
            this.fourFilesBond = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFolderTextBox
            // 
            this.saveFolderTextBox.Location = new System.Drawing.Point(8, 18);
            this.saveFolderTextBox.Name = "saveFolderTextBox";
            this.saveFolderTextBox.Size = new System.Drawing.Size(205, 19);
            this.saveFolderTextBox.TabIndex = 9;
            this.saveFolderTextBox.TextChanged += new System.EventHandler(this.TextBox_TextCanged);
            // 
            // selectSaveFolderButton
            // 
            this.selectSaveFolderButton.Location = new System.Drawing.Point(219, 16);
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
            this.menuStrip1.Size = new System.Drawing.Size(1017, 26);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.versionToolStripMenuItem.Text = "バージョン(&V)";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectSaveFolderButton);
            this.groupBox1.Controls.Add(this.saveFolderTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "保存先";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yLabel);
            this.groupBox2.Controls.Add(this.xLabel);
            this.groupBox2.Controls.Add(this.intY);
            this.groupBox2.Controls.Add(this.cropLabel);
            this.groupBox2.Controls.Add(this.intX);
            this.groupBox2.Controls.Add(this.resizeMultiLabel);
            this.groupBox2.Controls.Add(this.resizeLabel);
            this.groupBox2.Controls.Add(this.postHeight);
            this.groupBox2.Controls.Add(this.postWidth);
            this.groupBox2.Controls.Add(this.sizeMultiLabel);
            this.groupBox2.Controls.Add(this.sizeLabel);
            this.groupBox2.Controls.Add(this.preHeight);
            this.groupBox2.Controls.Add(this.preWidth);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 106);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "画像の設定";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(164, 27);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(12, 12);
            this.yLabel.TabIndex = 13;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(115, 27);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 12);
            this.xLabel.TabIndex = 12;
            this.xLabel.Text = "X";
            // 
            // intY
            // 
            this.intY.Location = new System.Drawing.Point(182, 24);
            this.intY.Name = "intY";
            this.intY.Size = new System.Drawing.Size(25, 19);
            this.intY.TabIndex = 4;
            this.intY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.intY.TextChanged += new System.EventHandler(this.TextBox_TextCanged);
            // 
            // cropLabel
            // 
            this.cropLabel.AutoSize = true;
            this.cropLabel.Location = new System.Drawing.Point(6, 27);
            this.cropLabel.Name = "cropLabel";
            this.cropLabel.Size = new System.Drawing.Size(38, 12);
            this.cropLabel.TabIndex = 10;
            this.cropLabel.Text = "クロップ";
            // 
            // intX
            // 
            this.intX.Location = new System.Drawing.Point(133, 24);
            this.intX.Name = "intX";
            this.intX.Size = new System.Drawing.Size(25, 19);
            this.intX.TabIndex = 3;
            this.intX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.intX.TextChanged += new System.EventHandler(this.TextBox_TextCanged);
            // 
            // resizeMultiLabel
            // 
            this.resizeMultiLabel.AutoSize = true;
            this.resizeMultiLabel.Location = new System.Drawing.Point(173, 74);
            this.resizeMultiLabel.Name = "resizeMultiLabel";
            this.resizeMultiLabel.Size = new System.Drawing.Size(17, 12);
            this.resizeMultiLabel.TabIndex = 7;
            this.resizeMultiLabel.Text = "×";
            // 
            // resizeLabel
            // 
            this.resizeLabel.AutoSize = true;
            this.resizeLabel.Location = new System.Drawing.Point(6, 74);
            this.resizeLabel.Name = "resizeLabel";
            this.resizeLabel.Size = new System.Drawing.Size(92, 12);
            this.resizeLabel.TabIndex = 6;
            this.resizeLabel.Text = "リサイズ後のサイズ";
            // 
            // postHeight
            // 
            this.postHeight.Location = new System.Drawing.Point(196, 71);
            this.postHeight.Name = "postHeight";
            this.postHeight.Size = new System.Drawing.Size(50, 19);
            this.postHeight.TabIndex = 8;
            this.postHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.postHeight.TextChanged += new System.EventHandler(this.TextBox_TextCanged);
            // 
            // postWidth
            // 
            this.postWidth.Location = new System.Drawing.Point(117, 71);
            this.postWidth.Name = "postWidth";
            this.postWidth.Size = new System.Drawing.Size(50, 19);
            this.postWidth.TabIndex = 7;
            this.postWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.postWidth.TextChanged += new System.EventHandler(this.TextBox_TextCanged);
            // 
            // sizeMultiLabel
            // 
            this.sizeMultiLabel.AutoSize = true;
            this.sizeMultiLabel.Location = new System.Drawing.Point(173, 51);
            this.sizeMultiLabel.Name = "sizeMultiLabel";
            this.sizeMultiLabel.Size = new System.Drawing.Size(17, 12);
            this.sizeMultiLabel.TabIndex = 3;
            this.sizeMultiLabel.Text = "×";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(6, 51);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(80, 12);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "各画像のサイズ";
            // 
            // preHeight
            // 
            this.preHeight.Location = new System.Drawing.Point(196, 48);
            this.preHeight.Name = "preHeight";
            this.preHeight.Size = new System.Drawing.Size(50, 19);
            this.preHeight.TabIndex = 6;
            this.preHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.preHeight.TextChanged += new System.EventHandler(this.TextBox_TextCanged);
            // 
            // preWidth
            // 
            this.preWidth.Location = new System.Drawing.Point(117, 48);
            this.preWidth.Name = "preWidth";
            this.preWidth.Size = new System.Drawing.Size(50, 19);
            this.preWidth.TabIndex = 5;
            this.preWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.preWidth.TextChanged += new System.EventHandler(this.TextBox_TextCanged);
            // 
            // oneFileBond
            // 
            this.oneFileBond.AutoSize = true;
            this.oneFileBond.Enabled = false;
            this.oneFileBond.Location = new System.Drawing.Point(8, 18);
            this.oneFileBond.Name = "oneFileBond";
            this.oneFileBond.Size = new System.Drawing.Size(151, 16);
            this.oneFileBond.TabIndex = 1;
            this.oneFileBond.Text = "1つの画像ファイルをリサイズ";
            this.oneFileBond.UseVisualStyleBackColor = true;
            // 
            // fourFilesBond
            // 
            this.fourFilesBond.AutoSize = true;
            this.fourFilesBond.Checked = true;
            this.fourFilesBond.Location = new System.Drawing.Point(8, 41);
            this.fourFilesBond.Name = "fourFilesBond";
            this.fourFilesBond.Size = new System.Drawing.Size(193, 16);
            this.fourFilesBond.TabIndex = 2;
            this.fourFilesBond.TabStop = true;
            this.fourFilesBond.Text = "4つの画像ファイルを結合してリサイズ";
            this.fourFilesBond.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.oneFileBond);
            this.groupBox3.Controls.Add(this.fourFilesBond);
            this.groupBox3.Location = new System.Drawing.Point(12, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 65);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "生成タイプの選択";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 198);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(285, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(722, 427);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "画像をドラッグアンドドロップ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(357, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(352, 198);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBox4.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(6, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(352, 198);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(357, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 198);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(838, 463);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(919, 463);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 11;
            this.outputButton.Text = "出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // ImageBond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 495);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageBond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageBond";
            this.Load += new System.EventHandler(this.ImageBond_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saveFolderTextBox;
        private System.Windows.Forms.Button selectSaveFolderButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton oneFileBond;
        private System.Windows.Forms.RadioButton fourFilesBond;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label resizeMultiLabel;
        private System.Windows.Forms.Label resizeLabel;
        private System.Windows.Forms.TextBox postHeight;
        private System.Windows.Forms.TextBox postWidth;
        private System.Windows.Forms.Label sizeMultiLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox preHeight;
        private System.Windows.Forms.TextBox preWidth;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox intY;
        private System.Windows.Forms.Label cropLabel;
        private System.Windows.Forms.TextBox intX;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button outputButton;
    }
}

