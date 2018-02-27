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
       

        public DAOPraticien()
        {

        }
        public void ajouterPraticien(String codePraticien,String raisonSociale, String adresse, 
            String telephone, String contact, String coefNotoriete, String coefConfiance, 
            String specialite)
        {
            try
            {
                String req = "INSERT INTO Praticien Values ('"+codePraticien+"', '"+raisonSociale+"', '"+adresse+"','"+telephone+"','"+contact+"','"+coefNotoriete+"','"+coefConfiance+"')";
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
