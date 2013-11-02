using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileToBitmap.Colors;

namespace FileToBitmap.Forms
{
    public partial class PaletteEditorForm : Form
    {
        private List<Panel> panels = new List<Panel>();
        public Palette ActivePalette { get; set; }
        private Palette originalPalette;
        private Panel selectedPanel = null;

        public PaletteEditorForm(Palette palette)
        {
            InitializeComponent();
            this.ActivePalette = palette;
            this.originalPalette = palette.Clone();
            this.CreatePanels(this.ActivePalette);
            this.LayoutPanels(this.panels);
        }

        private void CreatePanels(Palette palette)
        {
            foreach (Color color in palette.Colors)
            {
                Panel panel = new Panel();
                panel.BackColor = color;
                panel.Size = new Size(20, 20);
                this.panels.Add(panel);
            }
        }

        private void LayoutPanels(List<Panel> panels)
        {
            int horizontalOffset = 15, verticalOffset = 20;
            int currentRow = 0, currentColumn = 0;

            foreach (Panel panel in panels)
            {
                panel.Location = new Point((currentColumn * 22) + horizontalOffset, (currentRow * 22) + verticalOffset);
                panel.Click += new EventHandler(PanelClicked);
                this.GroupColorPanels.Controls.Add(panel);

                if (currentColumn == 15)
                {
                    currentRow++;
                    currentColumn = 0;
                }
                else
                {
                    currentColumn++;
                }
            }
        }

        private void PanelClicked(object sender, EventArgs e)
        {
            if (this.selectedPanel != null)
            {
                this.selectedPanel.BorderStyle = BorderStyle.None;
            }

            this.selectedPanel = (Panel)sender;
            this.selectedPanel.BorderStyle = BorderStyle.Fixed3D;

            // Now, update the color controls.
            int colorIndex = this.panels.IndexOf(this.selectedPanel);
            int red = this.selectedPanel.BackColor.R;
            int green = this.selectedPanel.BackColor.G;
            int blue = this.selectedPanel.BackColor.B;
            string rgbHexString = string.Format("{0}{1}{2}", red.ToString("X2"), green.ToString("X2"), blue.ToString("X2"));

            this.LabelColorIndex.Text = string.Format("Color #{0}", colorIndex);
            this.NumericRed.Value = red;
            this.NumericGreen.Value = green;
            this.NumericBlue.Value = blue;
            this.TextHex.Text = rgbHexString;
            this.LabelInvalidHex.Visible = false;
        }

        private void NumericRed_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)NumericRed.Value;

            if (!String.IsNullOrEmpty(this.TextHex.Text))
            {
                StringBuilder hexBuilder = new StringBuilder(this.TextHex.Text);
                string redHex = value.ToString("X2");
                hexBuilder[0] = redHex[0];
                hexBuilder[1] = redHex[1];
                this.TextHex.Text = hexBuilder.ToString();
            }
        }

        private void NumericGreen_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)NumericGreen.Value;

            if (!String.IsNullOrEmpty(this.TextHex.Text))
            {
                StringBuilder hexBulilder = new StringBuilder(this.TextHex.Text);
                string greenHex = value.ToString("X2");
                hexBulilder[2] = greenHex[0];
                hexBulilder[3] = greenHex[1];
                this.TextHex.Text = hexBulilder.ToString();
            }
        }

        private void NumericBlue_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)NumericBlue.Value;

            if (!String.IsNullOrEmpty(this.TextHex.Text))
            {
                StringBuilder hexBulilder = new StringBuilder(this.TextHex.Text);
                string blueHex = value.ToString("X2");
                hexBulilder[4] = blueHex[0];
                hexBulilder[5] = blueHex[1];
                this.TextHex.Text = hexBulilder.ToString();
            }
        }

        private void TextHex_TextChanged(object sender, EventArgs e)
        {
            if (this.selectedPanel != null)
            {
                // First, verify the input.
                string input = this.TextHex.Text.ToUpper();
                if (input.Length != 6 || !this.ContainsOnlyHexDigits(input))
                {
                    this.LabelInvalidHex.Visible = true;
                    return;
                }
                else
                {
                    this.LabelInvalidHex.Visible = false;
                }

                string redHex = input.Substring(0, 2);
                string greenHex = input.Substring(2, 2);
                string blueHex = input.Substring(4, 2);

                int red = Int32.Parse(redHex, System.Globalization.NumberStyles.HexNumber);
                int green = Int32.Parse(greenHex, System.Globalization.NumberStyles.HexNumber);
                int blue = Int32.Parse(blueHex, System.Globalization.NumberStyles.HexNumber);

                this.NumericRed.Value = red;
                this.NumericGreen.Value = green;
                this.NumericBlue.Value = blue;
            }
        }

        private bool ContainsOnlyHexDigits(string input)
        {
            foreach (char c in input)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                {
                    return false;
                }
            }
            return true;
        }

        private void ButtonSetColor_Click(object sender, EventArgs e)
        {
            if (this.selectedPanel != null)
            {
                int red = (int)this.NumericRed.Value;
                int green = (int)this.NumericGreen.Value;
                int blue = (int)this.NumericGreen.Value;
                Color color = Color.FromArgb(red, green, blue);
                this.selectedPanel.BackColor = color;

                // Modify the color in the palette.
                int paletteIndex = this.panels.IndexOf(this.selectedPanel);
                this.ActivePalette.SetColor(paletteIndex, color);
            }
        }

        private void ButtonAdvanced_Click(object sender, EventArgs e)
        {
            if (this.selectedPanel != null)
            {
                this.ColorSelectorDialog.Color = this.selectedPanel.BackColor;
                if (this.ColorSelectorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = this.ColorSelectorDialog.Color;
                    this.selectedPanel.BackColor = selectedColor;
                    this.NumericRed.Value = selectedColor.R;
                    this.NumericGreen.Value = selectedColor.G;
                    this.NumericBlue.Value = selectedColor.B;

                    int paletteIndex = this.panels.IndexOf(this.selectedPanel);
                    this.ActivePalette.SetColor(paletteIndex, selectedColor);
                }
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.ActivePalette = this.originalPalette;
            this.Close();
        }
    }
}
