namespace FileToBitmap.Forms
{
    partial class MainForm
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
            this.PictureViewer = new System.Windows.Forms.PictureBox();
            this.GroupFile = new System.Windows.Forms.GroupBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonSaveFile = new System.Windows.Forms.Button();
            this.ButtonOpenFile = new System.Windows.Forms.Button();
            this.GroupBitDepth = new System.Windows.Forms.GroupBox();
            this.Radio32Bpp = new System.Windows.Forms.RadioButton();
            this.Radio24Bpp = new System.Windows.Forms.RadioButton();
            this.Radio16Bpp = new System.Windows.Forms.RadioButton();
            this.Radio8Bpp = new System.Windows.Forms.RadioButton();
            this.Radio4Bpp = new System.Windows.Forms.RadioButton();
            this.Radio2Bpp = new System.Windows.Forms.RadioButton();
            this.Radio1Bpp = new System.Windows.Forms.RadioButton();
            this.GroupPalette = new System.Windows.Forms.GroupBox();
            this.ButtonPaletteSelector = new System.Windows.Forms.Button();
            this.RadioCustom = new System.Windows.Forms.RadioButton();
            this.RadioGrayscale = new System.Windows.Forms.RadioButton();
            this.RadioColor = new System.Windows.Forms.RadioButton();
            this.WorkerDrawer = new System.ComponentModel.BackgroundWorker();
            this.ProgressDraw = new System.Windows.Forms.ProgressBar();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureViewer)).BeginInit();
            this.GroupFile.SuspendLayout();
            this.GroupBitDepth.SuspendLayout();
            this.GroupPalette.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureViewer
            // 
            this.PictureViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureViewer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureViewer.Location = new System.Drawing.Point(13, 13);
            this.PictureViewer.Name = "PictureViewer";
            this.PictureViewer.Size = new System.Drawing.Size(527, 431);
            this.PictureViewer.TabIndex = 0;
            this.PictureViewer.TabStop = false;
            // 
            // GroupFile
            // 
            this.GroupFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupFile.Controls.Add(this.ButtonCancel);
            this.GroupFile.Controls.Add(this.ButtonRefresh);
            this.GroupFile.Controls.Add(this.ButtonSaveFile);
            this.GroupFile.Controls.Add(this.ButtonOpenFile);
            this.GroupFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupFile.Location = new System.Drawing.Point(547, 13);
            this.GroupFile.Name = "GroupFile";
            this.GroupFile.Size = new System.Drawing.Size(135, 135);
            this.GroupFile.TabIndex = 1;
            this.GroupFile.TabStop = false;
            this.GroupFile.Text = "File";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Enabled = false;
            this.ButtonCancel.Location = new System.Drawing.Point(7, 110);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(122, 23);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "C&ancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(7, 80);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(122, 23);
            this.ButtonRefresh.TabIndex = 2;
            this.ButtonRefresh.Text = "&Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveFile.Location = new System.Drawing.Point(7, 50);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(122, 23);
            this.ButtonSaveFile.TabIndex = 1;
            this.ButtonSaveFile.Text = "&Save...";
            this.ButtonSaveFile.UseVisualStyleBackColor = true;
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenFile.Location = new System.Drawing.Point(7, 20);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(122, 23);
            this.ButtonOpenFile.TabIndex = 0;
            this.ButtonOpenFile.Text = "&Open...";
            this.ButtonOpenFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // GroupBitDepth
            // 
            this.GroupBitDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBitDepth.Controls.Add(this.Radio32Bpp);
            this.GroupBitDepth.Controls.Add(this.Radio24Bpp);
            this.GroupBitDepth.Controls.Add(this.Radio16Bpp);
            this.GroupBitDepth.Controls.Add(this.Radio8Bpp);
            this.GroupBitDepth.Controls.Add(this.Radio4Bpp);
            this.GroupBitDepth.Controls.Add(this.Radio2Bpp);
            this.GroupBitDepth.Controls.Add(this.Radio1Bpp);
            this.GroupBitDepth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBitDepth.Location = new System.Drawing.Point(547, 154);
            this.GroupBitDepth.Name = "GroupBitDepth";
            this.GroupBitDepth.Size = new System.Drawing.Size(135, 191);
            this.GroupBitDepth.TabIndex = 2;
            this.GroupBitDepth.TabStop = false;
            this.GroupBitDepth.Text = "Bit Depth";
            // 
            // Radio32Bpp
            // 
            this.Radio32Bpp.AutoSize = true;
            this.Radio32Bpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio32Bpp.Location = new System.Drawing.Point(7, 164);
            this.Radio32Bpp.Name = "Radio32Bpp";
            this.Radio32Bpp.Size = new System.Drawing.Size(129, 17);
            this.Radio32Bpp.TabIndex = 6;
            this.Radio32Bpp.TabStop = true;
            this.Radio32Bpp.Text = "32 bits (4.2b shades)";
            this.Radio32Bpp.UseVisualStyleBackColor = true;
            this.Radio32Bpp.CheckedChanged += new System.EventHandler(this.Radio32Bpp_CheckedChanged);
            // 
            // Radio24Bpp
            // 
            this.Radio24Bpp.AutoSize = true;
            this.Radio24Bpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio24Bpp.Location = new System.Drawing.Point(7, 140);
            this.Radio24Bpp.Name = "Radio24Bpp";
            this.Radio24Bpp.Size = new System.Drawing.Size(132, 17);
            this.Radio24Bpp.TabIndex = 5;
            this.Radio24Bpp.TabStop = true;
            this.Radio24Bpp.Text = "24 bits (16.7m colors)";
            this.Radio24Bpp.UseVisualStyleBackColor = true;
            this.Radio24Bpp.CheckedChanged += new System.EventHandler(this.Radio24Bpp_CheckedChanged);
            // 
            // Radio16Bpp
            // 
            this.Radio16Bpp.AutoSize = true;
            this.Radio16Bpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio16Bpp.Location = new System.Drawing.Point(7, 116);
            this.Radio16Bpp.Name = "Radio16Bpp";
            this.Radio16Bpp.Size = new System.Drawing.Size(120, 17);
            this.Radio16Bpp.TabIndex = 4;
            this.Radio16Bpp.TabStop = true;
            this.Radio16Bpp.Text = "16 bits (64k colors)";
            this.Radio16Bpp.UseVisualStyleBackColor = true;
            this.Radio16Bpp.CheckedChanged += new System.EventHandler(this.Radio16Bpp_CheckedChanged);
            // 
            // Radio8Bpp
            // 
            this.Radio8Bpp.AutoSize = true;
            this.Radio8Bpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio8Bpp.Location = new System.Drawing.Point(7, 92);
            this.Radio8Bpp.Name = "Radio8Bpp";
            this.Radio8Bpp.Size = new System.Drawing.Size(114, 17);
            this.Radio8Bpp.TabIndex = 3;
            this.Radio8Bpp.TabStop = true;
            this.Radio8Bpp.Text = "8 bits (256 colors)";
            this.Radio8Bpp.UseVisualStyleBackColor = true;
            this.Radio8Bpp.CheckedChanged += new System.EventHandler(this.Radio8Bpp_CheckedChanged);
            // 
            // Radio4Bpp
            // 
            this.Radio4Bpp.AutoSize = true;
            this.Radio4Bpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio4Bpp.Location = new System.Drawing.Point(7, 68);
            this.Radio4Bpp.Name = "Radio4Bpp";
            this.Radio4Bpp.Size = new System.Drawing.Size(108, 17);
            this.Radio4Bpp.TabIndex = 2;
            this.Radio4Bpp.TabStop = true;
            this.Radio4Bpp.Text = "4 bits (16 colors)";
            this.Radio4Bpp.UseVisualStyleBackColor = true;
            this.Radio4Bpp.CheckedChanged += new System.EventHandler(this.Radio4Bpp_CheckedChanged);
            // 
            // Radio2Bpp
            // 
            this.Radio2Bpp.AutoSize = true;
            this.Radio2Bpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio2Bpp.Location = new System.Drawing.Point(7, 44);
            this.Radio2Bpp.Name = "Radio2Bpp";
            this.Radio2Bpp.Size = new System.Drawing.Size(102, 17);
            this.Radio2Bpp.TabIndex = 1;
            this.Radio2Bpp.TabStop = true;
            this.Radio2Bpp.Text = "2 bits (4 colors)";
            this.Radio2Bpp.UseVisualStyleBackColor = true;
            this.Radio2Bpp.CheckedChanged += new System.EventHandler(this.Radio2Bpp_CheckedChanged);
            // 
            // Radio1Bpp
            // 
            this.Radio1Bpp.AutoSize = true;
            this.Radio1Bpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio1Bpp.Location = new System.Drawing.Point(7, 20);
            this.Radio1Bpp.Name = "Radio1Bpp";
            this.Radio1Bpp.Size = new System.Drawing.Size(97, 17);
            this.Radio1Bpp.TabIndex = 0;
            this.Radio1Bpp.TabStop = true;
            this.Radio1Bpp.Text = "1 bit (2 colors)";
            this.Radio1Bpp.UseVisualStyleBackColor = true;
            this.Radio1Bpp.CheckedChanged += new System.EventHandler(this.Radio1Bpp_CheckedChanged);
            // 
            // GroupPalette
            // 
            this.GroupPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupPalette.Controls.Add(this.ButtonPaletteSelector);
            this.GroupPalette.Controls.Add(this.RadioCustom);
            this.GroupPalette.Controls.Add(this.RadioGrayscale);
            this.GroupPalette.Controls.Add(this.RadioColor);
            this.GroupPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupPalette.Location = new System.Drawing.Point(547, 351);
            this.GroupPalette.Name = "GroupPalette";
            this.GroupPalette.Size = new System.Drawing.Size(135, 121);
            this.GroupPalette.TabIndex = 3;
            this.GroupPalette.TabStop = false;
            this.GroupPalette.Text = "Palette";
            // 
            // ButtonPaletteSelector
            // 
            this.ButtonPaletteSelector.Enabled = false;
            this.ButtonPaletteSelector.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPaletteSelector.Location = new System.Drawing.Point(7, 90);
            this.ButtonPaletteSelector.Name = "ButtonPaletteSelector";
            this.ButtonPaletteSelector.Size = new System.Drawing.Size(122, 23);
            this.ButtonPaletteSelector.TabIndex = 3;
            this.ButtonPaletteSelector.Text = "&Palette Editor...";
            this.ButtonPaletteSelector.UseVisualStyleBackColor = true;
            this.ButtonPaletteSelector.Click += new System.EventHandler(this.ButtonPaletteSelector_Click);
            // 
            // RadioCustom
            // 
            this.RadioCustom.AutoSize = true;
            this.RadioCustom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCustom.Location = new System.Drawing.Point(6, 67);
            this.RadioCustom.Name = "RadioCustom";
            this.RadioCustom.Size = new System.Drawing.Size(102, 17);
            this.RadioCustom.TabIndex = 2;
            this.RadioCustom.Text = "C&ustom Palette";
            this.RadioCustom.UseVisualStyleBackColor = true;
            this.RadioCustom.CheckedChanged += new System.EventHandler(this.RadioCustom_CheckedChanged);
            // 
            // RadioGrayscale
            // 
            this.RadioGrayscale.AutoSize = true;
            this.RadioGrayscale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioGrayscale.Location = new System.Drawing.Point(7, 44);
            this.RadioGrayscale.Name = "RadioGrayscale";
            this.RadioGrayscale.Size = new System.Drawing.Size(73, 17);
            this.RadioGrayscale.TabIndex = 1;
            this.RadioGrayscale.Text = "&Grayscale";
            this.RadioGrayscale.UseVisualStyleBackColor = true;
            this.RadioGrayscale.CheckedChanged += new System.EventHandler(this.RadioGrayscale_CheckedChanged);
            // 
            // RadioColor
            // 
            this.RadioColor.AutoSize = true;
            this.RadioColor.Checked = true;
            this.RadioColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioColor.Location = new System.Drawing.Point(7, 20);
            this.RadioColor.Name = "RadioColor";
            this.RadioColor.Size = new System.Drawing.Size(53, 17);
            this.RadioColor.TabIndex = 0;
            this.RadioColor.TabStop = true;
            this.RadioColor.Text = "&Color";
            this.RadioColor.UseVisualStyleBackColor = true;
            this.RadioColor.CheckedChanged += new System.EventHandler(this.RadioColor_CheckedChanged);
            // 
            // WorkerDrawer
            // 
            this.WorkerDrawer.WorkerReportsProgress = true;
            this.WorkerDrawer.WorkerSupportsCancellation = true;
            this.WorkerDrawer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerDrawer_DoWork);
            this.WorkerDrawer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WorkerDrawer_ProgressChanged);
            this.WorkerDrawer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerDrawer_RunWorkerCompleted);
            // 
            // ProgressDraw
            // 
            this.ProgressDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressDraw.Location = new System.Drawing.Point(13, 451);
            this.ProgressDraw.Name = "ProgressDraw";
            this.ProgressDraw.Size = new System.Drawing.Size(527, 23);
            this.ProgressDraw.TabIndex = 4;
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "All files|*.*";
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Portable Network Graphics|*.png|Joint Experts Photography Group|*.jpg|Graphics In" +
    "terchange Format|*.gif";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 484);
            this.Controls.Add(this.ProgressDraw);
            this.Controls.Add(this.GroupPalette);
            this.Controls.Add(this.GroupBitDepth);
            this.Controls.Add(this.GroupFile);
            this.Controls.Add(this.PictureViewer);
            this.Name = "MainForm";
            this.Text = "File To Bitmap";
            ((System.ComponentModel.ISupportInitialize)(this.PictureViewer)).EndInit();
            this.GroupFile.ResumeLayout(false);
            this.GroupBitDepth.ResumeLayout(false);
            this.GroupBitDepth.PerformLayout();
            this.GroupPalette.ResumeLayout(false);
            this.GroupPalette.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureViewer;
        private System.Windows.Forms.GroupBox GroupFile;
        private System.Windows.Forms.Button ButtonSaveFile;
        private System.Windows.Forms.Button ButtonOpenFile;
        private System.Windows.Forms.GroupBox GroupBitDepth;
        private System.Windows.Forms.RadioButton Radio32Bpp;
        private System.Windows.Forms.RadioButton Radio24Bpp;
        private System.Windows.Forms.RadioButton Radio16Bpp;
        private System.Windows.Forms.RadioButton Radio8Bpp;
        private System.Windows.Forms.RadioButton Radio4Bpp;
        private System.Windows.Forms.RadioButton Radio2Bpp;
        private System.Windows.Forms.RadioButton Radio1Bpp;
        private System.Windows.Forms.GroupBox GroupPalette;
        private System.Windows.Forms.Button ButtonPaletteSelector;
        private System.Windows.Forms.RadioButton RadioCustom;
        private System.Windows.Forms.RadioButton RadioGrayscale;
        private System.Windows.Forms.RadioButton RadioColor;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.ComponentModel.BackgroundWorker WorkerDrawer;
        private System.Windows.Forms.ProgressBar ProgressDraw;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}

