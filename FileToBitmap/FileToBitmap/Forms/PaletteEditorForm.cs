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
        private int selectedPanelIndex;

        public PaletteEditorForm(Palette palette)
        {
            InitializeComponent();
            this.activePalette = palette;

            switch (this.activePalette.BitDepth)
            {
                case BitDepth.OneBpp:
                    break;
                case BitDepth.TwoBpp:
                    break;
                case BitDepth.FourBpp:
                    break;
                case BitDepth.EightBpp:
                    break;
                default:
                    break;
            }
        }
    }
}
