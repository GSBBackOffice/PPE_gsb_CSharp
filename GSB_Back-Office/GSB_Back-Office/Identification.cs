using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Back_Office
{
    class Identification
    {
        DAOIdentification id = new DAOIdentification();
        public bool verifConnexion(String unLogin, String unPassword)
        {
            return id.verifConnect(unLogin, unPassword);             
        }
    }
}
