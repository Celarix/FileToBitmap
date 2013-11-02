namespace FileToBitmap.Forms
{
    partial class PaletteEditorForm
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
            this.GroupColorPanels = new System.Windows.Forms.GroupBox();
            this.LabelColorIndex = new System.Windows.Forms.Label();
            this.LabelStaticRed = new System.Windows.Forms.Label();
            this.LabelStaticGreen = new System.Windows.Forms.Label();
            this.LabelStaticBlue = new System.Windows.Forms.Label();
            this.LabelStaticHex = new System.Windows.Forms.Label();
            this.TextHex = new System.Windows.Forms.TextBox();
            this.ButtonAdvanced = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSetColor = new System.Windows.Forms.Button();
            this.ColorSelectorDialog = new System.Windows.Forms.ColorDialog();
            this.NumericRed = new System.Windows.Forms.NumericUpDown();
            this.NumericGreen = new System.Windows.Forms.NumericUpDown();
            this.NumericBlue = new System.Windows.Forms.NumericUpDown();
            this.LabelInvalidHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupColorPanels
            // 
            this.GroupColorPanels.Location = new System.Drawing.Point(13, 13);
            this.GroupColorPanels.Name = "GroupColorPanels";
            this.GroupColorPanels.Size = new System.Drawing.Size(407, 380);
            this.GroupColorPanels.TabIndex = 0;
            this.GroupColorPanels.TabStop = false;
            this.GroupColorPanels.Text = "Colors";
            // 
            // LabelColorIndex
            // 
            this.LabelColorIndex.AutoSize = true;
            this.LabelColorIndex.Location = new System.Drawing.Point(423, 34);
            this.LabelColorIndex.Name = "LabelColorIndex";
            this.LabelColorIndex.Size = new System.Drawing.Size(51, 13);
            this.LabelColorIndex.TabIndex = 1;
            this.LabelColorIndex.Text = "Color #0";
            // 
            // LabelStaticRed
            // 
            this.LabelStaticRed.AutoSize = true;
            this.LabelStaticRed.Location = new System.Drawing.Point(435, 55);
            this.LabelStaticRed.Name = "LabelStaticRed";
            this.LabelStaticRed.Size = new System.Drawing.Size(17, 13);
            this.LabelStaticRed.TabIndex = 2;
            this.LabelStaticRed.Text = "R:";
            // 
            // LabelStaticGreen
            // 
            this.LabelStaticGreen.AutoSize = true;
            this.LabelStaticGreen.Location = new System.Drawing.Point(505, 55);
            this.LabelStaticGreen.Name = "LabelStaticGreen";
            this.LabelStaticGreen.Size = new System.Drawing.Size(18, 13);
            this.LabelStaticGreen.TabIndex = 4;
            this.LabelStaticGreen.Text = "G:";
            // 
            // LabelStaticBlue
            // 
            this.LabelStaticBlue.AutoSize = true;
            this.LabelStaticBlue.Location = new System.Drawing.Point(580, 55);
            this.LabelStaticBlue.Name = "LabelStaticBlue";
            this.LabelStaticBlue.Size = new System.Drawing.Size(17, 13);
            this.LabelStaticBlue.TabIndex = 6;
            this.LabelStaticBlue.Text = "B:";
            // 
            // LabelStaticHex
            // 
            this.LabelStaticHex.AutoSize = true;
            this.LabelStaticHex.Location = new System.Drawing.Point(423, 83);
            this.LabelStaticHex.Name = "LabelStaticHex";
            this.LabelStaticHex.Size = new System.Drawing.Size(29, 13);
            this.LabelStaticHex.TabIndex = 8;
            this.LabelStaticHex.Text = "Hex:";
            // 
            // TextHex
            // 
            this.TextHex.Location = new System.Drawing.Point(458, 80);
            this.TextHex.Name = "TextHex";
            this.TextHex.Size = new System.Drawing.Size(186, 22);
            this.TextHex.TabIndex = 9;
            this.TextHex.TextChanged += new System.EventHandler(this.TextHex_TextChanged);
            // 
            // ButtonAdvanced
            // 
            this.ButtonAdvanced.Location = new System.Drawing.Point(426, 137);
            this.ButtonAdvanced.Name = "ButtonAdvanced";
            this.ButtonAdvanced.Size = new System.Drawing.Size(218, 23);
            this.ButtonAdvanced.TabIndex = 10;
            this.ButtonAdvanced.Text = "&Advanced...";
            this.ButtonAdvanced.UseVisualStyleBackColor = true;
            this.ButtonAdvanced.Click += new System.EventHandler(this.ButtonAdvanced_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(426, 341);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(218, 23);
            this.ButtonOK.TabIndex = 11;
            this.ButtonOK.Text = "&OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(426, 370);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(218, 23);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSetColor
            // 
            this.ButtonSetColor.Location = new System.Drawing.Point(426, 108);
            this.ButtonSetColor.Name = "ButtonSetColor";
            this.ButtonSetColor.Size = new System.Drawing.Size(218, 23);
            this.ButtonSetColor.TabIndex = 13;
            this.ButtonSetColor.Text = "&Set Color";
            this.ButtonSetColor.UseVisualStyleBackColor = true;
            this.ButtonSetColor.Click += new System.EventHandler(this.ButtonSetColor_Click);
            // 
            // ColorSelectorDialog
            // 
            this.ColorSelectorDialog.FullOpen = true;
            // 
            // NumericRed
            // 
            this.NumericRed.Location = new System.Drawing.Point(458, 52);
            this.NumericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericRed.Name = "NumericRed";
            this.NumericRed.Size = new System.Drawing.Size(41, 22);
            this.NumericRed.TabIndex = 14;
            this.NumericRed.ValueChanged += new System.EventHandler(this.NumericRed_ValueChanged);
            // 
            // NumericGreen
            // 
            this.NumericGreen.Location = new System.Drawing.Point(529, 52);
            this.NumericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGreen.Name = "NumericGreen";
            this.NumericGreen.Size = new System.Drawing.Size(41, 22);
            this.NumericGreen.TabIndex = 15;
            this.NumericGreen.ValueChanged += new System.EventHandler(this.NumericGreen_ValueChanged);
            // 
            // NumericBlue
            // 
            this.NumericBlue.Location = new System.Drawing.Point(603, 52);
            this.NumericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericBlue.Name = "NumericBlue";
            this.NumericBlue.Size = new System.Drawing.Size(41, 22);
            this.NumericBlue.TabIndex = 16;
            this.NumericBlue.ValueChanged += new System.EventHandler(this.NumericBlue_ValueChanged);
            // 
            // LabelInvalidHex
            // 
            this.LabelInvalidHex.AutoSize = true;
            this.LabelInvalidHex.ForeColor = System.Drawing.Color.Red;
            this.LabelInvalidHex.Location = new System.Drawing.Point(426, 167);
            this.LabelInvalidHex.Name = "LabelInvalidHex";
            this.LabelInvalidHex.Size = new System.Drawing.Size(202, 13);
            this.LabelInvalidHex.TabIndex = 17;
            this.LabelInvalidHex.Text = "That isn\'t a valid hexadecimal number.";
            this.LabelInvalidHex.Visible = false;
            // 
            // PaletteEditorForm
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(649, 406);
            this.Controls.Add(this.LabelInvalidHex);
            this.Controls.Add(this.NumericBlue);
            this.Controls.Add(this.NumericGreen);
            this.Controls.Add(this.NumericRed);
            this.Controls.Add(this.ButtonSetColor);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonAdvanced);
            this.Controls.Add(this.TextHex);
            this.Controls.Add(this.LabelStaticHex);
            this.Controls.Add(this.LabelStaticBlue);
            this.Controls.Add(this.LabelStaticGreen);
            this.Controls.Add(this.LabelStaticRed);
            this.Controls.Add(this.LabelColorIndex);
            this.Controls.Add(this.GroupColorPanels);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaletteEditorForm";
            this.Text = "Palette Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupColorPanels;
        private System.Windows.Forms.Label LabelColorIndex;
        private System.Windows.Forms.Label LabelStaticRed;
        private System.Windows.Forms.Label LabelStaticGreen;
        private System.Windows.Forms.Label LabelStaticBlue;
        private System.Windows.Forms.Label LabelStaticHex;
        private System.Windows.Forms.TextBox TextHex;
        private System.Windows.Forms.Button ButtonAdvanced;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSetColor;
        private System.Windows.Forms.ColorDialog ColorSelectorDialog;
        private System.Windows.Forms.NumericUpDown NumericRed;
        private System.Windows.Forms.NumericUpDown NumericGreen;
        private System.Windows.Forms.NumericUpDown NumericBlue;
        private System.Windows.Forms.Label LabelInvalidHex;


    }
}