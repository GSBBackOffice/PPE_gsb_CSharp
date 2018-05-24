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
                    + "','" + visiteur.Adresse + "','" + visiteur.CpVisiteur + "','" + visiteur.VilleVisiteur + "','" + Convert.ToDateTime(visiteur.DateEmbauche) + "', '" + visiteur.SecteurVisiteur + "')";
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
        
        public static List<Visiteur> lesVisiteurs2 = new List<Visiteur>();
        
        public static Dictionary<int,string> getSecteurVisiteur()
        {
            Dictionary<int, string> ZoneGeo = new Dictionary<int, string>();
            try
            {
                String req = "Select * from SecteurVisiteur";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
                while(rs.Read())
                {
                    ZoneGeo.Add(Convert.ToInt32(rs[0].ToString()), rs[1].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR : "+ e);
            }
            return ZoneGeo;
        }

        public static List<Visiteur> allVisiteur()
        {           
            try
            {
                String req = "Select nomVisiteur,prenomVisiteur,adresse,cpVisiteur,villeVisiteur,dateEmbauche,descriptionSecteur From Visiteur INNER JOIN SecteurVisiteur ON Visiteur.numSecteur = SecteurVisiteur.numSecteur";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
                Visiteur v = null;
                while (rs.Read())
                {
                    v = new Visiteur(rs[0].ToString(), rs[1].ToString(), rs[2].ToString(), rs[3].ToString(), rs[4].ToString(), rs[5].ToString(), rs[6].ToString());
                    lesVisiteurs2.Add(v);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex);
            }
            return lesVisiteurs2;
        }        
    }
}
