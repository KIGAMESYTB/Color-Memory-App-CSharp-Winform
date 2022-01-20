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
    public partial class frm_Accueil : Form
    {
        frm_ZoneJeuColor zoneJeu;
        List<Color> couleurTitle;
        int count;
        int countMemory;

        public frm_Accueil()
        {
            InitializeComponent();
            couleurTitle = new List<Color>() { Color.MistyRose, Color.Sienna,Color.PeachPuff, Color.LightSalmon, Color.Snow };
            count = 0;
            countMemory = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblColor.ForeColor = couleurTitle[count];
            lblMemory.ForeColor = couleurTitle[countMemory];
            if(count == 3)
            {
                panelBienvenue.Visible = false;
                count = 0;
                countMemory = 1;
            }
            if(count == couleurTitle.Count - 1)
            {
                count = -1;
            }
            if(countMemory == couleurTitle.Count - 1)
            {
                countMemory = -1;
            }
            count++;
            countMemory++;
            
        }

        private void buttonClick(object sender, EventArgs e)
        {
            timer1.Stop();
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnStart":
                    zoneJeu = new frm_ZoneJeuColor();
                    zoneJeu.ShowDialog();
                    break;
                case "btnQuitter":
                    Application.Exit();
                    break;
            }
        }
    }
}
