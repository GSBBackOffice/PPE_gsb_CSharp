using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GSB_Back_Office
{
    class DAOPraticien
    {
        String codePraticien;
        String raisonSociale;
        String adresse;
        String telephone;
        String contact;
        String coefNotoriete;
        String coefConfiance;
        String specialite;

        public DAOPraticien()
        {

        }
        public void creerPraticien(Praticien unPraticien)
        {
            try
            {
                String req = "INSERT INTO Praticien (raisonSocialePraticien, adressePraticien, telephonePraticien, contactPraticien, coefficientNotoriete, coefficientConfiance, numSpecialite) Values ('" + unPraticien.RaisonSociale + "', '" + unPraticien.Adresse + "','" + unPraticien.Telephone + "','" + unPraticien.Contact + "','" + unPraticien.CoefNotoriete + "','" + unPraticien.CoefConfiance + "','"+ unPraticien.Specialite + "')";
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
        public void affichPraticien()
        {
            String req = "SELECT * FROM Praticien";
            SqlDataReader rs;
            DAOFactory db = new DAOFactory();
            db.connect();
            rs = db.execSQLread(req);
            Praticien p = null;
            while (rs.Read())
            {
                p = new Praticien(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6));
            }

        }
        

    }
}
