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
                String req = "INSERT INTO Visiteur (nomVisiteur,prenomVisiteur,adresse,cpVisiteur,villeVisiteur,dateEmbauche,numSecteur)  Values ('" + visiteur.NomVisiteur + "', '" + visiteur.PrenomVisiteur 
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
                String req = "UPDATE Visiteur (nomVisiteur,prenomVisiteur,adresse,cpVisiteur,villeVisiteur,dateEmbauche,numSecteur) SET nomVisiteur = '" + visiteur.NomVisiteur + "', prenomVisiteur = '" + visiteur.PrenomVisiteur
                    + "', adresse = '" + visiteur.Adresse + "', cpVisiteur = '" + visiteur.CpVisiteur + "', villeVisiteur = '" + visiteur.VilleVisiteur + "', dateEmbauche = '" + visiteur.DateEmbauche +"', descriptionSecteur = '" + visiteur.SecteurVisiteur + "'";
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
        
        public static void  allVisiteur()
        {
             
            try
            {
                String req = "Select * From Visiteur WHERE supprimer=0";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
                Visiteur v = null;
                while (rs.Read())
                {
                    v = new Visiteur(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5), rs.GetString(6));
                }
                Visiteur.lesVisiteurs.Add(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex);
            }
            
        }
        
    }
}
