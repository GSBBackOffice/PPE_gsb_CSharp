using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Back_Office
{
    class Praticien
    {
        private static DAOPraticien db = new DAOPraticien();
        String raisonSociale;
        String adresse;
        String telephone;
        String contact;
        String coefNotoriete;
        String coefConfiance;
        String specialite;

        public Praticien(String uneRaisonSociale, String uneAdresse,
            String unTelephone, String unContact, String unCoefNotoriete, String unCoefConfiance,
            String uneSpecialite)
        {
            this.raisonSociale = uneRaisonSociale;
            this.adresse = uneAdresse;
            this.telephone = unTelephone;
            this.contact = unContact;
            this.coefNotoriete = unCoefNotoriete;
            this.coefConfiance = unCoefConfiance;
            this.specialite = uneSpecialite;

        }

        public static List<Praticien> lesPraticiens = new List<Praticien>();

        public static void ajouterPraticien(Praticien unPraticien)
        {
            lesPraticiens.Add(unPraticien);
            db.creerPraticien(unPraticien);
                        
        }

    }
}
