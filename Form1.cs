using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Drawing.Drawing2D;
using Newtonsoft.Json;

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

            this.FormClosing += MyForm_FormClosing;
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


            //RGB Feld Ausf�llen
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

            // Zeigt den Farbauswahl-Dialog an und speichert die ausgew�hlte Farbe
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Verwenden Sie die ausgew�hlte Farbe hier
                Color selectedColor = colorDialog.Color;
            }
        }

        private void CopyRgbCode_Click(object sender, EventArgs e)
        {
            try
            {
                string RgbCode = RGBCODE.Text;
                Clipboard.SetText(RgbCode);
                AppMessages.ShowBalloonTip(1000, "Copied!", "The color code " + RgbCode + " was copied to the clipboard", ToolTipIcon.Info);
            }
            catch
            {
                MessageBox.Show("Please choose a color first");
            }
            
        }

        private void CopyHex_Click_1(object sender, EventArgs e)
        {
            try
            {
                string HexCode = HEXCodeBox.Text;
                Clipboard.SetText(HexCode);
                AppMessages.ShowBalloonTip(1000, "Copied!", "The color code " + HexCode + " was copied to the clipboard", ToolTipIcon.Info);
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
            LoadWindowState();
        }


        // Speichere die Fenstergr��e und -position in eine JSON-Datei
        private void SaveWindowState()
         {
        // Erstelle ein Fensterzustandsobjekt mit den aktuellen Eigenschaften
        WindowState state = new WindowState()
        {
            Size = this.Size,
            Location = this.Location
        };

        // Serialisiere das Fensterzustandsobjekt in eine JSON-Zeichenfolge
        string json = JsonConvert.SerializeObject(state);

        // Schreibe die JSON-Zeichenfolge in die Datei
        File.WriteAllText("windowstate.json", json);
        }

        // Lade die Fenstergr��e und -position aus einer JSON-Datei
        private void LoadWindowState()
        {
        // Pr�fe, ob die Datei vorhanden ist
        if (File.Exists("windowstate.json"))
        {
            // Lese die JSON-Zeichenfolge aus der Datei
            string json = File.ReadAllText("windowstate.json");

            // Deserialisiere die JSON-Zeichenfolge in ein Fensterzustandsobjekt
            WindowState state = JsonConvert.DeserializeObject<WindowState>(json);

            // Setze die Eigenschaften auf die Werte aus dem Fensterzustandsobjekt
            this.Size = state.Size;
            this.Location = state.Location;
        }
        }

        // Eine Klasse, die die Fenstergr��e und -position repr�sentiert
        public class WindowState
        {
            public Size Size { get; set; }
        public Point Location { get; set; }
        }

        // Ereignishandler f�r das Formularschlie�en
        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bilddateien (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog.Title = "Bild �ffnen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Code zum Einf�gen des ausgew�hlten Bildes in die Imagebox
                Image image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = image;

            }
        }
    }
}