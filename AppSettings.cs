namespace Wizard_Color_Picker
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();


            // Opacity-Einstellung aus den Anwendungseinstellungen laden
            this.Opacity = Properties.Settings.Default.Opacity;

            if (Properties.Settings.Default.DarkMode == 1)
            {
                SettingsDarkMode();
            }

            //  double imageSizeInMb = Properties.Settings.Default.ImageSizeInMb;
            //  imagesizelbl.Text = "" + imageSizeInMb.ToString() + " MB";



            //   long memorySize = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;
            //   double sizeInMB = memorySize / (1024.0 * 1024.0);
            //   AppSizelbl.Text = "Größe des Programms: " + sizeInMB.ToString("N2") + " MB";

            string appFolderPath = Path.GetDirectoryName(Application.ExecutablePath);
            long appSize = GetDirectorySize(appFolderPath);
            double appSizeMB = appSize / (1024.0 * 1024.0);
            AppSizelbl.Text = "App Storage: " + appSizeMB.ToString("N2") + " MB";
        }

        public static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo folder = new DirectoryInfo(folderPath);
            long folderSize = 0;
            foreach (FileInfo file in folder.GetFiles("*.*", SearchOption.AllDirectories))
            {
                folderSize += file.Length;
            }
            return folderSize;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ClearMessage = MessageBox.Show("Are you sure you want to delete all stored color codes?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == ClearMessage)
            {
                ColorPickerUI mainForm = Application.OpenForms.OfType<ColorPickerUI>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.ClearListBox();
                }
            }
        }

        public class TrackBarData
        {
            public int Value { get; set; }
        }


        private void TransprencyONbtn_Click(object sender, EventArgs e)
        {
            ColorPickerUI mainForm = Application.OpenForms.OfType<ColorPickerUI>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.Transparancy();
                this.Opacity = 0.96;
            }
        }

        private void TransprancyOFFbtn_Click(object sender, EventArgs e)
        {
            ColorPickerUI mainForm = Application.OpenForms.OfType<ColorPickerUI>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.DisableTransparency();
                this.Opacity = 1;
            }
        }

        private void CloseWindowbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetWindowSizebtn_Click(object sender, EventArgs e)
        {
            ColorPickerUI mainForm = Application.OpenForms.OfType<ColorPickerUI>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.RestoreWindowSize();
            }
        }

        private void DeleteImagebtn_Click(object sender, EventArgs e)
        {
            ColorPickerUI mainForm = Application.OpenForms.OfType<ColorPickerUI>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.DeleteImage();
            }
        }

        private void DarkModeONbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DarkMode = 1;

            DarkModeOFFbtn.Enabled = true;

            SettingsDarkMode();

            ColorPickerUI mainForm = Application.OpenForms.OfType<ColorPickerUI>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.ApplicationDarkMode();
            }
        }

        private void DarkModeOFFbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DarkMode = 0;

            DialogResult DarkModeDisableMessage = MessageBox.Show("To save the changes the app must be restarted all unsaved changes will be lost!", "Disable Dark Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == DarkModeDisableMessage)
            {
                Application.Restart();
            }
        }



















        void SettingsDarkMode()
        {
            this.BackColor = Color.FromArgb(32, 32, 32);
            this.ForeColor = Color.White;
            panel1.BackColor = Color.FromArgb(255, 27, 27, 27);

            button1.FlatStyle = FlatStyle.Standard;
            button1.BackColor = Color.FromArgb(51, 51, 51);
            button1.ForeColor = Color.White;
            DeleteImagebtn.FlatStyle = FlatStyle.Standard;
            DeleteImagebtn.BackColor = Color.FromArgb(51, 51, 51);
            DeleteImagebtn.ForeColor = Color.White;
            TransprencyONbtn.FlatStyle = FlatStyle.Standard;
            TransprencyONbtn.BackColor = Color.FromArgb(51, 51, 51);
            TransprencyONbtn.ForeColor = Color.White;
            TransprancyOFFbtn.FlatStyle = FlatStyle.Standard;
            TransprancyOFFbtn.BackColor = Color.FromArgb(51, 51, 51);
            TransprancyOFFbtn.ForeColor = Color.White;
            ResetWindowSizebtn.FlatStyle = FlatStyle.Standard;
            ResetWindowSizebtn.BackColor = Color.FromArgb(51, 51, 51);
            ResetWindowSizebtn.ForeColor = Color.White;
            DarkModeONbtn.FlatStyle = FlatStyle.Standard;
            DarkModeONbtn.BackColor = Color.FromArgb(51, 51, 51);
            DarkModeONbtn.ForeColor = Color.White;
            DarkModeOFFbtn.FlatStyle = FlatStyle.Standard;
            DarkModeOFFbtn.BackColor = Color.FromArgb(51, 51, 51);
            DarkModeOFFbtn.ForeColor = Color.White;
            CloseWindowbtn.FlatStyle = FlatStyle.Standard;
            CloseWindowbtn.BackColor = Color.FromArgb(51, 51, 51);
            CloseWindowbtn.ForeColor = Color.White;
        }



        private void AppSettings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DarkMode == 1)
            {
                DarkModeOFFbtn.Enabled = true;
            }
            else
            {
                DarkModeOFFbtn.Enabled = false;
            }

                string folderPath = "Settings"; // ersetzen Sie dies durch den Pfad zum Unterordner Ihrer App
            long folderSize = GetFolderSize(folderPath); // rufen Sie die Funktion GetFolderSize auf, um die Größe des Ordners zu erhalten
            label13.Text = "App Cache: " + folderSize.ToString() + " Bytes"; // setzen Sie den Text des Labels auf die Größe des Ordners in Bytes
        }

        // Funktion, um die Größe eines Ordners in Bytes zu erhalten
        public static long GetFolderSize(string folderPath)
        {
            long size = 0;

            // erhalten Sie eine Liste von Dateien im Ordner
            string[] files = Directory.GetFiles(folderPath);

            // addieren Sie die Größe jedes Files zur Gesamtgröße des Ordners
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }

            // erhalten Sie eine Liste von Unterordnern im Ordner
            string[] subDirectories = Directory.GetDirectories(folderPath);

            // rufen Sie diese Funktion rekursiv für jeden Unterordner auf
            foreach (string subDirectory in subDirectories)
            {
                size += GetFolderSize(subDirectory);
            }

            return size;
        }
    }
}
