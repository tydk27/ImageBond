namespace ImageBond.Views.Main
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
            this.saveFileNameBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setSaveDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageStage = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileNameLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.bottomRightBox = new System.Windows.Forms.PictureBox();
            this.bottomLeftBox = new System.Windows.Forms.PictureBox();
            this.topRightBox = new System.Windows.Forms.PictureBox();
            this.topLeftBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.imageStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileNameBox
            // 
            this.saveFileNameBox.Location = new System.Drawing.Point(91, 416);
            this.saveFileNameBox.Name = "saveFileNameBox";
            this.saveFileNameBox.Size = new System.Drawing.Size(572, 19);
            this.saveFileNameBox.TabIndex = 9;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(677, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSaveDirectoryMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileMenu.Size = new System.Drawing.Size(67, 20);
            this.fileMenu.Text = "ファイル(&F)";
            // 
            // setSaveDirectoryMenuItem
            // 
            this.setSaveDirectoryMenuItem.Name = "setSaveDirectoryMenuItem";
            this.setSaveDirectoryMenuItem.Size = new System.Drawing.Size(124, 22);
            this.setSaveDirectoryMenuItem.Text = "保存先(&S)";
            this.setSaveDirectoryMenuItem.Click += new System.EventHandler(this.OnClickSetSaveDirectory);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitMenuItem.Text = "終了(&X)";
            this.exitMenuItem.Click += new System.EventHandler(this.OnClickExit);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolutionMenuItem,
            this.cropMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(57, 20);
            this.editMenu.Text = "編集(&E)";
            // 
            // resolutionMenuItem
            // 
            this.resolutionMenuItem.Name = "resolutionMenuItem";
            this.resolutionMenuItem.Size = new System.Drawing.Size(149, 22);
            this.resolutionMenuItem.Text = "解像度設定(&R)";
            this.resolutionMenuItem.Click += new System.EventHandler(this.OnClickCustomizeResolution);
            // 
            // cropMenuItem
            // 
            this.cropMenuItem.Name = "cropMenuItem";
            this.cropMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cropMenuItem.Text = "クロップ設定(&C)";
            this.cropMenuItem.Click += new System.EventHandler(this.OnClickCustomizeCrop);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 20);
            this.helpMenu.Text = "ヘルプ(&H)";
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Name = "versionMenuItem";
            this.versionMenuItem.Size = new System.Drawing.Size(133, 22);
            this.versionMenuItem.Text = "バージョン(&V)";
            this.versionMenuItem.Click += new System.EventHandler(this.OnClickShowVersionInfo);
            // 
            // imageStage
            // 
            this.imageStage.Controls.Add(this.bottomRightBox);
            this.imageStage.Controls.Add(this.bottomLeftBox);
            this.imageStage.Controls.Add(this.topRightBox);
            this.imageStage.Controls.Add(this.topLeftBox);
            this.imageStage.Location = new System.Drawing.Point(12, 27);
            this.imageStage.Name = "imageStage";
            this.imageStage.Size = new System.Drawing.Size(651, 383);
            this.imageStage.TabIndex = 16;
            this.imageStage.TabStop = false;
            this.imageStage.Text = "画像をドラッグアンドドロップ";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(585, 442);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "実行";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnClickSaveButton);
            // 
            // saveFileNameLabel
            // 
            this.saveFileNameLabel.AutoSize = true;
            this.saveFileNameLabel.Location = new System.Drawing.Point(10, 419);
            this.saveFileNameLabel.Name = "saveFileNameLabel";
            this.saveFileNameLabel.Size = new System.Drawing.Size(75, 12);
            this.saveFileNameLabel.TabIndex = 17;
            this.saveFileNameLabel.Text = "出力ファイル名";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(10, 447);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 12);
            this.resultLabel.TabIndex = 18;
            // 
            // bottomRightBox
            // 
            this.bottomRightBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.bottomRightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRightBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bottomRightBox.Location = new System.Drawing.Point(325, 197);
            this.bottomRightBox.Name = "bottomRightBox";
            this.bottomRightBox.Size = new System.Drawing.Size(320, 180);
            this.bottomRightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomRightBox.TabIndex = 20;
            this.bottomRightBox.TabStop = false;
            this.bottomRightBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDropPictureBox);
            this.bottomRightBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnterPictureBox);
            // 
            // bottomLeftBox
            // 
            this.bottomLeftBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.bottomLeftBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeftBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bottomLeftBox.Location = new System.Drawing.Point(6, 197);
            this.bottomLeftBox.Name = "bottomLeftBox";
            this.bottomLeftBox.Size = new System.Drawing.Size(320, 180);
            this.bottomLeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomLeftBox.TabIndex = 19;
            this.bottomLeftBox.TabStop = false;
            this.bottomLeftBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDropPictureBox);
            this.bottomLeftBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnterPictureBox);
            // 
            // topRightBox
            // 
            this.topRightBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.topRightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRightBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.topRightBox.Location = new System.Drawing.Point(325, 18);
            this.topRightBox.Name = "topRightBox";
            this.topRightBox.Size = new System.Drawing.Size(320, 180);
            this.topRightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topRightBox.TabIndex = 18;
            this.topRightBox.TabStop = false;
            this.topRightBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDropPictureBox);
            this.topRightBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnterPictureBox);
            // 
            // topLeftBox
            // 
            this.topLeftBox.AllowDrop = global::ImageBond.Properties.Settings.Default.allowDrop;
            this.topLeftBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeftBox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::ImageBond.Properties.Settings.Default, "allowDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.topLeftBox.Location = new System.Drawing.Point(6, 18);
            this.topLeftBox.Name = "topLeftBox";
            this.topLeftBox.Size = new System.Drawing.Size(320, 180);
            this.topLeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topLeftBox.TabIndex = 17;
            this.topLeftBox.TabStop = false;
            this.topLeftBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDropPictureBox);
            this.topLeftBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnterPictureBox);
            // 
            // ImageBondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 476);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.saveFileNameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveFileNameBox);
            this.Controls.Add(this.imageStage);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageBondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageBond";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.imageStage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saveFileNameBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem versionMenuItem;
        private System.Windows.Forms.PictureBox topLeftBox;
        private System.Windows.Forms.GroupBox imageStage;
        private System.Windows.Forms.PictureBox bottomRightBox;
        private System.Windows.Forms.PictureBox bottomLeftBox;
        private System.Windows.Forms.PictureBox topRightBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem resolutionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropMenuItem;
        private System.Windows.Forms.Label saveFileNameLabel;
        private System.Windows.Forms.ToolStripMenuItem setSaveDirectoryMenuItem;
        private System.Windows.Forms.Label resultLabel;
    }
}

