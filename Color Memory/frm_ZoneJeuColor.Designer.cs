namespace Color_Memory
{
    partial class frm_ZoneJeuColor
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
            this.components = new System.ComponentModel.Container();
            this.timerCouleurControl = new System.Windows.Forms.Timer(this.components);
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblCompteARebours = new System.Windows.Forms.Label();
            this.timerCompteArebours = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUtilisateur = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIntervalTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.panelUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCouleurControl
            // 
            this.timerCouleurControl.Interval = 1000;
            this.timerCouleurControl.Tick += new System.EventHandler(this.timerCouleurControl_Tick);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.lblIntroduction.Font = new System.Drawing.Font("Gill Sans Nova Cond", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.ForeColor = System.Drawing.Color.White;
            this.lblIntroduction.Location = new System.Drawing.Point(125, 141);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(732, 292);
            this.lblIntroduction.TabIndex = 0;
            this.lblIntroduction.Text = "Welcome to Color Memory";
            this.lblIntroduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::Color_Memory.Properties.Resources.button_close;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Location = new System.Drawing.Point(907, 486);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(63, 63);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblCompteARebours
            // 
            this.lblCompteARebours.AutoSize = true;
            this.lblCompteARebours.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompteARebours.Location = new System.Drawing.Point(430, 194);
            this.lblCompteARebours.Name = "lblCompteARebours";
            this.lblCompteARebours.Size = new System.Drawing.Size(155, 170);
            this.lblCompteARebours.TabIndex = 12;
            this.lblCompteARebours.Text = "3";
            // 
            // timerCompteArebours
            // 
            this.timerCompteArebours.Interval = 1000;
            this.timerCompteArebours.Tick += new System.EventHandler(this.timerCompteArebours_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(141)))));
            this.lblScore.Location = new System.Drawing.Point(904, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(23, 25);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "0";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Orange;
            this.lblLevel.Location = new System.Drawing.Point(93, 30);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 29);
            this.lblLevel.TabIndex = 14;
            this.lblLevel.Text = "Easy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Level : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(818, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Score : ";
            // 
            // panelUtilisateur
            // 
            this.panelUtilisateur.BackColor = System.Drawing.Color.White;
            this.panelUtilisateur.Controls.Add(this.btnReplay);
            this.panelUtilisateur.Controls.Add(this.label5);
            this.panelUtilisateur.Controls.Add(this.lblIntervalTimer);
            this.panelUtilisateur.Controls.Add(this.label3);
            this.panelUtilisateur.Controls.Add(this.label1);
            this.panelUtilisateur.Controls.Add(this.lblScore);
            this.panelUtilisateur.Controls.Add(this.label2);
            this.panelUtilisateur.Controls.Add(this.lblLevel);
            this.panelUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.panelUtilisateur.Name = "panelUtilisateur";
            this.panelUtilisateur.Size = new System.Drawing.Size(982, 94);
            this.panelUtilisateur.TabIndex = 18;
            this.panelUtilisateur.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(540, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Replay :";
            // 
            // lblIntervalTimer
            // 
            this.lblIntervalTimer.AutoSize = true;
            this.lblIntervalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(141)))));
            this.lblIntervalTimer.Location = new System.Drawing.Point(400, 34);
            this.lblIntervalTimer.Name = "lblIntervalTimer";
            this.lblIntervalTimer.Size = new System.Drawing.Size(56, 25);
            this.lblIntervalTimer.TabIndex = 19;
            this.lblIntervalTimer.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(253, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Interval Timer :";
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.Red;
            this.btnReplay.Enabled = false;
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.ForeColor = System.Drawing.Color.White;
            this.btnReplay.Location = new System.Drawing.Point(629, 30);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(85, 34);
            this.btnReplay.TabIndex = 21;
            this.btnReplay.Tag = "no";
            this.btnReplay.Text = "NO";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // frm_ZoneJeuColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(982, 561);
            this.Controls.Add(this.panelUtilisateur);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.lblCompteARebours);
            this.Controls.Add(this.btnQuitter);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ZoneJeuColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelUtilisateur.ResumeLayout(false);
            this.panelUtilisateur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCouleurControl;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblCompteARebours;
        private System.Windows.Forms.Timer timerCompteArebours;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUtilisateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIntervalTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReplay;
    }
}

