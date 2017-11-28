using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GSB_Back_Office
{
    class DAOIdentification
    {        
        public bool verifConnect(String id, String password)
        {
            int i = 0;
            try
            {
                String req = "select * from gestionnaire where loginGestionnaire='" + id + "' and mdpGestionnaire='" + password + "'";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
                while (rs.NextResult())
                {
                    i = i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex);
            }
            if (i != 0){return true;}
            else {return false; }
            
        }

    }
}
