using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPNote.Modele;

namespace TPNote.Controller
{
    class VehiculeBDD
    {
        #region Attributs
        private int idcouleur;
        private string couleur;
        private DateTime datecommande;
        private Connection conn;
        private DataTable dtListeVehicule;
        #endregion
        #region Accesseur
        public int Idcouleur
        {
            get { return idcouleur; }
            protected set { idcouleur = value; } 
        }

        public string Couleur
        {
            get { return couleur; }
            protected set { couleur = value; }
        }

        public DateTime Datecommande
        {
            get { return datecommande; }
            protected set { datecommande = value; }
        }
        #endregion
        #region Constructeur
        public VehiculeBDD(int idcolor,string color)
        {
            idcouleur = idcolor;  
            couleur = color;
        }
        #endregion
        #region InsertionBDD 
        public Int32 InserCommande()
        {
            Int32 reponse = 0;
            string rqtSql = "INSERT INTO `commande` (`IDCOMMANDE`, `DATECOMMANDE`, `IDCOULEUR`) VALUES (NULL, '" + datecommande.ToString() + "', " + idcouleur + "); ";
                       
                try
                {
                    conn = new Connection();
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                    {
                        conn.connection.Open();
                        cmd.ExecuteNonQuery();
                        reponse = Convert.ToInt32(cmd.LastInsertedId);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            
            return reponse;
        }
        #endregion
       
    }
}
