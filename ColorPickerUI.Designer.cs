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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerUI));
            this.ColorPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.ColorPreviewCanvas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorDialogbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CopyRgbCode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RGBCODE = new System.Windows.Forms.TextBox();
            this.HEXCodeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.RCode = new System.Windows.Forms.TextBox();
            this.GCode = new System.Windows.Forms.TextBox();
            this.BCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CopyHex = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AppMsg = new System.Windows.Forms.NotifyIcon(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.colorlistbox = new System.Windows.Forms.ListBox();
            this.savecolorbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedColorlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearSavedColorbtn = new System.Windows.Forms.Button();
            this.pastepicturebtn = new System.Windows.Forms.Button();
            this.DelColorListbtn = new System.Windows.Forms.Button();
            this.Settingsbtn = new System.Windows.Forms.Button();
            this.AppVersionlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
            this.PictureMenu.SuspendLayout();
            this.SystemTrayMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorPictureBox
            // 
            this.ColorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ColorPictureBox.ContextMenuStrip = this.PictureMenu;
            this.ColorPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ColorPictureBox.Name = "ColorPictureBox";
            this.ColorPictureBox.Size = new System.Drawing.Size(594, 406);
            this.ColorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ColorPictureBox.TabIndex = 0;
            this.ColorPictureBox.TabStop = false;
            this.ColorPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.ColorPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.ColorPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            // 
            // PictureMenu
            // 
            this.PictureMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PictureMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyImageToolStripMenuItem});
            this.PictureMenu.Name = "PictureMenu";
            this.PictureMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.PictureMenu.Size = new System.Drawing.Size(139, 26);
            // 
            // copyImageToolStripMenuItem
            // 
            this.copyImageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.copyImageToolStripMenuItem.Name = "copyImageToolStripMenuItem";
            this.copyImageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyImageToolStripMenuItem.Text = "Copy Image";
            this.copyImageToolStripMenuItem.Click += new System.EventHandler(this.copyImageToolStripMenuItem_Click);
            // 
            // SystemTrayMenu
            // 
            this.SystemTrayMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SystemTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextRefresh,
            this.ContextExit});
            this.SystemTrayMenu.Name = "contextMenuStrip1";
            this.SystemTrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SystemTrayMenu.Size = new System.Drawing.Size(114, 48);
            // 
            // ContextRefresh
            // 
            this.ContextRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.ContextRefresh.ForeColor = System.Drawing.Color.White;
            this.ContextRefresh.Name = "ContextRefresh";
            this.ContextRefresh.Size = new System.Drawing.Size(113, 22);
            this.ContextRefresh.Text = "Refresh";
            this.ContextRefresh.Click += new System.EventHandler(this.ContextRefresh_Click);
            // 
            // ContextExit
            // 
            this.ContextExit.ForeColor = System.Drawing.Color.White;
            this.ContextExit.Name = "ContextExit";
            this.ContextExit.Size = new System.Drawing.Size(113, 22);
            this.ContextExit.Text = "Exit";
            this.ContextExit.Click += new System.EventHandler(this.ContextExit_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Refreshbtn.Location = new System.Drawing.Point(237, 5);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(69, 23);
            this.Refreshbtn.TabIndex = 2;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorPreviewCanvas
            // 
            this.ColorPreviewCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ColorPreviewCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ColorPreviewCanvas.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ColorPreviewCanvas.Location = new System.Drawing.Point(12, 436);
            this.ColorPreviewCanvas.Name = "ColorPreviewCanvas";
            this.ColorPreviewCanvas.Size = new System.Drawing.Size(61, 60);
            this.ColorPreviewCanvas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "RGB:";
            // 
            // ColorDialogbtn
            // 
            this.ColorDialogbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorDialogbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorDialogbtn.Image = ((System.Drawing.Image)(resources.GetObject("ColorDialogbtn.Image")));
            this.ColorDialogbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColorDialogbtn.Location = new System.Drawing.Point(640, 86);
            this.ColorDialogbtn.Name = "ColorDialogbtn";
            this.ColorDialogbtn.Size = new System.Drawing.Size(58, 26);
            this.ColorDialogbtn.TabIndex = 6;
            this.ColorDialogbtn.Text = "Open";
            this.ColorDialogbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorDialogbtn.UseVisualStyleBackColor = true;
            this.ColorDialogbtn.Click += new System.EventHandler(this.ColorDialog_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(640, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(640, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dialog Field:";
            // 
            // CopyRgbCode
            // 
            this.CopyRgbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyRgbCode.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.CopyRgbCode.Image = global::Wizard_Color_Picker.Properties.Resources.icons8_copy_171;
            this.CopyRgbCode.Location = new System.Drawing.Point(221, 472);
            this.CopyRgbCode.Name = "CopyRgbCode";
            this.CopyRgbCode.Size = new System.Drawing.Size(43, 24);
            this.CopyRgbCode.TabIndex = 9;
            this.CopyRgbCode.UseVisualStyleBackColor = true;
            this.CopyRgbCode.Click += new System.EventHandler(this.CopyRgbCode_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "HEX:";
            // 
            // RGBCODE
            // 
            this.RGBCODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RGBCODE.Location = new System.Drawing.Point(120, 472);
            this.RGBCODE.Name = "RGBCODE";
            this.RGBCODE.PlaceholderText = "0, 0, 0";
            this.RGBCODE.Size = new System.Drawing.Size(95, 23);
            this.RGBCODE.TabIndex = 4;
            // 
            // HEXCodeBox
            // 
            this.HEXCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HEXCodeBox.Location = new System.Drawing.Point(120, 444);
            this.HEXCodeBox.Name = "HEXCodeBox";
            this.HEXCodeBox.PlaceholderText = "#000000";
            this.HEXCodeBox.Size = new System.Drawing.Size(95, 23);
            this.HEXCodeBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Click on the picture to identify the color:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ColorPictureBox);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 405);
            this.panel2.TabIndex = 14;
            // 
            // CloseApplication
            // 
            this.CloseApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CloseApplication.Location = new System.Drawing.Point(640, 471);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(75, 23);
            this.CloseApplication.TabIndex = 15;
            this.CloseApplication.Text = "Close";
            this.CloseApplication.UseVisualStyleBackColor = true;
            this.CloseApplication.Click += new System.EventHandler(this.RestartApplication_Click);
            // 
            // RCode
            // 
            this.RCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RCode.Location = new System.Drawing.Point(492, 5);
            this.RCode.Name = "RCode";
            this.RCode.Size = new System.Drawing.Size(30, 23);
            this.RCode.TabIndex = 18;
            // 
            // GCode
            // 
            this.GCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCode.Location = new System.Drawing.Point(542, 5);
            this.GCode.Name = "GCode";
            this.GCode.Size = new System.Drawing.Size(30, 23);
            this.GCode.TabIndex = 19;
            // 
            // BCode
            // 
            this.BCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCode.Location = new System.Drawing.Point(591, 5);
            this.BCode.Name = "BCode";
            this.BCode.Size = new System.Drawing.Size(30, 23);
            this.BCode.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "R:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "G:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(573, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "B:";
            // 
            // CopyHex
            // 
            this.CopyHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyHex.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.CopyHex.Image = global::Wizard_Color_Picker.Properties.Resources.icons8_copy_171;
            this.CopyHex.Location = new System.Drawing.Point(221, 444);
            this.CopyHex.Name = "CopyHex";
            this.CopyHex.Size = new System.Drawing.Size(43, 24);
            this.CopyHex.TabIndex = 24;
            this.CopyHex.UseVisualStyleBackColor = true;
            this.CopyHex.Click += new System.EventHandler(this.CopyHex_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::Wizard_Color_Picker.Properties.Resources.image_FILL0_wght400_GRAD0_opsz48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(640, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 26);
            this.button2.TabIndex = 26;
            this.button2.Text = "Import";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(640, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Open any";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(640, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "pictures:";
            // 
            // AppMsg
            // 
            this.AppMsg.ContextMenuStrip = this.SystemTrayMenu;
            this.AppMsg.Icon = ((System.Drawing.Icon)(resources.GetObject("AppMsg.Icon")));
            this.AppMsg.Text = "Quick Options";
            this.AppMsg.Visible = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(270, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Add images with drag and drop!";
            // 
            // colorlistbox
            // 
            this.colorlistbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorlistbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorlistbox.FormattingEnabled = true;
            this.colorlistbox.ItemHeight = 15;
            this.colorlistbox.Location = new System.Drawing.Point(640, 271);
            this.colorlistbox.Name = "colorlistbox";
            this.colorlistbox.Size = new System.Drawing.Size(69, 165);
            this.colorlistbox.TabIndex = 30;
            this.colorlistbox.SelectedIndexChanged += new System.EventHandler(this.colorlistbox_SelectedIndexChanged);
            // 
            // savecolorbtn
            // 
            this.savecolorbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savecolorbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savecolorbtn.Location = new System.Drawing.Point(562, 471);
            this.savecolorbtn.Name = "savecolorbtn";
            this.savecolorbtn.Size = new System.Drawing.Size(75, 23);
            this.savecolorbtn.TabIndex = 31;
            this.savecolorbtn.Text = "Save";
            this.savecolorbtn.UseVisualStyleBackColor = true;
            this.savecolorbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(640, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Saved Color:";
            // 
            // SelectedColorlbl
            // 
            this.SelectedColorlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedColorlbl.AutoSize = true;
            this.SelectedColorlbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedColorlbl.Location = new System.Drawing.Point(270, 480);
            this.SelectedColorlbl.Name = "SelectedColorlbl";
            this.SelectedColorlbl.Size = new System.Drawing.Size(145, 15);
            this.SelectedColorlbl.TabIndex = 35;
            this.SelectedColorlbl.Text = "RGB: 0, 0, 0   HEX: #000000";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Selected Color:";
            // 
            // ClearSavedColorbtn
            // 
            this.ClearSavedColorbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSavedColorbtn.Image = ((System.Drawing.Image)(resources.GetObject("ClearSavedColorbtn.Image")));
            this.ClearSavedColorbtn.Location = new System.Drawing.Point(640, 209);
            this.ClearSavedColorbtn.Name = "ClearSavedColorbtn";
            this.ClearSavedColorbtn.Size = new System.Drawing.Size(28, 27);
            this.ClearSavedColorbtn.TabIndex = 37;
            this.ClearSavedColorbtn.UseVisualStyleBackColor = true;
            this.ClearSavedColorbtn.Click += new System.EventHandler(this.ClearSavedColorbtn_Click);
            // 
            // pastepicturebtn
            // 
            this.pastepicturebtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pastepicturebtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pastepicturebtn.Location = new System.Drawing.Point(312, 5);
            this.pastepicturebtn.Name = "pastepicturebtn";
            this.pastepicturebtn.Size = new System.Drawing.Size(45, 23);
            this.pastepicturebtn.TabIndex = 45;
            this.pastepicturebtn.Text = "Paste";
            this.pastepicturebtn.UseVisualStyleBackColor = true;
            this.pastepicturebtn.Click += new System.EventHandler(this.pastepicturebtn_Click);
            // 
            // DelColorListbtn
            // 
            this.DelColorListbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelColorListbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DelColorListbtn.Location = new System.Drawing.Point(674, 209);
            this.DelColorListbtn.Name = "DelColorListbtn";
            this.DelColorListbtn.Size = new System.Drawing.Size(35, 27);
            this.DelColorListbtn.TabIndex = 46;
            this.DelColorListbtn.Text = "DEL";
            this.DelColorListbtn.UseVisualStyleBackColor = true;
            this.DelColorListbtn.Click += new System.EventHandler(this.DelColorListbtn_Click);
            // 
            // Settingsbtn
            // 
            this.Settingsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Settingsbtn.Location = new System.Drawing.Point(640, 5);
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.Size = new System.Drawing.Size(69, 26);
            this.Settingsbtn.TabIndex = 47;
            this.Settingsbtn.Text = "Settings";
            this.Settingsbtn.UseVisualStyleBackColor = true;
            this.Settingsbtn.Click += new System.EventHandler(this.Settingsbtn_Click);
            // 
            // AppVersionlbl
            // 
            this.AppVersionlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AppVersionlbl.AutoSize = true;
            this.AppVersionlbl.Location = new System.Drawing.Point(612, 453);
            this.AppVersionlbl.Name = "AppVersionlbl";
            this.AppVersionlbl.Size = new System.Drawing.Size(103, 15);
            this.AppVersionlbl.TabIndex = 48;
            this.AppVersionlbl.Text = "App Version v1.0.4";
            // 
            // ColorPickerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 506);
            this.Controls.Add(this.AppVersionlbl);
            this.Controls.Add(this.Settingsbtn);
            this.Controls.Add(this.DelColorListbtn);
            this.Controls.Add(this.pastepicturebtn);
            this.Controls.Add(this.ClearSavedColorbtn);
            this.Controls.Add(this.SelectedColorlbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savecolorbtn);
            this.Controls.Add(this.colorlistbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CopyHex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ColorPreviewCanvas);
            this.Controls.Add(this.GCode);
            this.Controls.Add(this.CloseApplication);
            this.Controls.Add(this.BCode);
            this.Controls.Add(this.RGBCODE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CopyRgbCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColorDialogbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.HEXCodeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(643, 454);
            this.Name = "ColorPickerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard Color Picker  |  Start";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
            this.PictureMenu.ResumeLayout(false);
            this.SystemTrayMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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