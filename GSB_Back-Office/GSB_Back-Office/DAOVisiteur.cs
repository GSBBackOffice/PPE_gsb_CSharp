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
        
        public static List<Visiteur> allVisiteur()
        {
            List<Visiteur> lesVisiteurs2 = new List<Visiteur>();
            try
            {
                String req = "Select nomVisiteur,prenomVisiteur,adresse,cpVisiteur,villeVisiteur,dateEmbauche,numSecteur From Visiteur";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
                Visiteur v = null;
                while (rs.Read())
                {
                    v = new Visiteur(rs[1].ToString(), rs[2].ToString(), rs[3].ToString(), rs[4].ToString(), rs[5].ToString(), DateTime.Parse(rs[6].ToString()), rs[7].ToString());
                }
                lesVisiteurs2.Add(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex);
            }
            return lesVisiteurs2;
        }
        
    }
}
