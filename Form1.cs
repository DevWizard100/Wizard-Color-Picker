using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Drawing.Drawing2D;
using Newtonsoft.Json;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.DataFormats;
using System.Diagnostics.Tracing;

namespace Wizard_Color_Picker
{
    public partial class Form1 : Form
    {
        // Der Pfad der JSON-Datei
        private string jsonFilePath = "Settings/SavedColorCodes.json";
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

            addcodetext();


            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Get the color of the pixel that was clicked
            Color pixelColor = ((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y);

          
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


            SelectedColorlbl.Text = "RGB: " + pixelColor.R + ", " + pixelColor.G + ", " + pixelColor.B +
                          "    HEX: " + hex2;

            ColorPreviewCanvas.BackColor = pixelColor;

            RGBCODE.Text = "rgb(" + pixelColor.R + ", " + pixelColor.G + ", " + pixelColor.B + ")";

            HEXCodeBox.Text = hex2;


            //RGB Feld Ausf?llen
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
         //  ColorDialog colorDialog = new ColorDialog();
         //  colorDialog.FullOpen = true;
         //
         //  // Zeigt den Farbauswahl-Dialog an und speichert die ausgew?hlte Farbe
         //  if (colorDialog.ShowDialog() == DialogResult.OK)
         //  {
         //      // Verwenden Sie die ausgew?hlte Farbe hier
         //      Color selectedColor = colorDialog.Color;
         //  }

            // Create a new ColorDialog component
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.FullOpen = true;

            // Show the dialog and get the user's input
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the text box fore color to the selected color
                HEXCodeBox.Text = ToHex(MyDialog.Color); 

                ColorPreviewCanvas.BackColor = MyDialog.Color;

                RGBCODE.Text = MyDialog.Color.ToString();

                SelectedColorlbl.Text = MyDialog.Color.ToString();
            }



        }

        // Define a custom function to convert a Color to a HEX string
        public static string ToHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
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

            LoadCheckBoxStatus();
         

            // ?berpr?fen Sie, ob die JSON-Datei existiert
            if (File.Exists(jsonFilePath))
            {
                // Lesen Sie die JSON-Zeichenfolge aus der Datei
                string jsonString = File.ReadAllText(jsonFilePath);

                // Konvertieren Sie die JSON-Zeichenfolge in eine Liste von Objekten
                List<object> items = JsonConvert.DeserializeObject<List<object>>(jsonString);

                // F?gen Sie die Liste von Objekten der ListBox hinzu
                colorlistbox.Items.AddRange(items.ToArray());
            }
        }


        // Speichere die Fenstergr??e und -position in eine JSON-Datei
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

        // Schreibe die Gr??en in die Datei
        File.WriteAllText("Settings/windowstate.json", json);
        }

        // Lade die Fenstergr??e und -position aus einer JSON-Datei
        private void LoadWindowState()
        {
        // Pr?fe, ob die Datei vorhanden ist
        if (File.Exists("Settings/windowstate.json"))
        {
            // Lese die JSON-Zeichenfolge aus der Datei
            string json = File.ReadAllText("Settings/windowstate.json");

           
            WindowState state = JsonConvert.DeserializeObject<WindowState>(json);

          
            this.Size = state.Size;
            this.Location = state.Location;
        }
        }

        // Eine Klasse f?r die Fenster Gr??e
        public class WindowState
        {
            public Size Size { get; set; }
        public Point Location { get; set; }
        }

        // Fenstergr??e Speichern Wenn das Programm Geschlossen wird
        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bilddateien (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog.Title = "Bild ?ffnen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Code zum Einf?gen des ausgew?hlten Bildes in die Imagebox
                Image image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = image;

            }
        }

        private void ContextExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContextRefresh_Click(object sender, EventArgs e)
        {
            // Capture the screen and set it as the Image for the PictureBox
            pictureBox1.Image = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.CopyFromScreen(0, 0, 0, 0, pictureBox1.Size);
            }

            addcodetext();
        }

        void addcodetext()
        {
            // Get the color of the pixel that was clicked
            Color pixelColor = ((Bitmap)pictureBox1.Image).GetPixel(1, 1);

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


            SelectedColorlbl.Text = "RGB: " + pixelColor.R + ", " + pixelColor.G + ", " + pixelColor.B +
                          "    HEX: " + hex2;

            ColorPreviewCanvas.BackColor = pixelColor;

            RGBCODE.Text = "rgb(" + pixelColor.R + ", " + pixelColor.G + ", " + pixelColor.B + ")";

            HEXCodeBox.Text = hex2;


            //RGB Feld Ausf?llen
            RCode.Text = Convert.ToString(pixelColor.R);
            BCode.Text = Convert.ToString(pixelColor.B);
            GCode.Text = Convert.ToString(pixelColor.G);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (Path.GetExtension(file).ToLower() == ".jpg" ||
                     Path.GetExtension(file).ToLower() == ".png" ||
                     Path.GetExtension(file).ToLower() == ".bmp")
                {
                    pictureBox1.Image = Image.FromFile(file);
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult SaveMessage = MessageBox.Show("Save color code for later", "Save", MessageBoxButtons.OKCancel);

            if (SaveMessage== DialogResult.OK)
            {
                colorlistbox.Items.Add(HEXCodeBox.Text);
            }

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Konvertieren Sie die ListBox.Items-Sammlung in eine JSON-Zeichenfolge
            string jsonString = JsonConvert.SerializeObject(colorlistbox.Items);

            // Schreiben Sie die JSON-Zeichenfolge in eine Datei
            File.WriteAllText(jsonFilePath, jsonString);

            SaveCheckBoxStatus();
        }

        private void ClearSavedColorbtn_Click(object sender, EventArgs e)
        {
            DialogResult ClearMessage = MessageBox.Show("Are you sure you want to delete all stored color codes?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(DialogResult.Yes == ClearMessage)
            {
                colorlistbox.Items.Clear();
            }
        }

        private void colorlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
      

            try
            {
                var a = colorlistbox.SelectedItem.ToString();
                HEXCodeBox.Text = a;

                // Verwenden Sie die ColorTranslator-Klasse, um den Hexcode in eine Color-Instanz zu konvertieren

                Color color = ColorTranslator.FromHtml(a);

                ColorPreviewCanvas.BackColor = color;

                RGBCODE.Text = color.ToString();

                SelectedColorlbl.Text = color.ToString();
            }
            catch { }

        }



        private void SaveCheckBoxStatus()
        {
            // Erstellen Sie ein Objekt mit den aktuellen Status der Checkboxen
            var status = new CheckBoxStatus
            {
                EnableDarkMode = EnableDarkModeCheckbox.Checked,
            };

            // Konvertieren Sie das Objekt in einen JSON String
            var json = JsonConvert.SerializeObject(status);

            // Speichern Sie den JSON String in einer Datei
            File.WriteAllText("Settings/status.json", json);
        }

        private void LoadCheckBoxStatus()
        {
            // Pr?fen Sie, ob die Datei existiert
            if (File.Exists("Settings/status.json"))
            {
                // Lesen Sie den JSON String aus der Datei
                var json = File.ReadAllText("Settings/status.json");

                // Konvertieren Sie den JSON String in ein Objekt
                var status = JsonConvert.DeserializeObject<CheckBoxStatus>(json);

                // Aktualisieren Sie die Status der Checkboxen entsprechend dem Objekt
        
                EnableDarkModeCheckbox.Checked = status.EnableDarkMode;
            }
        }


        void CheckboxSettings()
        {
         //   // Pr?fen Sie, ob die Checkbox checked ist
         //   if (ShowWelcomeScreen.Checked)
         //   {
         //       Form2 myForm = new Form2();
         //
         //       myForm.Show();
         //   }
         //
            if(EnableDarkModeCheckbox.Checked)
            {
                ApplicationDarkMode();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxSettings();
        }

        private void ShowWelcomeScreen_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxSettings();
        }













        void ApplicationDarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            SelectedColorlbl.ForeColor = Color.White;

            panel3.BackgroundImage = null;
            button2.Image = null;
            ColorDialogbtn.Image = null;

            this.BackColor = Color.FromArgb(32, 32, 32);
            this.ForeColor = Color.FromArgb(25, 25, 25);

            HEXCodeBox.ForeColor = Color.White;
            HEXCodeBox.BackColor = Color.FromArgb(51, 51, 51);

            RGBCODE.ForeColor = Color.White;
            RGBCODE.BackColor = Color.FromArgb(51, 51, 51);

            CopyHex.ForeColor = Color.White;
            CopyHex.BackColor = Color.FromArgb(51, 51, 51);
            CopyHex.Image = null;
            CopyHex.Text = "Copy";

            CopyRgbCode.ForeColor = Color.White;
            CopyRgbCode.BackColor = Color.FromArgb(51, 51, 51);
            CopyRgbCode.Text = "Copy";
            CopyRgbCode.Image = null;

            Refreshbtn.ForeColor = Color.White;
            Refreshbtn.BackColor = Color.FromArgb(51, 51, 51);
            Refreshbtn.FlatStyle = FlatStyle.Standard;

            ColorDialogbtn.ForeColor = Color.White;
            ColorDialogbtn.BackColor = Color.FromArgb(51, 51, 51);

            RCode.ForeColor = Color.White;
            GCode.ForeColor = Color.White;
            BCode.ForeColor = Color.White;

            RCode.BackColor = Color.FromArgb(51, 51, 51);
            GCode.BackColor = Color.FromArgb(51, 51, 51);
            BCode.BackColor = Color.FromArgb(51, 51, 51);

            ClearSavedColorbtn.ForeColor = Color.White;
            ClearSavedColorbtn.BackColor = Color.FromArgb(51, 51, 51);
            ClearSavedColorbtn.Text = "D";
            ClearSavedColorbtn.Image = null;

            colorlistbox.ForeColor = Color.White;
            colorlistbox.BackColor = Color.FromArgb(32, 32, 32);

            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(51, 51, 51);
            savecolorbtn.ForeColor = Color.White;
            savecolorbtn.BackColor = Color.FromArgb(51, 51, 51);
            savecolorbtn.FlatStyle = FlatStyle.Standard;

            CloseApplication.ForeColor = Color.White;
            CloseApplication.BackColor = Color.FromArgb(51, 51, 51);
            CloseApplication.FlatStyle = FlatStyle.Standard;
            EnableDarkModeCheckbox.ForeColor = Color.White;
        }

        private void EnableDarkModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
     
            if(this.BackColor == Color.White)
            {
                ApplicationDarkMode();
            }
            else
            {
                Application.Restart();
            }
          
        }
    }
    public class CheckBoxStatus
    {
        public bool CheckBoxWelcome { get; set; }
        public bool CheckBox2 { get; set; }
        public bool CheckBox3 { get; set; }

        public bool EnableDarkMode { get; set; }
    }
}

//2023