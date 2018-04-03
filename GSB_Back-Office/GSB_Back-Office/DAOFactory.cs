using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GSB_Back_Office
{
    class DAOFactory
    {
        SqlConnection myConnexion;
        SqlDataAdapter myDataAdapter;
        SqlCommand myCommand;
        SqlDataReader myDR;
        public DAOFactory()
        {
        }
        public void connect()
        {
            try
            {
                myConnexion = new SqlConnection("Data Source='172.17.21.10';Initial Catalog=SIO2_GSB_TeamD;User ID=SIO2-dev;Password=btssio-slam-2018");
                myConnexion.Open();
            }
            catch (Exception ex){MessageBox.Show("Erreur : " + ex.Message);}
        }
        public void disconnect()
        {
            myConnexion.Close();
        }

        public void execSQLwrite(String req)
        {
            try
            {
                myCommand = new SqlCommand();
                myCommand.CommandText = req;
                myCommand.Connection = myConnexion;
                myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = myCommand;
                myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }
        public SqlDataReader execSQLread(String req)
        {
            try
            {
                myCommand = new SqlCommand();
                myCommand.CommandText = req;
                myCommand.Connection = myConnexion;
                myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = myCommand;
                myDR = myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return myDR;
        }
    }
}
