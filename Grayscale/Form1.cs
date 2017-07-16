using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grayscale
{
    public partial class Form1 : Form
    {
        private Bitmap btmap;
        private string FileName;
        private string FileNameSave;

        public Form1()
        {
            InitializeComponent();

        }
        private void GrayscaleRend(LockBitmap lBtmap)
        {

            int width = lBtmap.Width;
            int height = lBtmap.Height;

            progressBar1.Value = 0;
            progressBar1.Maximum = height;

            Color clr;

            int Rproc = (int)((100.000 / trackR.Maximum) * trackR.Value);
            int Gproc = (int)((100.000 / trackG.Maximum) * trackG.Value);
            int Bproc = (int)((100.000 / trackB.Maximum) * trackB.Value);

            int bright = (int)((100.000 / trackBright.Maximum) * trackBright.Value);

            int Contrast = (int)((100.000 / trackContrast.Maximum) * trackContrast.Value);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    clr = lBtmap.GetPixel(x, y);

                    int R1 = clr.R + Rproc * 128 / 100 <= 0 ? 0 : clr.R + Rproc * 128 / 100 >= 255 ? 255 : clr.R + Rproc * 128 / 100;
                    int G1 = clr.G + Gproc * 128 / 100 <= 0 ? 0 : clr.G + Gproc * 128 / 100 >= 255 ? 255 : clr.G + Gproc * 128 / 100;
                    int B1 = clr.B + Bproc * 128 / 100 <= 0 ? 0 : clr.B + Bproc * 128 / 100 >= 255 ? 255 : clr.B + Bproc * 128 / 100;

                    int R2 = R1 + bright * 128 / 100 <= 0 ? 0 : R1 + bright * 128 / 100 >= 255 ? 255 : R1 + bright * 128 / 100;
                    int G2 = G1 + bright * 128 / 100 <= 0 ? 0 : G1 + bright * 128 / 100 >= 255 ? 255 : G1 + bright * 128 / 100;
                    int B2 = B1 + bright * 128 / 100 <= 0 ? 0 : B1 + bright * 128 / 100 >= 255 ? 255 : B1 + bright * 128 / 100;

                    int R3 = Contrast < 0 ? (R2 * (100 - Contrast) + 128 * Contrast) / 100 : (R2 * 100 - 128 * Contrast) / (101 - Contrast);
                    int R4 = R3 < 0 ? R4 = 0 : R3 > 255 ? R4 = 255 : R3;
                    int G3 = Contrast < 0 ? (G2 * (100 - Contrast) + 128 * Contrast) / 100 : (G2 * 100 - 128 * Contrast) / (101 - Contrast);
                    int G4 = G3 < 0 ? G4 = 0 : G3 > 255 ? G4 = 255 : G3;
                    int B3 = Contrast < 0 ? (B2 * (100 - Contrast) + 128 * Contrast) / 100 : (B2 * 100 - 128 * Contrast) / (101 - Contrast);
                    int B4 = B3 < 0 ? B4 = 0 : B3 > 255 ? B4 = 255 : B3;

                    int A = clr.A;
                    int R = R4;
                    int G = G4;
                    int B = B4;

                    if (checkGrayscale.Checked == true)
                    {
                        int avr = (R + G + B) / 3;
                        lBtmap.SetPixel(x, y, Color.FromArgb(A, avr, avr, avr));
                    }
                    else
                    {
                        lBtmap.SetPixel(x, y, Color.FromArgb(A, R, G, B));
                    }
                }
                progressBar1.Value++;
            }
        }

        private void PreRender()
        {
            if (FileName == null)
                return;
            if (checkBenchmark.Checked == true)
                Benchmark.Start();
            btmap = (Bitmap)Image.FromFile(FileName);

            LockBitmap lBtmap = new LockBitmap(btmap);
            lBtmap.LockBits();

            GrayscaleRend(lBtmap);

            lBtmap.UnlockBits();
            pictureBox2.Image = (Image)btmap;
            if (checkBenchmark.Checked == true)
            {
                Benchmark.End();
                MessageBox.Show("Время " + Benchmark.GetSeconds());
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFD = new OpenFileDialog();
            if (opFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = opFD.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(FileName);
                }
                catch (Exception)
                {
                    return;
                }

                PreRender();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (btmap == null)
                return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "png";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileNameSave = sfd.FileName;
                btmap.Save(FileNameSave);
                MessageBox.Show("Сохраненно");
            }
        }

        private void Render_Click(object sender, EventArgs e)
        {
            PreRender();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            trackBright.Value = 0;
            trackContrast.Value = 0;
            trackR.Value = 0;
            trackG.Value = 0;
            trackB.Value = 0;
            checkGrayscale.Checked = false;

            PreRender();
        }
    }
}
