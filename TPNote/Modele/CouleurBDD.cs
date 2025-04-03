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
    class CouleurBDD
    {
        #region Attributs
        private int idcouleur;
        private string couleur;
        private Connection conn;
        private DataTable dtListeCouleur;
        #endregion
        #region Constructeur

        public CouleurBDD()
        {
            
        }
        public CouleurBDD(int idcolor, string color)
        {
            idcouleur = idcolor;
            couleur = color;
        }
        #endregion
        #region Affichage Liste Couleur
        public DataTable GetListeCouleur()
        {
            dtListeCouleur = new DataTable();

            Connection conn = new Connection();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("select IDCOULEUR as ID, LABELCOULEUR as LABEL FROM couleur ORDER BY LABELCOULEUR;", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeCouleur.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            DataRow workRow = dtListeCouleur.NewRow();
            workRow[0] = -1;
            workRow[1] = "";
            dtListeCouleur.Rows.InsertAt(workRow, 0);

            return dtListeCouleur;
        }
        #endregion
    }
}
