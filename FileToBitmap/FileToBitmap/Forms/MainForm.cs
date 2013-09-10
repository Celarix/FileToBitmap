using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileToBitmap.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonPaletteSelector_Click(object sender, EventArgs e)
        {
            Colors.Palette palette = new Colors.Palette(BitDepth.FourBpp);
            new PaletteEditorForm(Colors.Palette.OneBppDefaultPalette).ShowDialog();
        }
    }
}
