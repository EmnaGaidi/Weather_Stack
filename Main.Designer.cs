namespace WeatherStack
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nb_temperature = new System.Windows.Forms.Label();
            this.lb_temprerature = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nb_wind = new System.Windows.Forms.Label();
            this.lb_speed = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nb_humidity = new System.Windows.Forms.Label();
            this.lb_humidity = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "WeatherS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Location";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lb_description);
            this.panel2.Controls.Add(this.lb_city);
            this.panel2.Location = new System.Drawing.Point(283, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 362);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 210);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(177, 310);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(157, 32);
            this.lb_description.TabIndex = 1;
            this.lb_description.Text = "Description";
            this.lb_description.Click += new System.EventHandler(this.lb_description_Click);
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Location = new System.Drawing.Point(177, 30);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(145, 32);
            this.lb_city.TabIndex = 0;
            this.lb_city.Text = "City Name";
            this.lb_city.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nb_temperature);
            this.panel3.Controls.Add(this.lb_temprerature);
            this.panel3.Location = new System.Drawing.Point(0, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 166);
            this.panel3.TabIndex = 2;
            // 
            // nb_temperature
            // 
            this.nb_temperature.AutoSize = true;
            this.nb_temperature.Location = new System.Drawing.Point(73, 95);
            this.nb_temperature.Name = "nb_temperature";
            this.nb_temperature.Size = new System.Drawing.Size(46, 32);
            this.nb_temperature.TabIndex = 1;
            this.nb_temperature.Text = "35";
            this.nb_temperature.Click += new System.EventHandler(this.nb_temperature_Click);
            // 
            // lb_temprerature
            // 
            this.lb_temprerature.AutoSize = true;
            this.lb_temprerature.Location = new System.Drawing.Point(12, 21);
            this.lb_temprerature.Name = "lb_temprerature";
            this.lb_temprerature.Size = new System.Drawing.Size(176, 32);
            this.lb_temprerature.TabIndex = 0;
            this.lb_temprerature.Text = "Temperature";
            this.lb_temprerature.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nb_wind);
            this.panel4.Controls.Add(this.lb_speed);
            this.panel4.Location = new System.Drawing.Point(417, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 166);
            this.panel4.TabIndex = 3;
            // 
            // nb_wind
            // 
            this.nb_wind.AutoSize = true;
            this.nb_wind.Location = new System.Drawing.Point(81, 95);
            this.nb_wind.Name = "nb_wind";
            this.nb_wind.Size = new System.Drawing.Size(46, 32);
            this.nb_wind.TabIndex = 2;
            this.nb_wind.Text = "35";
            this.nb_wind.Click += new System.EventHandler(this.nb_wind_Click);
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Location = new System.Drawing.Point(20, 21);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(169, 32);
            this.lb_speed.TabIndex = 1;
            this.lb_speed.Text = "Wind Speed";
            this.lb_speed.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nb_humidity);
            this.panel5.Controls.Add(this.lb_humidity);
            this.panel5.Location = new System.Drawing.Point(941, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 166);
            this.panel5.TabIndex = 4;
            // 
            // nb_humidity
            // 
            this.nb_humidity.AutoSize = true;
            this.nb_humidity.Location = new System.Drawing.Point(82, 95);
            this.nb_humidity.Name = "nb_humidity";
            this.nb_humidity.Size = new System.Drawing.Size(46, 32);
            this.nb_humidity.TabIndex = 2;
            this.nb_humidity.Text = "35";
            this.nb_humidity.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_humidity
            // 
            this.lb_humidity.AutoSize = true;
            this.lb_humidity.Location = new System.Drawing.Point(39, 21);
            this.lb_humidity.Name = "lb_humidity";
            this.lb_humidity.Size = new System.Drawing.Size(125, 32);
            this.lb_humidity.TabIndex = 1;
            this.lb_humidity.Text = "Humidity";
            this.lb_humidity.Click += new System.EventHandler(this.lb_humidity_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(1054, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(897, 280);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(148, 45);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 616);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nb_temperature;
        private System.Windows.Forms.Label lb_temprerature;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label nb_wind;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.Label nb_humidity;
        private System.Windows.Forms.Label lb_humidity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_refresh;
    }
}

