namespace Wizard_Color_Picker
{
    partial class ColorPickerUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerUI));
            ColorPictureBox = new PictureBox();
            PictureMenu = new ContextMenuStrip(components);
            copyImageToolStripMenuItem = new ToolStripMenuItem();
            SystemTrayMenu = new ContextMenuStrip(components);
            ContextRefresh = new ToolStripMenuItem();
            ContextExit = new ToolStripMenuItem();
            Refreshbtn = new Button();
            ColorPreviewCanvas = new Panel();
            label2 = new Label();
            ColorDialogbtn = new Button();
            label3 = new Label();
            label4 = new Label();
            CopyRgbCode = new Button();
            label5 = new Label();
            RGBCODE = new TextBox();
            HEXCodeBox = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            CloseApplication = new Button();
            RCode = new TextBox();
            GCode = new TextBox();
            BCode = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            CopyHex = new Button();
            button2 = new Button();
            label11 = new Label();
            label12 = new Label();
            AppMsg = new NotifyIcon(components);
            label13 = new Label();
            colorlistbox = new ListBox();
            savecolorbtn = new Button();
            label1 = new Label();
            SelectedColorlbl = new Label();
            label7 = new Label();
            ClearSavedColorbtn = new Button();
            pastepicturebtn = new Button();
            DelColorListbtn = new Button();
            Settingsbtn = new Button();
            AppVersionlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)ColorPictureBox).BeginInit();
            PictureMenu.SuspendLayout();
            SystemTrayMenu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ColorPictureBox
            // 
            ColorPictureBox.BackgroundImageLayout = ImageLayout.None;
            ColorPictureBox.ContextMenuStrip = PictureMenu;
            ColorPictureBox.Location = new Point(0, 0);
            ColorPictureBox.Name = "ColorPictureBox";
            ColorPictureBox.Size = new Size(594, 406);
            ColorPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ColorPictureBox.TabIndex = 0;
            ColorPictureBox.TabStop = false;
            ColorPictureBox.DragDrop += pictureBox1_DragDrop;
            ColorPictureBox.DragEnter += pictureBox1_DragEnter;
            ColorPictureBox.MouseClick += pictureBox1_MouseClick_1;
            ColorPictureBox.MouseLeave += ColorPictureBox_MouseLeave;
            ColorPictureBox.MouseMove += ColorPictureBox_MouseMove;
            // 
            // PictureMenu
            // 
            PictureMenu.BackColor = Color.FromArgb(42, 42, 42);
            PictureMenu.Items.AddRange(new ToolStripItem[] { copyImageToolStripMenuItem });
            PictureMenu.Name = "PictureMenu";
            PictureMenu.RenderMode = ToolStripRenderMode.System;
            PictureMenu.Size = new Size(139, 26);
            // 
            // copyImageToolStripMenuItem
            // 
            copyImageToolStripMenuItem.ForeColor = SystemColors.Window;
            copyImageToolStripMenuItem.Name = "copyImageToolStripMenuItem";
            copyImageToolStripMenuItem.Size = new Size(138, 22);
            copyImageToolStripMenuItem.Text = "Copy Image";
            copyImageToolStripMenuItem.Click += copyImageToolStripMenuItem_Click;
            // 
            // SystemTrayMenu
            // 
            SystemTrayMenu.BackColor = Color.FromArgb(42, 42, 42);
            SystemTrayMenu.Items.AddRange(new ToolStripItem[] { ContextRefresh, ContextExit });
            SystemTrayMenu.Name = "contextMenuStrip1";
            SystemTrayMenu.RenderMode = ToolStripRenderMode.System;
            SystemTrayMenu.Size = new Size(114, 48);
            // 
            // ContextRefresh
            // 
            ContextRefresh.BackColor = SystemColors.Window;
            ContextRefresh.ForeColor = Color.White;
            ContextRefresh.Name = "ContextRefresh";
            ContextRefresh.Size = new Size(113, 22);
            ContextRefresh.Text = "Refresh";
            ContextRefresh.Click += ContextRefresh_Click;
            // 
            // ContextExit
            // 
            ContextExit.ForeColor = Color.White;
            ContextExit.Name = "ContextExit";
            ContextExit.Size = new Size(113, 22);
            ContextExit.Text = "Exit";
            ContextExit.Click += ContextExit_Click;
            // 
            // Refreshbtn
            // 
            Refreshbtn.FlatStyle = FlatStyle.System;
            Refreshbtn.Location = new Point(237, 5);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(69, 23);
            Refreshbtn.TabIndex = 2;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = true;
            Refreshbtn.Click += button1_Click;
            // 
            // ColorPreviewCanvas
            // 
            ColorPreviewCanvas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ColorPreviewCanvas.BackColor = Color.FromArgb(31, 31, 31);
            ColorPreviewCanvas.Cursor = Cursors.AppStarting;
            ColorPreviewCanvas.Location = new Point(12, 436);
            ColorPreviewCanvas.Name = "ColorPreviewCanvas";
            ColorPreviewCanvas.Size = new Size(61, 60);
            ColorPreviewCanvas.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 476);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "RGB:";
            // 
            // ColorDialogbtn
            // 
            ColorDialogbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ColorDialogbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ColorDialogbtn.Image = (Image)resources.GetObject("ColorDialogbtn.Image");
            ColorDialogbtn.ImageAlign = ContentAlignment.MiddleRight;
            ColorDialogbtn.Location = new Point(640, 86);
            ColorDialogbtn.Name = "ColorDialogbtn";
            ColorDialogbtn.Size = new Size(58, 26);
            ColorDialogbtn.TabIndex = 6;
            ColorDialogbtn.Text = "Open";
            ColorDialogbtn.TextAlign = ContentAlignment.MiddleLeft;
            ColorDialogbtn.UseVisualStyleBackColor = true;
            ColorDialogbtn.Click += ColorDialog_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(640, 51);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Color";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(640, 68);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Dialog Field:";
            // 
            // CopyRgbCode
            // 
            CopyRgbCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CopyRgbCode.Cursor = Cursors.AppStarting;
            CopyRgbCode.Image = Properties.Resources.icons8_copy_171;
            CopyRgbCode.Location = new Point(221, 472);
            CopyRgbCode.Name = "CopyRgbCode";
            CopyRgbCode.Size = new Size(43, 24);
            CopyRgbCode.TabIndex = 9;
            CopyRgbCode.UseVisualStyleBackColor = true;
            CopyRgbCode.Click += CopyRgbCode_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(79, 447);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 10;
            label5.Text = "HEX:";
            // 
            // RGBCODE
            // 
            RGBCODE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RGBCODE.Location = new Point(120, 472);
            RGBCODE.Name = "RGBCODE";
            RGBCODE.PlaceholderText = "0, 0, 0";
            RGBCODE.Size = new Size(95, 23);
            RGBCODE.TabIndex = 4;
            // 
            // HEXCodeBox
            // 
            HEXCodeBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            HEXCodeBox.Location = new Point(120, 444);
            HEXCodeBox.Name = "HEXCodeBox";
            HEXCodeBox.PlaceholderText = "#000000";
            HEXCodeBox.Size = new Size(95, 23);
            HEXCodeBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(219, 15);
            label6.TabIndex = 13;
            label6.Text = "Click on the picture to identify the color:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ColorPictureBox);
            panel2.Location = new Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 405);
            panel2.TabIndex = 14;
            // 
            // CloseApplication
            // 
            CloseApplication.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseApplication.FlatStyle = FlatStyle.System;
            CloseApplication.Location = new Point(640, 471);
            CloseApplication.Name = "CloseApplication";
            CloseApplication.Size = new Size(75, 23);
            CloseApplication.TabIndex = 15;
            CloseApplication.Text = "Close";
            CloseApplication.UseVisualStyleBackColor = true;
            CloseApplication.Click += RestartApplication_Click;
            // 
            // RCode
            // 
            RCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RCode.Location = new Point(492, 5);
            RCode.Name = "RCode";
            RCode.Size = new Size(30, 23);
            RCode.TabIndex = 18;
            // 
            // GCode
            // 
            GCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GCode.Location = new Point(542, 5);
            GCode.Name = "GCode";
            GCode.Size = new Size(30, 23);
            GCode.TabIndex = 19;
            // 
            // BCode
            // 
            BCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCode.Location = new Point(591, 5);
            BCode.Name = "BCode";
            BCode.Size = new Size(30, 23);
            BCode.TabIndex = 20;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(474, 9);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 21;
            label8.Text = "R:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(524, 9);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 22;
            label9.Text = "G:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(573, 9);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 23;
            label10.Text = "B:";
            // 
            // CopyHex
            // 
            CopyHex.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CopyHex.Cursor = Cursors.AppStarting;
            CopyHex.Image = Properties.Resources.icons8_copy_171;
            CopyHex.Location = new Point(221, 444);
            CopyHex.Name = "CopyHex";
            CopyHex.Size = new Size(43, 24);
            CopyHex.TabIndex = 24;
            CopyHex.UseVisualStyleBackColor = true;
            CopyHex.Click += CopyHex_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Image = Properties.Resources.image_FILL0_wght400_GRAD0_opsz48;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(640, 161);
            button2.Name = "button2";
            button2.Size = new Size(69, 26);
            button2.TabIndex = 26;
            button2.Text = "Import";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(640, 128);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 27;
            label11.Text = "Open any";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(640, 143);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 28;
            label12.Text = "pictures:";
            // 
            // AppMsg
            // 
            AppMsg.ContextMenuStrip = SystemTrayMenu;
            AppMsg.Icon = (Icon)resources.GetObject("AppMsg.Icon");
            AppMsg.Text = "Quick Options";
            AppMsg.Visible = true;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(270, 446);
            label13.Name = "label13";
            label13.Size = new Size(178, 15);
            label13.TabIndex = 29;
            label13.Text = "Add images with drag and drop!";
            // 
            // colorlistbox
            // 
            colorlistbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            colorlistbox.BorderStyle = BorderStyle.None;
            colorlistbox.FormattingEnabled = true;
            colorlistbox.ItemHeight = 15;
            colorlistbox.Location = new Point(640, 271);
            colorlistbox.Name = "colorlistbox";
            colorlistbox.Size = new Size(69, 165);
            colorlistbox.TabIndex = 30;
            colorlistbox.SelectedIndexChanged += colorlistbox_SelectedIndexChanged;
            // 
            // savecolorbtn
            // 
            savecolorbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            savecolorbtn.FlatStyle = FlatStyle.System;
            savecolorbtn.Location = new Point(562, 471);
            savecolorbtn.Name = "savecolorbtn";
            savecolorbtn.Size = new Size(75, 23);
            savecolorbtn.TabIndex = 31;
            savecolorbtn.Text = "Save";
            savecolorbtn.UseVisualStyleBackColor = true;
            savecolorbtn.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(640, 239);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 32;
            label1.Text = "Saved Color:";
            // 
            // SelectedColorlbl
            // 
            SelectedColorlbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SelectedColorlbl.AutoSize = true;
            SelectedColorlbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedColorlbl.Location = new Point(270, 480);
            SelectedColorlbl.Name = "SelectedColorlbl";
            SelectedColorlbl.Size = new Size(145, 15);
            SelectedColorlbl.TabIndex = 35;
            SelectedColorlbl.Text = "RGB: 0, 0, 0   HEX: #000000";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(270, 465);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 36;
            label7.Text = "Selected Color:";
            // 
            // ClearSavedColorbtn
            // 
            ClearSavedColorbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearSavedColorbtn.Image = (Image)resources.GetObject("ClearSavedColorbtn.Image");
            ClearSavedColorbtn.Location = new Point(640, 209);
            ClearSavedColorbtn.Name = "ClearSavedColorbtn";
            ClearSavedColorbtn.Size = new Size(28, 27);
            ClearSavedColorbtn.TabIndex = 37;
            ClearSavedColorbtn.UseVisualStyleBackColor = true;
            ClearSavedColorbtn.Click += ClearSavedColorbtn_Click;
            // 
            // pastepicturebtn
            // 
            pastepicturebtn.Cursor = Cursors.AppStarting;
            pastepicturebtn.FlatStyle = FlatStyle.System;
            pastepicturebtn.Location = new Point(312, 5);
            pastepicturebtn.Name = "pastepicturebtn";
            pastepicturebtn.Size = new Size(45, 23);
            pastepicturebtn.TabIndex = 45;
            pastepicturebtn.Text = "Paste";
            pastepicturebtn.UseVisualStyleBackColor = true;
            pastepicturebtn.Click += pastepicturebtn_Click;
            // 
            // DelColorListbtn
            // 
            DelColorListbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DelColorListbtn.FlatStyle = FlatStyle.System;
            DelColorListbtn.Location = new Point(674, 209);
            DelColorListbtn.Name = "DelColorListbtn";
            DelColorListbtn.Size = new Size(35, 27);
            DelColorListbtn.TabIndex = 46;
            DelColorListbtn.Text = "DEL";
            DelColorListbtn.UseVisualStyleBackColor = true;
            DelColorListbtn.Click += DelColorListbtn_Click;
            // 
            // Settingsbtn
            // 
            Settingsbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Settingsbtn.FlatStyle = FlatStyle.System;
            Settingsbtn.Location = new Point(640, 5);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(69, 26);
            Settingsbtn.TabIndex = 47;
            Settingsbtn.Text = "Settings ⇱";
            Settingsbtn.UseVisualStyleBackColor = true;
            Settingsbtn.Click += Settingsbtn_Click;
            // 
            // AppVersionlbl
            // 
            AppVersionlbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AppVersionlbl.FlatStyle = FlatStyle.Popup;
            AppVersionlbl.Location = new Point(609, 453);
            AppVersionlbl.Name = "AppVersionlbl";
            AppVersionlbl.Size = new Size(106, 15);
            AppVersionlbl.TabIndex = 48;
            AppVersionlbl.Text = "App Version v1.0.4";
            AppVersionlbl.TextAlign = ContentAlignment.TopRight;
            // 
            // ColorPickerUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(726, 506);
            Controls.Add(AppVersionlbl);
            Controls.Add(Settingsbtn);
            Controls.Add(DelColorListbtn);
            Controls.Add(pastepicturebtn);
            Controls.Add(ClearSavedColorbtn);
            Controls.Add(SelectedColorlbl);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(savecolorbtn);
            Controls.Add(colorlistbox);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(CopyHex);
            Controls.Add(label8);
            Controls.Add(RCode);
            Controls.Add(label10);
            Controls.Add(ColorPreviewCanvas);
            Controls.Add(GCode);
            Controls.Add(CloseApplication);
            Controls.Add(BCode);
            Controls.Add(RGBCODE);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(CopyRgbCode);
            Controls.Add(label3);
            Controls.Add(ColorDialogbtn);
            Controls.Add(label5);
            Controls.Add(Refreshbtn);
            Controls.Add(HEXCodeBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(643, 454);
            Name = "ColorPickerUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wizard Color Picker  |  Start";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ColorPictureBox).EndInit();
            PictureMenu.ResumeLayout(false);
            SystemTrayMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ColorPictureBox;
        private Button Refreshbtn;
        private Panel ColorPreviewCanvas;
        private Label label2;
        private Button ColorDialogbtn;
        private Label label3;
        private Label label4;
        private Button CopyRgbCode;
        private Label label5;
        private TextBox RGBCODE;
        private TextBox HEXCodeBox;
        private Label label6;
        private Panel panel2;
        private Button CloseApplication;
        private TextBox RCode;
        private TextBox GCode;
        private TextBox BCode;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button CopyHex;
        private Button button2;
        private Label label11;
        private Label label12;
        private NotifyIcon AppMsg;
        private ContextMenuStrip SystemTrayMenu;
        private ToolStripMenuItem ContextRefresh;
        private ToolStripMenuItem ContextExit;
        private Label label13;
        private ListBox colorlistbox;
        private Button savecolorbtn;
        private Label label1;
        private Label SelectedColorlbl;
        private Label label7;
        private Button ClearSavedColorbtn;
        private Button pastepicturebtn;
        private ContextMenuStrip PictureMenu;
        private ToolStripMenuItem copyImageToolStripMenuItem;
        private Button DelColorListbtn;
        private Button Settingsbtn;
        private Label AppVersionlbl;
    }
}