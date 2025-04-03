using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPNote.Controller;

namespace TPNote
{
    public partial class CmdVoiture : Form
    {

        public CmdVoiture()
        {
            InitializeComponent();
            CouleurBDD dt_color = new CouleurBDD();
            cmb_Couleur.DataSource = dt_color.GetListeCouleur();
            cmb_Couleur.DisplayMember = "LABEL";
            cmb_Couleur.ValueMember = "ID";

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {

        }
    }
}
