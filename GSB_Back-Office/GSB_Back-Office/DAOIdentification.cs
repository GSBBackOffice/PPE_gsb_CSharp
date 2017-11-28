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
                String req = "select * COUCOUfrom login where login='" + id + "' and password='" + password + "'";
                SqlDataReader rs;
                DAOFactory db = new DAOFactory();
                db.connect();
                rs = db.execSQLread(req);
                while (rs.NextResult())
                {
                    i = i++;
                }
                if (i != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex);
            }
            
        }
        
    }
}
