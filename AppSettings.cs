using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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

            SettingsDarkMode();

            ColorPickerUI mainForm = Application.OpenForms.OfType<ColorPickerUI>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.ApplicationDarkMode();
            }
        }

        private void DarkModeOFFbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DarkMode= 0;

            DialogResult DarkModeDisableMessage = MessageBox.Show("To save the changes the app must be restarted all unsaved changes will be lost!", "Disable Dark Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(DialogResult.Yes == DarkModeDisableMessage)
            {
                Application.Restart();
            }
        }



















        void SettingsDarkMode()
        {
            this.BackColor = Color.FromArgb(32, 32, 32);
            this.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
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
    }
}
