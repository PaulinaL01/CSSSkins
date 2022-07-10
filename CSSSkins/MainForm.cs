using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CSSSkins {
    public partial class MainForm : Form
    {
        private string imageFilename = string.Empty;
        private CssManager cssManager = new CssManager();
        private System.Drawing.Color selectedColor = System.Drawing.Color.Black;

        //gdy ladujemy zdjęcie z pliku png --> cssList się nie aktualizuje (w listbox działało)
        //zoom --> kiedy naciskamy task bar, laduje sie ciagle to samo zdjecie, gdy zmienimy na loadimage to taskbar nie dziala poprawnie

        public MainForm()
        {
            InitializeComponent();

            cssManager.LoadFiles();
            cssLb.DataSource = cssManager.CssFiles;
            cssLb_SelectedIndexChanged(null, null);
            imageLb_SelectedIndexChanged(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            trackBar2.Minimum = 1;
            trackBar2.Maximum = 6;
            trackBar2.SmallChange = 1;
            trackBar2.LargeChange = 1;
            trackBar2.UseWaitCursor = false;

            this.DoubleBuffered = true;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar2.Value != 0)
            {
                loadedImage.Width = loadedImage.Image.Width * trackBar2.Value;
                loadedImage.Height = loadedImage.Image.Height * trackBar2.Value;
            }
        }

        private void LoadImage(string filename) 
        {
            loadedImage.Image = new Bitmap(filename);
            if (filename != null)
            {
                Image bitmap = Image.FromFile(filename);
                loadedImage.Image = bitmap;
                loadedImage.Width = loadedImage.Image.Width * GetImageScale();
                loadedImage.Height = loadedImage.Image.Height * GetImageScale();
                imageFilename = System.IO.Path.GetFileName(filename);
                cssManager.EnableCssImagesByFilename(imageFilename);

                cssList.DataSource = null;
                cssList.DataSource = cssManager.UpdatedImageList;
                cssList.Refresh();
            }
        }

        private void LoadCss(string filename)
        {
            if (filename != null)
            {
                cssManager.LoadCss(filename);
                if (imageFilename != string.Empty)
                {
                    cssManager.EnableCssImagesByFilename(imageFilename);
                }
                cssList.DataSource = null;
                cssList.DataSource = cssManager.UpdatedImageList;
            }

            if (cssLb.DataSource != null)
            {
                imageLb.DataSource = null;
                imageLb.DataSource = cssManager.GetPngOnlyFormCss().Select(x => new FileElement(@"C:\Users\lesni\Downloads\" + x)).ToList();
                imageLb.Refresh();
            }
        }

        private void cssLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cssLb.SelectedItem is FileElement fileElement)
            {
                LoadCss(fileElement.Path);
            }
        }

        private void imageLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageLb.SelectedItem is FileElement fileElement)
            {
                LoadImage(fileElement.Path);
            }
        }

        private void cssList_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedImage.Invalidate();
        }

        private void SelectColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = dialog.Color;
            }
        }

        private void loadedImage_Paint(object sender, PaintEventArgs e)
        {
            if (cssList.SelectedItem is CssImageItem cssImage /*&& !cssImage.Disabled *//*&& grid != null*/)
            {
                Rectangle rect = new Rectangle(cssImage.PositionX * GetImageScale(), cssImage.PositionY * GetImageScale(), 
                    cssImage.Width * GetImageScale(),
                    cssImage.Height * GetImageScale());
                System.Drawing.Pen pen = new System.Drawing.Pen(selectedColor);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private int GetImageScale()
        {
            return (trackBar2.Value == 0 ? 1 : trackBar2.Value);
        }

        private void loadedImage_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            CssImageItem cssImage = cssManager.GetCssByPosition(e.X, e.Y, GetImageScale());
            if(cssImage != null)
            {
                cssList.SelectedIndex = cssList.Items.IndexOf(cssImage);
            }
        }
    }
}
