using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace LodineImageTool
{
    public partial class Form1 : Form
    {
        Image selected_image;
        string selected_image_filename;
        string[] image_extensions = { ".PNG", ".JPEG", ".JPG" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string extension in image_extensions)
            {
                saveTypeExtensions.Items.Add(extension);
            }

            saveTypeExtensions.SelectedIndex = 0;
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images | *.png;*.jpg;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath.Text = ofd.FileName;
                selected_image_filename = ofd.FileName.Split(Path.DirectorySeparatorChar).Last();
                selected_image = Image.FromFile(ofd.FileName);
            }
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(widthUpDown.Text);
            int height = Convert.ToInt32(heightUpDown.Text);
            selected_image = ResizeImage(selected_image, width, height);

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selected_image.Save(dialog.SelectedPath + Path.DirectorySeparatorChar + selected_image_filename + saveTypeExtensions.Text.ToLower());
                MessageBox.Show("Resized Image saved!\nPath: " + dialog.SelectedPath);
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void openGithubButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/LodineSoftware/ImageTool",
                UseShellExecute = true,
            });
        }
    }
}