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

        private String codePraticien;
        private String raisonSociale;
        private String adresse;
        private String telephone;
        private String contact;
        private String coefNotoriete;
        private String coefConfiance;
        private String specialite;


        public string RaisonSociale
        {
            get
            {
                return raisonSociale;
            }


            set
            {
                raisonSociale = value;
            }
        }

        
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string CoefNotoriete
        {
            get
            {
                return coefNotoriete;
            }

            set
            {
                coefNotoriete = value;
            }
        }

        public string CoefConfiance
        {
            get
            {
                return coefConfiance;
            }

            set
            {
                coefConfiance = value;
            }
        }

        public string Specialite
        {
            get
            {
                return specialite;
            }

            set
            {
                specialite = value;
            }
        }

        public static void ajouterPraticien(Praticien unPraticien)
        {
            lesPraticiens.Add(unPraticien);
            db.creerPraticien(unPraticien);                        
        }


    }
}
