using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Drawing.Drawing2D;

namespace Wizard_Color_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Capture the screen and set it as the Image for the PictureBox
            pictureBox1.Image = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.CopyFromScreen(0, 0, 0, 0, pictureBox1.Size);
            }
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Get the color of the pixel that was clicked
            Color pixelColor = ((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y);

            // Get the ARGB value of the color as a 32-bit integer
            int argb = pixelColor.ToArgb();

            // Convert the ARGB value to a HEX string
            string hex = $"{pixelColor.R}{pixelColor.G}{pixelColor.B}";



            string rgb = RGBCODE.Text; // Beispiel-RGB-Farbcode

            // RGB-Farbwerte in Integer umwandeln
            int red = pixelColor.R;
            int green = pixelColor.G;
            int blue = pixelColor.B;

            // HEX-Code erstellen
            string hex2 = "#" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");


            // Update the label with the RGB and HEX values of the color
            label1.Text = "RGB: " + pixelColor.R + ", " + pixelColor.G + ", " + pixelColor.B +
                          "    HEX: " + hex2;

            panel1.BackColor = pixelColor;

            RGBCODE.Text = "rgb(" + pixelColor.R + ", " + pixelColor.G + ", " + pixelColor.B + ")";

            HEXCodeBox.Text = hex2;


            //RGB Feld Ausfüllen
            RCode.Text = Convert.ToString(pixelColor.R);
            BCode.Text = Convert.ToString(pixelColor.B);
            GCode.Text = Convert.ToString(pixelColor.G); 
        }

        private async void button1_Click(object sender, EventArgs e)
        {
          this.Hide();
           System.Threading.Thread.Sleep(300);
           Application.Restart();
        }

        private void ColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;

            // Zeigt den Farbauswahl-Dialog an und speichert die ausgewählte Farbe
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Verwenden Sie die ausgewählte Farbe hier
                Color selectedColor = colorDialog.Color;
            }
        }

        private void CopyRgbCode_Click(object sender, EventArgs e)
        {
            try
            {
                string RgbCode = RGBCODE.Text;
                Clipboard.SetText(RgbCode);
            }
            catch
            {
                MessageBox.Show("Please choose a color first");
            }
            
        }

        private void CopyHex_Click(object sender, EventArgs e)
        {
            try
            {
                string HexCode = HEXCodeBox.Text;
                Clipboard.SetText(HexCode);
            }
            catch
            {
                MessageBox.Show("Please choose a color first");
            }

          
        }

        private void RestartApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}