namespace Wizard_Color_Picker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CopyRgbCode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RGBCODE = new System.Windows.Forms.TextBox();
            this.HEXCodeBox = new System.Windows.Forms.TextBox();
            this.CopyHex = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RCode = new System.Windows.Forms.TextBox();
            this.GCode = new System.Windows.Forms.TextBox();
            this.BCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(369, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "RGB: 0, 0, 0   HEX: #000000";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(237, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel1.Location = new System.Drawing.Point(12, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 60);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "RGB:";
            // 
            // ColorDialog
            // 
            this.ColorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColorDialog.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorDialog.Location = new System.Drawing.Point(676, 86);
            this.ColorDialog.Name = "ColorDialog";
            this.ColorDialog.Size = new System.Drawing.Size(31, 23);
            this.ColorDialog.TabIndex = 6;
            this.ColorDialog.Text = "∧";
            this.ColorDialog.UseVisualStyleBackColor = true;
            this.ColorDialog.Click += new System.EventHandler(this.ColorDialog_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(676, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(676, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dialog Field:";
            // 
            // CopyRgbCode
            // 
            this.CopyRgbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyRgbCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CopyRgbCode.Location = new System.Drawing.Point(221, 484);
            this.CopyRgbCode.Name = "CopyRgbCode";
            this.CopyRgbCode.Size = new System.Drawing.Size(60, 23);
            this.CopyRgbCode.TabIndex = 9;
            this.CopyRgbCode.Text = "Copy";
            this.CopyRgbCode.UseVisualStyleBackColor = true;
            this.CopyRgbCode.Click += new System.EventHandler(this.CopyRgbCode_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "HEX:";
            // 
            // RGBCODE
            // 
            this.RGBCODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RGBCODE.Location = new System.Drawing.Point(120, 484);
            this.RGBCODE.Name = "RGBCODE";
            this.RGBCODE.PlaceholderText = "0, 0, 0";
            this.RGBCODE.Size = new System.Drawing.Size(95, 23);
            this.RGBCODE.TabIndex = 4;
            // 
            // HEXCodeBox
            // 
            this.HEXCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HEXCodeBox.Location = new System.Drawing.Point(120, 456);
            this.HEXCodeBox.Name = "HEXCodeBox";
            this.HEXCodeBox.PlaceholderText = "#000000";
            this.HEXCodeBox.Size = new System.Drawing.Size(95, 23);
            this.HEXCodeBox.TabIndex = 11;
            // 
            // CopyHex
            // 
            this.CopyHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CopyHex.Location = new System.Drawing.Point(221, 457);
            this.CopyHex.Name = "CopyHex";
            this.CopyHex.Size = new System.Drawing.Size(60, 23);
            this.CopyHex.TabIndex = 12;
            this.CopyHex.Text = "Copy";
            this.CopyHex.UseVisualStyleBackColor = true;
            this.CopyHex.Click += new System.EventHandler(this.CopyHex_Click);
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 416);
            this.panel2.TabIndex = 14;
            // 
            // CloseApplication
            // 
            this.CloseApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CloseApplication.Location = new System.Drawing.Point(676, 485);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(75, 23);
            this.CloseApplication.TabIndex = 15;
            this.CloseApplication.Text = "Close";
            this.CloseApplication.UseVisualStyleBackColor = true;
            this.CloseApplication.Click += new System.EventHandler(this.RestartApplication_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Selected Color:";
            // 
            // RCode
            // 
            this.RCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RCode.Location = new System.Drawing.Point(518, 5);
            this.RCode.Name = "RCode";
            this.RCode.Size = new System.Drawing.Size(30, 23);
            this.RCode.TabIndex = 18;
            // 
            // GCode
            // 
            this.GCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCode.Location = new System.Drawing.Point(572, 5);
            this.GCode.Name = "GCode";
            this.GCode.Size = new System.Drawing.Size(30, 23);
            this.GCode.TabIndex = 19;
            // 
            // BCode
            // 
            this.BCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCode.Location = new System.Drawing.Point(627, 5);
            this.BCode.Name = "BCode";
            this.BCode.Size = new System.Drawing.Size(30, 23);
            this.BCode.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "R:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "G:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GCode);
            this.Controls.Add(this.CloseApplication);
            this.Controls.Add(this.BCode);
            this.Controls.Add(this.RGBCODE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CopyRgbCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColorDialog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HEXCodeBox);
            this.Controls.Add(this.CopyHex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Button ColorDialog;
        private Label label3;
        private Label label4;
        private Button CopyRgbCode;
        private Label label5;
        private TextBox RGBCODE;
        private TextBox HEXCodeBox;
        private Button CopyHex;
        private Label label6;
        private Panel panel2;
        private Button CloseApplication;
        private Label label7;
        private TextBox RCode;
        private TextBox GCode;
        private TextBox BCode;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}