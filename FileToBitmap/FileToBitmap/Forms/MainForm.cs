using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileToBitmap.Colors;
using FileToBitmap.Drawing;

namespace FileToBitmap.Forms
{
    public partial class MainForm : Form
    {
        private Palette palette;
        private BitDepth currentBitDepth = BitDepth.EightBpp;
        private string loadedFilePath;
        private Bitmap bitmap;
        private Drawer drawer;

        public MainForm()
        {
            InitializeComponent();
            Palette paletteInit = new Palette(BitDepth.OneBpp);
            this.Radio24Bpp.Checked = true;
        }

        private void ButtonPaletteSelector_Click(object sender, EventArgs e)
        {
            PaletteEditorForm editorForm = new PaletteEditorForm(this.palette ?? new Palette(this.currentBitDepth));
            if (editorForm.ShowDialog() == DialogResult.OK)
            {
                this.palette = editorForm.ActivePalette;
            }
        }

        private void Radio1Bpp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Radio1Bpp.Checked)
            {
                this.RadioColor.Enabled = false;
                this.RadioGrayscale.Enabled = true;
                this.RadioCustom.Enabled = true;

                this.RadioGrayscale.Checked = true;
                this.palette = Palette.OneBppDefaultPalette;

                this.drawer = new OneBppDrawer();
            }
        }

        private void Radio2Bpp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Radio2Bpp.Checked)
            {
                this.RadioColor.Enabled = false;
                this.RadioGrayscale.Enabled = true;
                this.RadioCustom.Enabled = true;
                
                this.RadioGrayscale.Checked = true;
                this.palette = Palette.TwoBppGrayscalePalette;

                this.drawer = new TwoBppDrawer();
            }
        }

        private void Radio4Bpp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Radio4Bpp.Checked)
            {
                this.RadioColor.Enabled = true;
                this.RadioGrayscale.Enabled = true;
                this.RadioCustom.Enabled = true;

                if (this.RadioColor.Checked)
                {
                    this.palette = Palette.FourBppWindowsPalette;
                }
                else if (this.RadioGrayscale.Checked)
                {
                    this.palette = Palette.FourBppGrayscalePalette;
                }
                else
                {
                    this.RadioGrayscale.Checked = true;
                    this.palette = Palette.FourBppGrayscalePalette;
                }

                this.drawer = new FourBppDrawer();
            }
        }

        private void Radio8Bpp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Radio8Bpp.Checked)
            {
                this.RadioColor.Enabled = true;
                this.RadioGrayscale.Enabled = true;
                this.RadioCustom.Enabled = true;

                if (this.RadioColor.Checked)
                {
                    this.palette = Palette.EightBppColorPalette;
                }
                else if (this.RadioCustom.Checked)
                {
                    this.palette = Palette.EightBppGrayscalePalette;
                }
                else
                {
                    this.RadioGrayscale.Checked = true;
                    this.palette = Palette.EightBppGrayscalePalette;
                }

                this.drawer = new EightBppDrawer();
            }
        }

        private void Radio16Bpp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Radio16Bpp.Checked)
            {
                this.RadioColor.Enabled = true;
                this.RadioGrayscale.Enabled = false;
                this.RadioCustom.Enabled = false;

                this.palette = null;
                this.drawer = new SixteenBppDrawer();
            }
        }

        private void Radio24Bpp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Radio24Bpp.Checked)
            {
                this.RadioColor.Enabled = true;
                this.RadioGrayscale.Enabled = false;
                this.RadioCustom.Enabled = false;

                this.palette = null;
                this.drawer = new TwentyFourBppDrawer();
            }
        }

        private void Radio32Bpp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Radio32Bpp.Checked)
            {
                this.RadioColor.Enabled = true;
                this.RadioGrayscale.Enabled = false;
                this.RadioColor.Enabled = false;

                this.palette = null;
                this.drawer = new ThirtyTwoBppDrawer();
            }
        }

        private void RadioColor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioColor.Checked)
            {
                if (this.Radio4Bpp.Checked)
                {
                    this.palette = Palette.FourBppWindowsPalette;
                }
                else if (this.Radio8Bpp.Checked)
                {
                    this.palette = Palette.EightBppColorPalette;
                }
            }
        }

        private void RadioGrayscale_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioGrayscale.Checked)
            {
                if (this.Radio1Bpp.Checked)
                {
                    this.palette = Palette.OneBppDefaultPalette;
                }
                else if (this.Radio2Bpp.Checked)
                {
                    this.palette = Palette.TwoBppGrayscalePalette;
                }
                else if (this.Radio4Bpp.Checked)
                {
                    this.palette = Palette.FourBppGrayscalePalette;
                }
                else if (this.Radio8Bpp.Checked)
                {
                    this.palette = Palette.EightBppGrayscalePalette;
                }
            }
        }

        private void RadioCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioCustom.Checked)
            {
                this.ButtonPaletteSelector.Enabled = true;
            }
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                this.loadedFilePath = OpenFile.FileName;
                this.DrawImage();
            }
        }

        private void DrawImage()
        {
            this.ButtonCancel.Enabled = true;
            this.WorkerDrawer.RunWorkerAsync();
        }

        private void WorkerDrawer_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.drawer != null)
            {
                this.PictureViewer.Image = this.drawer.Draw(this.loadedFilePath, this.palette, this.WorkerDrawer);
                this.ButtonCancel.Enabled = false;
            }
        }

        private void WorkerDrawer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.ProgressDraw.Value = e.ProgressPercentage;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.WorkerDrawer.CancelAsync();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            this.DrawImage();
        }

        private void WorkerDrawer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string fileSizeLength = new System.IO.FileInfo(this.loadedFilePath).Length.GetFileSizeString();
            string dimensions = string.Format("{0}x{1}", this.PictureViewer.Image.Width, this.PictureViewer.Image.Height);
            this.Text = string.Format("File to Bitmap - {0} ({1}, {2})", this.loadedFilePath, fileSizeLength, dimensions);
            this.bitmap = (Bitmap)this.PictureViewer.Image;
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            if (this.bitmap != null && this.SaveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.SaveFile.FileName;
                string extension = fileName.Substring(fileName.LastIndexOf('.') + 1, (fileName.Length - 1) - fileName.LastIndexOf('.')).ToLower();
                switch (extension)
                {
                    case "png":
                        this.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "jpg":
                    case "jpeg":
                        this.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        this.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    default:
                        MessageBox.Show(extension);
                        break;
                }
            }
        }
    }
}
