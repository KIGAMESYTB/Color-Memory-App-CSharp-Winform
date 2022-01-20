namespace Color_Memory
{
    partial class frm_Accueil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accueil));
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelBienvenue = new System.Windows.Forms.Panel();
            this.lblPrésente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelBienvenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Gill Sans Nova Cond", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.MistyRose;
            this.lblColor.Location = new System.Drawing.Point(7, -6);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(279, 130);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "COLOR";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.BackColor = System.Drawing.Color.Transparent;
            this.lblMemory.Font = new System.Drawing.Font("Gill Sans Nova Cond", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.ForeColor = System.Drawing.Color.Sienna;
            this.lblMemory.Location = new System.Drawing.Point(271, -6);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(345, 130);
            this.lblMemory.TabIndex = 4;
            this.lblMemory.Text = "MEMORY";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Gill Sans Nova Cond", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.MistyRose;
            this.btnStart.Location = new System.Drawing.Point(444, 472);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 75);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.buttonClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Color_Memory.Properties.Resources.logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(149, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(334, 311);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.BorderSize = 2;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Gill Sans Nova Cond", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Red;
            this.btnQuitter.Location = new System.Drawing.Point(12, 472);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(163, 75);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "LEFT";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.buttonClick);
            // 
            // panelBienvenue
            // 
            this.panelBienvenue.BackColor = System.Drawing.Color.Black;
            this.panelBienvenue.Controls.Add(this.lblPrésente);
            this.panelBienvenue.Controls.Add(this.label3);
            this.panelBienvenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBienvenue.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenue.Name = "panelBienvenue";
            this.panelBienvenue.Size = new System.Drawing.Size(628, 561);
            this.panelBienvenue.TabIndex = 16;
            // 
            // lblPrésente
            // 
            this.lblPrésente.Font = new System.Drawing.Font("Rockwell Nova Cond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrésente.ForeColor = System.Drawing.Color.White;
            this.lblPrésente.Location = new System.Drawing.Point(85, 319);
            this.lblPrésente.Name = "lblPrésente";
            this.lblPrésente.Size = new System.Drawing.Size(469, 73);
            this.lblPrésente.TabIndex = 1;
            this.lblPrésente.Text = "Presents";
            this.lblPrésente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell Nova Cond", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 119);
            this.label3.TabIndex = 0;
            this.label3.Text = "KIGAMES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(141)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 561);
            this.Controls.Add(this.panelBienvenue);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.lblColor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelBienvenue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panelBienvenue;
        private System.Windows.Forms.Label lblPrésente;
        private System.Windows.Forms.Label label3;
    }
}