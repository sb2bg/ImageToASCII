using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ImageToASCII
{
    public partial class MainForm : Form
    {
        private Bitmap image;
        private Thread convertThread;
        private bool working;

        public MainForm()
        {
            InitializeComponent();
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            _ = PromptImageSelection();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                if (MessageBox.Show("You must select an image before you convert it to ASCII. Would you like to do that now?", "Image not Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PromptImageSelection();
                }

                return;
            }

            Convert();
        }

        private bool PromptImageSelection()
        {
            using (FileDialog dialog = new OpenFileDialog { Filter = "All images files|*.jpeg; *.png; *.bmp; *.jpg|jpg files|*.jpg|jpeg files|*.jpeg|png files|*.png|bitmap files|*.bmp" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(dialog.FileName);
                    displayImage.Image = image;
                    outSizeLabel.Visible = true;
                    outSizeLabel.Text = $"Output Size: {image.Width / sizeBar.Value}x{image.Height / sizeBar.Value}";

                    return true;
                }

                return false;
            }
        }

        private static readonly Dictionary<double, char> values = new Dictionary<double, char>
        {
            /* .:-=+*#?&@ */
            { 0.0, '.' },
            { 0.1, ':' },
            { 0.2, '-' },
            { 0.3, '=' },
            { 0.4, '+' },
            { 0.5, '*' },
            { 0.6, '#' },
            { 0.7, 'M' },
            { 0.8, 'W' },
            { 0.9, '&' },
            { 1.0, '@' },
        };

        private void Convert()
        {
            if (working)
            {
                _ = MessageBox.Show("Please wait for the current image to finish before starting another.", "Please wait", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            working = true;
            int sizeValue = sizeBar.Value;

            convertThread = new Thread(() =>
            {
                StringBuilder ascii = new StringBuilder();
                image = GetReSizedImage(image.Width / sizeValue);

                for (int x = 0; x < image.Height; x++)
                {
                    for (int y = 0; y < image.Width; y++)
                    {
                        Color pixel = image.GetPixel(y, x);
                        values.TryGetValue(Math.Round(1 - pixel.GetBrightness(), 1), out char pixelChar);

                        ascii.Append(pixelChar);
                    }

                    ascii.Append('\n');
                }

                Save(ascii.ToString());
                working = false;
            })
            {
                IsBackground = true
            };

            convertThread.Start();
        }

        private Bitmap GetReSizedImage(int asciiWidth)
        {
            int asciiHeight = (int)Math.Ceiling((double)image.Height * asciiWidth / image.Width);

            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage(result);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();

            return result;

        }

        protected override void OnResize(EventArgs e)
        {
            selectImage.Size = new Size(Width / 2, selectImage.Size.Height);
            convertButton.Size = new Size(Width / 2, selectImage.Size.Height);
            base.OnResize(e);
        }

        private void Save(string toSave)
        {
            File.WriteAllText(@"ImageToASCII.txt", toSave);
            _ = MessageBox.Show("Saved your image into ASCII art sucessfully.", "Saved");
        }

        private void sizeBar_Scroll(object sender, EventArgs e)
        {
            if (outSizeLabel.Visible)
            {
                outSizeLabel.Text = $"Output Size: {image.Width / sizeBar.Value}x{image.Height / sizeBar.Value}";
            }
        }
    }
}
