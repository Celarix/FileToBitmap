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
            this.TextRed = new System.Windows.Forms.TextBox();
            this.TextGreen = new System.Windows.Forms.TextBox();
            this.LabelStaticGreen = new System.Windows.Forms.Label();
            this.LabelStaticBlue = new System.Windows.Forms.Label();
            this.TextBlue = new System.Windows.Forms.TextBox();
            this.LabelStaticHex = new System.Windows.Forms.Label();
            this.TextHex = new System.Windows.Forms.TextBox();
            this.ButtonAdvanced = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSetColor = new System.Windows.Forms.Button();
            this.ColorSelectorDialog = new System.Windows.Forms.ColorDialog();
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
            // TextRed
            // 
            this.TextRed.Location = new System.Drawing.Point(458, 52);
            this.TextRed.Name = "TextRed";
            this.TextRed.Size = new System.Drawing.Size(28, 22);
            this.TextRed.TabIndex = 3;
            // 
            // TextGreen
            // 
            this.TextGreen.Location = new System.Drawing.Point(512, 52);
            this.TextGreen.Name = "TextGreen";
            this.TextGreen.Size = new System.Drawing.Size(28, 22);
            this.TextGreen.TabIndex = 5;
            // 
            // LabelStaticGreen
            // 
            this.LabelStaticGreen.AutoSize = true;
            this.LabelStaticGreen.Location = new System.Drawing.Point(492, 55);
            this.LabelStaticGreen.Name = "LabelStaticGreen";
            this.LabelStaticGreen.Size = new System.Drawing.Size(18, 13);
            this.LabelStaticGreen.TabIndex = 4;
            this.LabelStaticGreen.Text = "G:";
            // 
            // LabelStaticBlue
            // 
            this.LabelStaticBlue.AutoSize = true;
            this.LabelStaticBlue.Location = new System.Drawing.Point(546, 55);
            this.LabelStaticBlue.Name = "LabelStaticBlue";
            this.LabelStaticBlue.Size = new System.Drawing.Size(17, 13);
            this.LabelStaticBlue.TabIndex = 6;
            this.LabelStaticBlue.Text = "B:";
            // 
            // TextBlue
            // 
            this.TextBlue.Location = new System.Drawing.Point(569, 52);
            this.TextBlue.Name = "TextBlue";
            this.TextBlue.Size = new System.Drawing.Size(28, 22);
            this.TextBlue.TabIndex = 7;
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
            this.TextHex.Size = new System.Drawing.Size(139, 22);
            this.TextHex.TabIndex = 9;
            // 
            // ButtonAdvanced
            // 
            this.ButtonAdvanced.Location = new System.Drawing.Point(426, 137);
            this.ButtonAdvanced.Name = "ButtonAdvanced";
            this.ButtonAdvanced.Size = new System.Drawing.Size(171, 23);
            this.ButtonAdvanced.TabIndex = 10;
            this.ButtonAdvanced.Text = "&Advanced...";
            this.ButtonAdvanced.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(426, 341);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(171, 23);
            this.ButtonOK.TabIndex = 11;
            this.ButtonOK.Text = "&OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(426, 370);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(171, 23);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonSetColor
            // 
            this.ButtonSetColor.Location = new System.Drawing.Point(426, 108);
            this.ButtonSetColor.Name = "ButtonSetColor";
            this.ButtonSetColor.Size = new System.Drawing.Size(171, 23);
            this.ButtonSetColor.TabIndex = 13;
            this.ButtonSetColor.Text = "&Set Color";
            this.ButtonSetColor.UseVisualStyleBackColor = true;
            // 
            // ColorSelectorDialog
            // 
            this.ColorSelectorDialog.FullOpen = true;
            // 
            // PaletteEditorForm
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(609, 406);
            this.Controls.Add(this.ButtonSetColor);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonAdvanced);
            this.Controls.Add(this.TextHex);
            this.Controls.Add(this.LabelStaticHex);
            this.Controls.Add(this.TextBlue);
            this.Controls.Add(this.LabelStaticBlue);
            this.Controls.Add(this.TextGreen);
            this.Controls.Add(this.LabelStaticGreen);
            this.Controls.Add(this.TextRed);
            this.Controls.Add(this.LabelStaticRed);
            this.Controls.Add(this.LabelColorIndex);
            this.Controls.Add(this.GroupColorPanels);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaletteEditorForm";
            this.Text = "Palette Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupColorPanels;
        private System.Windows.Forms.Label LabelColorIndex;
        private System.Windows.Forms.Label LabelStaticRed;
        private System.Windows.Forms.TextBox TextRed;
        private System.Windows.Forms.TextBox TextGreen;
        private System.Windows.Forms.Label LabelStaticGreen;
        private System.Windows.Forms.Label LabelStaticBlue;
        private System.Windows.Forms.TextBox TextBlue;
        private System.Windows.Forms.Label LabelStaticHex;
        private System.Windows.Forms.TextBox TextHex;
        private System.Windows.Forms.Button ButtonAdvanced;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSetColor;
        private System.Windows.Forms.ColorDialog ColorSelectorDialog;


    }
}