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
        private Palette activePalette;
        private Panel selectedPanel = null;

        public PaletteEditorForm(Palette palette)
        {
            InitializeComponent();
            this.activePalette = palette;
            this.CreatePanels(this.activePalette);
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
        }
    }
}
