using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_Back_Office
{
    class DAOProduit
    {
        private static DAOFactory db = new DAOFactory();
        
        public static void initProduits()
        {
            try
            {   
                string req = "SELECT * FROM Produit where supprimer=0";
                SqlDataReader res;
                db.connect();
                res = db.execSQLread(req);
                while(res.Read())
                {
                    List<Effet> lesEffets= new List<Effet>();
                    string reqEffet = "SELECT Effet.numEffet,Effet.descriptionEffet,TypeEffet.libelleTypeEffet " +
                                      "FROM ((((TypeEffet inner join Appartenir on TypeEffet.numTypeEffet=Appartenir.numTypeEffet) "
                                      + "inner join Effet on Appartenir.numEffet=Effet.numEffet) inner join Impliquer on Effet.numEffet"
                                      + "=Impliquer.numEffet) inner join Produit on Produit.numProduit=Impliquer.numProduit) WHERE Produit"
                                      + ".numProduit=" + Int32.Parse(res.GetValue(0).ToString()) + ";";
                    SqlDataReader resEffet;
                    resEffet = db.execSQLread(reqEffet);
                    while(resEffet.Read())
                    {
                        Effet e = new Effet(Int32.Parse(resEffet.GetValue(0).ToString()), resEffet.GetValue(1).ToString(), res.GetValue(3).ToString());
                        lesEffets.Add(e);
                    }
                    string reqFamille = "SELECT * from FamilleMedicament WHERE numFamille=" + Int32.Parse(res.GetValue(8).ToString()) + " ;";
                    SqlDataReader resFamille = db.execSQLread(reqFamille);
                    FamilleProduit famille = new FamilleProduit();
                    while (resFamille.Read())
                    {
                        famille.NumFamille = Int32.Parse(resFamille.GetValue(0).ToString());
                        famille.NomFamille = resFamille.GetValue(1).ToString();
                    }
                    
                    Produit p = new Produit(res.GetValue(0).ToString(),res.GetValue(1).ToString(), res.GetValue(2).ToString(), Int32.Parse(res.GetValue(3).ToString()), float.Parse(res.GetValue(4).ToString()),float.Parse(res.GetValue(5).ToString()),famille, lesEffets);
                }
                db.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public DAOProduit()
        {

        }

        public void creerVisiteur(Visiteur visiteur)
        {
            try
            {
                String req = "INSERT INTO Visiteur Values ('" + visiteur.NumVisiteur + "', '" + visiteur.NomVisiteur + "', '" + visiteur.PrenomVisiteur
                    + "','" + visiteur.Adresse + "','" + visiteur.CpVisiteur + "','" + visiteur.VilleVisiteur + "','" + visiteur.DateEmbauche + "', '" + visiteur.SecteurVisiteur + "')";
                SqlDataReader rs;
                
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
                    + "', adresse = '" + visiteur.Adresse + "', cpVisiteur = '" + visiteur.CpVisiteur + "', villeVisiteur = '" + visiteur.VilleVisiteur + "', dateEmbauche = '" + visiteur.DateEmbauche + "', descriptionSecteur = '" + visiteur.SecteurVisiteur + "'";
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
        public void creerProduit(Produit p)
        {
            string req = "INSERT INTO Produit (nomProduit,presentationProduit,dosageProduit,prixVenteHTProduit,prixEchantillonProduit,)";
        }
    }
}
