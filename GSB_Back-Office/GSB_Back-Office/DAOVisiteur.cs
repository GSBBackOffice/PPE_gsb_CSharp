using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GSB_Back_Office
{
    class DAOVisiteur
    {
        private string numVisiteur;
        private string nomVisiteur;
        private string prenomVisiteur;
        private string adresse;
        private string cpVisiteur;
        private string villeVisiteur;
        private string dateEmbauche;
        private string descriptionSecteur;

        public DAOVisiteur()
        {

        }
        
        public void creerVisiteur(Visiteur visiteur)
        {
            try
            {
                String req = "INSERT INTO Visiteur Values ('" + visiteur.NumVisiteur + "', '" + visiteur.NomVisiteur + "', '" + visiteur.PrenomVisiteur 
                    + "','" + visiteur.Adresse + "','" + visiteur.CpVisiteur + "','" + visiteur.VilleVisiteur + "','" + visiteur.DateEmbauche + "', '" + visiteur.SecteurVisiteur + "')";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex);
            }
        }
        public void modifVisiteur(Visiteur visiteur)
        {
            try
            {
                String req = "UPDATE Visiteur SET numVisiteur = '" + visiteur.NumVisiteur + "', nomVisiteur = '" + visiteur.NomVisiteur + "', prenomVisiteur = '" + visiteur.PrenomVisiteur
                    + "', adresse = '" + visiteur.Adresse + "', cpVisiteur = '" + visiteur.CpVisiteur + "', villeVisiteur = '" + visiteur.VilleVisiteur + "', dateEmbauche = '" + visiteur.DateEmbauche + "', descriptionSecteur = '" + visiteur.SecteurVisiteur+ "'";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex);
            }
        }

    }
}
