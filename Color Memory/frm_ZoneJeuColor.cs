using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Memory
{
    public partial class frm_ZoneJeuColor : Form
    {
        #region Variable

        TableLayoutPanel table;
        Random random;
        List<Control> ListecontrolCheminOrdinateur; 
        List<Color> ListecouleurControl;
        List<String> ListeinstructionBienvenue;
        int countNameBtn;
        int count;
        int nbTourToLevel;
        int nbLevelToTour;
        int nbColRow;
        int tempsCompteARebours;
        int countIntroduction;
        int score;
        string level = "Easy";

        #endregion

        public frm_ZoneJeuColor()
        {
            InitializeComponent();
            random = new Random();
            ListecontrolCheminOrdinateur = new List<Control>();
            ListecouleurControl = new List<Color>();
            ListeinstructionBienvenue = new List<string>() { "Will you find the color path?", "The game starts in" }; 
            countNameBtn = 0;
            count = 0;
            nbColRow = 3;
            score = 0;
            nbLevelToTour = 0;
            nbTourToLevel = 3;
            countIntroduction = 0;
            tempsCompteARebours = 7;
            table = CreationTableLayoutPanel(nbColRow);
            timerCompteArebours.Start();
            
        }

        /// <summary>
        /// Initialisation de la partie
        /// </summary>
        private void initialisation()
        {
            replay();
            count = 0;
            this.Controls.Remove(table);
            table = CreationTableLayoutPanel(nbColRow);
            ListecontrolCheminOrdinateur.Clear();
            ListecouleurControl.Clear();
            AjouteButtonTable();
            AjouteListeCheminCouleur(nbTourToLevel);
            timerCouleurControl.Start();
            lblCompteARebours.Text = "3";
            lblScore.Text = score.ToString();
            lblLevel.Text = level;
            lblIntervalTimer.Text = timerCouleurControl.Interval.ToString();
        }

        /// <summary>
        /// Bouton replay 
        /// </summary>
        private void replay()
        {
            if (score <= 200)
            {
                btnReplay.BackColor = Color.Red;
                btnReplay.ForeColor = Color.White;
                btnReplay.Tag = "no";
                btnReplay.Text = "NO";
                btnReplay.Enabled = false;
            }
            else
            {
                btnReplay.Enabled = true;
                btnReplay.BackColor = Color.Gold;
                btnReplay.ForeColor = Color.Black;
                btnReplay.Tag = "yes";
                btnReplay.Text = "YES";
            }
        }

        /// <summary>
        /// Fonction permettant de créer une table selon les dimensions choisi
        /// </summary>
        /// <param name="nbColRow">Dimension de la table en colonne et ligne</param>
        /// <returns>Retourne la table</returns>
        private TableLayoutPanel CreationTableLayoutPanel(int nbColRow)
        {
            TableLayoutPanel table = new TableLayoutPanel();
            table.Location = new Point((this.Width/2)-175, 100);
            table.Size = new Size(350, 350);
            float oui = 100 / nbColRow;
            table.ColumnCount = nbColRow;
            table.RowCount = nbColRow;
            table.BackColor = Color.Transparent;
            for (int i = 0; i < nbColRow; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            this.Controls.Add(table);

            return table;
        }

        /// <summary>
        /// Creation d'un bouton
        /// </summary>
        /// <returns>retourne un bouton</returns>
        private Button CreationButton()
        {
            countNameBtn++;
            Button btn = new Button();
            btn.Name = "button" + (countNameBtn).ToString();
            btn.Text = "";
            btn.Tag = btn.Name;
            btn.Font = new Font("Courier New", 35F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Dock = DockStyle.Fill;
            btn.BackColor = Color.Snow;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Enabled = false;
            btn.FlatAppearance.BorderColor = Color.Gray;
            btn.FlatAppearance.BorderSize = 4;
            btn.Click += new System.EventHandler(this.buttonTableClick);
            return btn;
        }

        /// <summary>
        /// Supression des button de la table
        /// </summary>
        private void SupprimeButton()
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    table.Controls.Remove(table.GetControlFromPosition(j, i));
                }
            }
        }

        /// <summary>
        /// Ajout de button dans la table
        /// </summary>
        private void AjouteButtonTable()
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    Button btn = CreationButton();
                    table.Controls.Add(btn, j, i);
                }
            }
        }

        /// <summary>
        /// A
        /// </summary>
        /// <param name="nombreDeFois"></param>
        private void AjouteListeCheminCouleur(int nombreDeFois)
        {
            for(int i=0; i<nombreDeFois; i++)
            {
                cheminCouleurOrdinateur();
            }
        }

        /// <summary>
        /// L'orinateur définit un chemin de couleur
        /// </summary>
        private void cheminCouleurOrdinateur()
        {
            int col = random.Next(0, table.ColumnCount);
            int rol = random.Next(0, table.RowCount);
            Control btn = table.GetControlFromPosition(col, rol);
            Color couleur = Color.FromArgb(((int)(((byte)(random.Next(230))))), ((int)(((byte)(random.Next(230))))), ((int)(((byte)(random.Next(230))))));
            ListecontrolCheminOrdinateur.Add(btn);
            ListecouleurControl.Add(couleur);
        }

        /// <summary>
        /// Initialise les buttons de la table
        /// </summary>
        private void initialiseControlTable()
        {
            foreach(Control ctrl in table.Controls)
            {
                ctrl.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Affichage du chemin de couleur définit par l'ordinateur
        /// </summary>
        private void AffichageCheminCouleurOrdinateur()
        {
            initialiseControlTable();
            if (count == ListecontrolCheminOrdinateur.Count)
            {
                count = 0;
                foreach (Control ctrl in table.Controls)
                {
                    ctrl.Enabled = true;
                }
                timerCouleurControl.Stop();
            }
            else
            {
                ListecontrolCheminOrdinateur[count].BackColor = ListecouleurControl[count];
                count++;
            }
            
        }

        /// <summary>
        /// Procédure lors d'un appui sur un des bouttons de la table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTableClick(object sender, EventArgs e)
        {
            initialiseControlTable();
            Control btn = (Control)sender;
           
            btn.BackColor = ListecouleurControl[count];
            if (btn.Name != ListecontrolCheminOrdinateur[count].Name)
            {
                timerCouleurControl.Stop();
                lose();
            }
            count++;
            if (count == ListecontrolCheminOrdinateur.Count())
            {
                timerCouleurControl.Stop();
                nbLevelToTour++;
                foreach (Control ctrl in table.Controls)
                {
                    ctrl.Enabled = false;
                }
                win();
            }
        }

        /// <summary>
        /// Procédure lorsque l'utilisateur perds la partie
        /// </summary>
        private void lose()
        {
            foreach (Control ctrl in table.Controls)
            {
                ctrl.Enabled = false;
            }
            rejouer();
            if(tempsCompteARebours == 0)
            {
                initialisation();
            }
        }
        
        /// <summary>
         /// Procédure lorsque l'utilisateur gagne la partie
         /// </summary>
        private void win()
        {
            DialogResult message;
            if (nbLevelToTour % 3 == 0)
            {
                message = messageLevel();
                if (message == DialogResult.Yes)
                {
                    tempsCompteARebours = 3;
                    nbColRow++;
                    compteARebours(false);
                    timerCompteArebours.Start();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                tempsCompteARebours = 0;
                nbTourToLevel++;
                timerCouleurControl.Interval = timerCouleurControl.Interval - 70;
            }
            if(tempsCompteARebours == 0)
            {
                initialisation();
            }
        }

        /// <summary>
        /// Affichage d'un message lors d'un passage d'un autre level
        /// </summary>
        /// <returns></returns>
        private DialogResult messageLevel()
        {
            DialogResult message;
            switch (nbLevelToTour)
            {
                case 3:
                    level = "Medium";
                    score += 100;
                    nbTourToLevel = 4;
                    this.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    level = "Hard";
                    score += 200;
                    nbTourToLevel = 5;
                    this.BackColor = Color.Red;
                    break;
                case 9:
                    level = "Legendary"; 
                    score += 300;
                    nbTourToLevel = 6;
                    this.BackColor = Color.DarkRed;
                    break;
                case 12:
                    level = "Impossible";
                    score += 500;
                    nbTourToLevel = 8;
                    this.BackColor = Color.Black;
                    break;
            }

            lblScore.Text = score.ToString();
            lblLevel.Text = level;
            message = MessageBox.Show("You are at the level : " + level+"\nDo you want to continue ?", "Good Game", MessageBoxButtons.YesNo);
            return message;
        }

        /// <summary>
        /// Procédure pour rejouer la partie
        /// </summary>
        private void rejouer()
        {
            DialogResult message = MessageBox.Show("You have reached the level : " + level + "\nYour score is :" + score + "\nDo you want to replay ?", "Lose", MessageBoxButtons.YesNo);
            if(message == DialogResult.Yes)
            {
                tempsCompteARebours = 3;
                timerCompteArebours.Interval = 1000;
                timerCompteArebours.Start();
                score = 0;
                level = "Easy";
                timerCouleurControl.Interval = 1000;
                nbTourToLevel = 3;
                nbLevelToTour = 0;
                nbColRow = 3;
                this.BackColor = Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(141)))));
                compteARebours(false);

            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Compte à rebours // Visibilité des élements du formulaire
        /// </summary>
        /// <param name="valueVisible"></param>
        private void compteARebours(bool valueVisible)
        {
            table.Visible = valueVisible;
            lblCompteARebours.Visible = !valueVisible;
        }

        /// <summary>
        /// Timer pour affichage du chemin de couleurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCouleurControl_Tick(object sender, EventArgs e)
        {
            AffichageCheminCouleurOrdinateur();
        }

        /// <summary>
        /// Timer pour le compte à rebours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCompteArebours_Tick(object sender, EventArgs e)
        {
            if (tempsCompteARebours > 0)
            {
                if (tempsCompteARebours > 3)
                {
                    if (tempsCompteARebours % 2 == 0)
                    {
                        lblIntroduction.Text = ListeinstructionBienvenue[countIntroduction];
                        countIntroduction++;
                    }
                }
                else
                {
                    lblIntroduction.Visible = false;
                    lblCompteARebours.Text = tempsCompteARebours.ToString();
                }
                tempsCompteARebours--;
            }
            else
            {
                compteARebours(true);
                AjouteButtonTable();
                AjouteListeCheminCouleur(nbTourToLevel);
                panelUtilisateur.Visible = true;
                timerCompteArebours.Stop();
                timerCouleurControl.Stop();
                timerCouleurControl.Start();

                tempsCompteARebours = 3;
                countIntroduction = 0;

                initialisation();
            }
        }

        /// <summary>
        /// Bouton quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            timerCouleurControl.Stop();
            this.Close();
        }

        /// <summary>
        /// Bouton replay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplay_Click(object sender, EventArgs e)
        {
            string phrase = "\nYour score is : " + score + "\nYour score after replay : " + (score -200);
            
            DialogResult message = MessageBox.Show("You need 200 score points for replay" + phrase+ "\nDo you want to continue ?", "replay", MessageBoxButtons.YesNo);
            if(btnReplay.Tag.ToString() == "yes" && message == DialogResult.Yes)
            {
                count = 0;
                timerCompteArebours.Stop();
                timerCouleurControl.Start();
                score -= 200;
                lblScore.Text = score.ToString();
                replay();
            }
            else if(message == DialogResult.No)
            {
                timerCompteArebours.Stop();
                timerCouleurControl.Stop();
                this.Close();
            }
        }
    }
}
