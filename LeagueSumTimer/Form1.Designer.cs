namespace LeagueSumTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClipboard = new System.Windows.Forms.Button();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.btnTop30 = new System.Windows.Forms.Button();
            this.checkBoxTopBoot = new System.Windows.Forms.CheckBox();
            this.checkBoxTopIns = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSupFlash = new System.Windows.Forms.Button();
            this.btnBotFlash = new System.Windows.Forms.Button();
            this.btnMidFlash = new System.Windows.Forms.Button();
            this.btnJugFlash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTopFlash = new System.Windows.Forms.Button();
            this.checkBoxJugBoot = new System.Windows.Forms.CheckBox();
            this.btnJug30 = new System.Windows.Forms.Button();
            this.btnJug10 = new System.Windows.Forms.Button();
            this.checkBoxJugIns = new System.Windows.Forms.CheckBox();
            this.checkBoxMidBoot = new System.Windows.Forms.CheckBox();
            this.btnMid30 = new System.Windows.Forms.Button();
            this.btnMid10 = new System.Windows.Forms.Button();
            this.checkBoxMidIns = new System.Windows.Forms.CheckBox();
            this.checkBoxBotBoot = new System.Windows.Forms.CheckBox();
            this.btnBot30 = new System.Windows.Forms.Button();
            this.btnBot10 = new System.Windows.Forms.Button();
            this.checkBoxBotIns = new System.Windows.Forms.CheckBox();
            this.checkBoxSupBoot = new System.Windows.Forms.CheckBox();
            this.btnSup30 = new System.Windows.Forms.Button();
            this.btnSup10 = new System.Windows.Forms.Button();
            this.checkBoxSupIns = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(42, 411);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(162, 23);
            this.btnClipboard.TabIndex = 4;
            this.btnClipboard.Text = "Copy info to clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.Location = new System.Drawing.Point(156, 6);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(48, 28);
            this.btnTop10.TabIndex = 14;
            this.btnTop10.Text = "-10s";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTopFlash_Click);
            // 
            // btnTop30
            // 
            this.btnTop30.Location = new System.Drawing.Point(156, 43);
            this.btnTop30.Name = "btnTop30";
            this.btnTop30.Size = new System.Drawing.Size(48, 28);
            this.btnTop30.TabIndex = 16;
            this.btnTop30.Text = "-30s";
            this.btnTop30.UseVisualStyleBackColor = true;
            this.btnTop30.Click += new System.EventHandler(this.btnTopFlash_Click);
            // 
            // checkBoxTopBoot
            // 
            this.checkBoxTopBoot.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Boots;
            this.checkBoxTopBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxTopBoot.Location = new System.Drawing.Point(207, 6);
            this.checkBoxTopBoot.Name = "checkBoxTopBoot";
            this.checkBoxTopBoot.Size = new System.Drawing.Size(62, 31);
            this.checkBoxTopBoot.TabIndex = 17;
            this.checkBoxTopBoot.UseVisualStyleBackColor = true;
            this.checkBoxTopBoot.CheckedChanged += new System.EventHandler(this.checkBoxTop_CheckedChanged);
            // 
            // checkBoxTopIns
            // 
            this.checkBoxTopIns.BackgroundImage = global::LeagueSumTimer.Properties.Resources.CosmicInsight;
            this.checkBoxTopIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxTopIns.Location = new System.Drawing.Point(207, 40);
            this.checkBoxTopIns.Name = "checkBoxTopIns";
            this.checkBoxTopIns.Size = new System.Drawing.Size(62, 31);
            this.checkBoxTopIns.TabIndex = 13;
            this.checkBoxTopIns.UseVisualStyleBackColor = true;
            this.checkBoxTopIns.CheckedChanged += new System.EventHandler(this.checkBoxTop_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LeagueSumTimer.Properties.Resources.SUPPORT;
            this.pictureBox5.Location = new System.Drawing.Point(6, 323);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LeagueSumTimer.Properties.Resources.ADC;
            this.pictureBox4.Location = new System.Drawing.Point(6, 245);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LeagueSumTimer.Properties.Resources.MIDDLE;
            this.pictureBox3.Location = new System.Drawing.Point(6, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LeagueSumTimer.Properties.Resources.JUNGLE;
            this.pictureBox2.Location = new System.Drawing.Point(6, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnSupFlash
            // 
            this.btnSupFlash.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Flash;
            this.btnSupFlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupFlash.FlatAppearance.BorderSize = 0;
            this.btnSupFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupFlash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupFlash.Location = new System.Drawing.Point(81, 323);
            this.btnSupFlash.Margin = new System.Windows.Forms.Padding(0);
            this.btnSupFlash.Name = "btnSupFlash";
            this.btnSupFlash.Size = new System.Drawing.Size(64, 64);
            this.btnSupFlash.TabIndex = 8;
            this.btnSupFlash.UseVisualStyleBackColor = true;
            this.btnSupFlash.Click += new System.EventHandler(this.btnSupFlash_Click);
            // 
            // btnBotFlash
            // 
            this.btnBotFlash.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Flash;
            this.btnBotFlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBotFlash.FlatAppearance.BorderSize = 0;
            this.btnBotFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotFlash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBotFlash.Location = new System.Drawing.Point(81, 245);
            this.btnBotFlash.Margin = new System.Windows.Forms.Padding(0);
            this.btnBotFlash.Name = "btnBotFlash";
            this.btnBotFlash.Size = new System.Drawing.Size(64, 64);
            this.btnBotFlash.TabIndex = 7;
            this.btnBotFlash.UseVisualStyleBackColor = true;
            this.btnBotFlash.Click += new System.EventHandler(this.btnBotFlash_Click);
            // 
            // btnMidFlash
            // 
            this.btnMidFlash.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Flash;
            this.btnMidFlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMidFlash.FlatAppearance.BorderSize = 0;
            this.btnMidFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMidFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMidFlash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMidFlash.Location = new System.Drawing.Point(81, 165);
            this.btnMidFlash.Margin = new System.Windows.Forms.Padding(0);
            this.btnMidFlash.Name = "btnMidFlash";
            this.btnMidFlash.Size = new System.Drawing.Size(64, 64);
            this.btnMidFlash.TabIndex = 6;
            this.btnMidFlash.UseVisualStyleBackColor = true;
            this.btnMidFlash.Click += new System.EventHandler(this.btnMidFlash_Click);
            // 
            // btnJugFlash
            // 
            this.btnJugFlash.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Flash;
            this.btnJugFlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJugFlash.FlatAppearance.BorderSize = 0;
            this.btnJugFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugFlash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJugFlash.Location = new System.Drawing.Point(81, 86);
            this.btnJugFlash.Margin = new System.Windows.Forms.Padding(0);
            this.btnJugFlash.Name = "btnJugFlash";
            this.btnJugFlash.Size = new System.Drawing.Size(64, 64);
            this.btnJugFlash.TabIndex = 5;
            this.btnJugFlash.UseVisualStyleBackColor = true;
            this.btnJugFlash.Click += new System.EventHandler(this.btnJugFlash_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LeagueSumTimer.Properties.Resources.TOP;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnTopFlash
            // 
            this.btnTopFlash.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Flash;
            this.btnTopFlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTopFlash.FlatAppearance.BorderSize = 0;
            this.btnTopFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopFlash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTopFlash.Location = new System.Drawing.Point(81, 6);
            this.btnTopFlash.Margin = new System.Windows.Forms.Padding(0);
            this.btnTopFlash.Name = "btnTopFlash";
            this.btnTopFlash.Size = new System.Drawing.Size(64, 64);
            this.btnTopFlash.TabIndex = 1;
            this.btnTopFlash.UseVisualStyleBackColor = true;
            this.btnTopFlash.Click += new System.EventHandler(this.btnTopFlash_Click);
            // 
            // checkBoxJugBoot
            // 
            this.checkBoxJugBoot.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Boots;
            this.checkBoxJugBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxJugBoot.Location = new System.Drawing.Point(207, 86);
            this.checkBoxJugBoot.Name = "checkBoxJugBoot";
            this.checkBoxJugBoot.Size = new System.Drawing.Size(62, 31);
            this.checkBoxJugBoot.TabIndex = 21;
            this.checkBoxJugBoot.UseVisualStyleBackColor = true;
            this.checkBoxJugBoot.CheckedChanged += new System.EventHandler(this.checkBoxJug_CheckedChanged);
            // 
            // btnJug30
            // 
            this.btnJug30.Location = new System.Drawing.Point(156, 123);
            this.btnJug30.Name = "btnJug30";
            this.btnJug30.Size = new System.Drawing.Size(48, 28);
            this.btnJug30.TabIndex = 20;
            this.btnJug30.Text = "-30s";
            this.btnJug30.UseVisualStyleBackColor = true;
            this.btnJug30.Click += new System.EventHandler(this.btnJugFlash_Click);
            // 
            // btnJug10
            // 
            this.btnJug10.Location = new System.Drawing.Point(156, 86);
            this.btnJug10.Name = "btnJug10";
            this.btnJug10.Size = new System.Drawing.Size(48, 28);
            this.btnJug10.TabIndex = 19;
            this.btnJug10.Text = "-10s";
            this.btnJug10.UseVisualStyleBackColor = true;
            this.btnJug10.Click += new System.EventHandler(this.btnJugFlash_Click);
            // 
            // checkBoxJugIns
            // 
            this.checkBoxJugIns.BackgroundImage = global::LeagueSumTimer.Properties.Resources.CosmicInsight;
            this.checkBoxJugIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxJugIns.Location = new System.Drawing.Point(207, 120);
            this.checkBoxJugIns.Name = "checkBoxJugIns";
            this.checkBoxJugIns.Size = new System.Drawing.Size(62, 31);
            this.checkBoxJugIns.TabIndex = 18;
            this.checkBoxJugIns.UseVisualStyleBackColor = true;
            this.checkBoxJugIns.CheckedChanged += new System.EventHandler(this.checkBoxJug_CheckedChanged);
            // 
            // checkBoxMidBoot
            // 
            this.checkBoxMidBoot.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Boots;
            this.checkBoxMidBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxMidBoot.Location = new System.Drawing.Point(207, 164);
            this.checkBoxMidBoot.Name = "checkBoxMidBoot";
            this.checkBoxMidBoot.Size = new System.Drawing.Size(62, 31);
            this.checkBoxMidBoot.TabIndex = 25;
            this.checkBoxMidBoot.UseVisualStyleBackColor = true;
            this.checkBoxMidBoot.CheckedChanged += new System.EventHandler(this.checkBoxMid_CheckedChanged);
            // 
            // btnMid30
            // 
            this.btnMid30.Location = new System.Drawing.Point(156, 201);
            this.btnMid30.Name = "btnMid30";
            this.btnMid30.Size = new System.Drawing.Size(48, 28);
            this.btnMid30.TabIndex = 24;
            this.btnMid30.Text = "-30s";
            this.btnMid30.UseVisualStyleBackColor = true;
            this.btnMid30.Click += new System.EventHandler(this.btnMidFlash_Click);
            // 
            // btnMid10
            // 
            this.btnMid10.Location = new System.Drawing.Point(156, 164);
            this.btnMid10.Name = "btnMid10";
            this.btnMid10.Size = new System.Drawing.Size(48, 28);
            this.btnMid10.TabIndex = 23;
            this.btnMid10.Text = "-10s";
            this.btnMid10.UseVisualStyleBackColor = true;
            this.btnMid10.Click += new System.EventHandler(this.btnMidFlash_Click);
            // 
            // checkBoxMidIns
            // 
            this.checkBoxMidIns.BackgroundImage = global::LeagueSumTimer.Properties.Resources.CosmicInsight;
            this.checkBoxMidIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxMidIns.Location = new System.Drawing.Point(207, 198);
            this.checkBoxMidIns.Name = "checkBoxMidIns";
            this.checkBoxMidIns.Size = new System.Drawing.Size(62, 31);
            this.checkBoxMidIns.TabIndex = 22;
            this.checkBoxMidIns.UseVisualStyleBackColor = true;
            this.checkBoxMidIns.CheckedChanged += new System.EventHandler(this.checkBoxMid_CheckedChanged);
            // 
            // checkBoxBotBoot
            // 
            this.checkBoxBotBoot.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Boots;
            this.checkBoxBotBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxBotBoot.Location = new System.Drawing.Point(207, 245);
            this.checkBoxBotBoot.Name = "checkBoxBotBoot";
            this.checkBoxBotBoot.Size = new System.Drawing.Size(62, 31);
            this.checkBoxBotBoot.TabIndex = 29;
            this.checkBoxBotBoot.UseVisualStyleBackColor = true;
            this.checkBoxBotBoot.CheckedChanged += new System.EventHandler(this.checkBoxBot_CheckedChanged);
            // 
            // btnBot30
            // 
            this.btnBot30.Location = new System.Drawing.Point(156, 282);
            this.btnBot30.Name = "btnBot30";
            this.btnBot30.Size = new System.Drawing.Size(48, 28);
            this.btnBot30.TabIndex = 28;
            this.btnBot30.Text = "-30s";
            this.btnBot30.UseVisualStyleBackColor = true;
            this.btnBot30.Click += new System.EventHandler(this.btnBotFlash_Click);
            // 
            // btnBot10
            // 
            this.btnBot10.Location = new System.Drawing.Point(156, 245);
            this.btnBot10.Name = "btnBot10";
            this.btnBot10.Size = new System.Drawing.Size(48, 28);
            this.btnBot10.TabIndex = 27;
            this.btnBot10.Text = "-10s";
            this.btnBot10.UseVisualStyleBackColor = true;
            this.btnBot10.Click += new System.EventHandler(this.btnBotFlash_Click);
            // 
            // checkBoxBotIns
            // 
            this.checkBoxBotIns.BackgroundImage = global::LeagueSumTimer.Properties.Resources.CosmicInsight;
            this.checkBoxBotIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxBotIns.Location = new System.Drawing.Point(207, 279);
            this.checkBoxBotIns.Name = "checkBoxBotIns";
            this.checkBoxBotIns.Size = new System.Drawing.Size(62, 31);
            this.checkBoxBotIns.TabIndex = 26;
            this.checkBoxBotIns.UseVisualStyleBackColor = true;
            this.checkBoxBotIns.CheckedChanged += new System.EventHandler(this.checkBoxBot_CheckedChanged);
            // 
            // checkBoxSupBoot
            // 
            this.checkBoxSupBoot.BackgroundImage = global::LeagueSumTimer.Properties.Resources.Boots;
            this.checkBoxSupBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxSupBoot.Location = new System.Drawing.Point(207, 323);
            this.checkBoxSupBoot.Name = "checkBoxSupBoot";
            this.checkBoxSupBoot.Size = new System.Drawing.Size(62, 31);
            this.checkBoxSupBoot.TabIndex = 33;
            this.checkBoxSupBoot.UseVisualStyleBackColor = true;
            this.checkBoxSupBoot.CheckedChanged += new System.EventHandler(this.checkBoxSup_CheckedChanged);
            // 
            // btnSup30
            // 
            this.btnSup30.Location = new System.Drawing.Point(156, 360);
            this.btnSup30.Name = "btnSup30";
            this.btnSup30.Size = new System.Drawing.Size(48, 28);
            this.btnSup30.TabIndex = 32;
            this.btnSup30.Text = "-30s";
            this.btnSup30.UseVisualStyleBackColor = true;
            this.btnSup30.Click += new System.EventHandler(this.btnSupFlash_Click);
            // 
            // btnSup10
            // 
            this.btnSup10.Location = new System.Drawing.Point(156, 323);
            this.btnSup10.Name = "btnSup10";
            this.btnSup10.Size = new System.Drawing.Size(48, 28);
            this.btnSup10.TabIndex = 31;
            this.btnSup10.Text = "-10s";
            this.btnSup10.UseVisualStyleBackColor = true;
            this.btnSup10.Click += new System.EventHandler(this.btnSupFlash_Click);
            // 
            // checkBoxSupIns
            // 
            this.checkBoxSupIns.BackgroundImage = global::LeagueSumTimer.Properties.Resources.CosmicInsight;
            this.checkBoxSupIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxSupIns.Location = new System.Drawing.Point(207, 357);
            this.checkBoxSupIns.Name = "checkBoxSupIns";
            this.checkBoxSupIns.Size = new System.Drawing.Size(62, 31);
            this.checkBoxSupIns.TabIndex = 30;
            this.checkBoxSupIns.UseVisualStyleBackColor = true;
            this.checkBoxSupIns.CheckedChanged += new System.EventHandler(this.checkBoxSup_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(263, 445);
            this.Controls.Add(this.checkBoxSupBoot);
            this.Controls.Add(this.btnSup30);
            this.Controls.Add(this.btnSup10);
            this.Controls.Add(this.checkBoxSupIns);
            this.Controls.Add(this.checkBoxBotBoot);
            this.Controls.Add(this.btnBot30);
            this.Controls.Add(this.btnBot10);
            this.Controls.Add(this.checkBoxBotIns);
            this.Controls.Add(this.checkBoxMidBoot);
            this.Controls.Add(this.btnMid30);
            this.Controls.Add(this.btnMid10);
            this.Controls.Add(this.checkBoxMidIns);
            this.Controls.Add(this.checkBoxJugBoot);
            this.Controls.Add(this.btnJug30);
            this.Controls.Add(this.btnJug10);
            this.Controls.Add(this.checkBoxJugIns);
            this.Controls.Add(this.checkBoxTopBoot);
            this.Controls.Add(this.btnTop30);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.checkBoxTopIns);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSupFlash);
            this.Controls.Add(this.btnBotFlash);
            this.Controls.Add(this.btnMidFlash);
            this.Controls.Add(this.btnJugFlash);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTopFlash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTopFlash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Button btnJugFlash;
        private System.Windows.Forms.Button btnMidFlash;
        private System.Windows.Forms.Button btnBotFlash;
        private System.Windows.Forms.Button btnSupFlash;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox checkBoxTopIns;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Button btnTop30;
        private System.Windows.Forms.CheckBox checkBoxTopBoot;
        private System.Windows.Forms.CheckBox checkBoxJugBoot;
        private System.Windows.Forms.Button btnJug30;
        private System.Windows.Forms.Button btnJug10;
        private System.Windows.Forms.CheckBox checkBoxJugIns;
        private System.Windows.Forms.CheckBox checkBoxMidBoot;
        private System.Windows.Forms.Button btnMid30;
        private System.Windows.Forms.Button btnMid10;
        private System.Windows.Forms.CheckBox checkBoxMidIns;
        private System.Windows.Forms.CheckBox checkBoxBotBoot;
        private System.Windows.Forms.Button btnBot30;
        private System.Windows.Forms.Button btnBot10;
        private System.Windows.Forms.CheckBox checkBoxBotIns;
        private System.Windows.Forms.CheckBox checkBoxSupBoot;
        private System.Windows.Forms.Button btnSup30;
        private System.Windows.Forms.Button btnSup10;
        private System.Windows.Forms.CheckBox checkBoxSupIns;
    }
}

