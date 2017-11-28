using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Back_Office
{
    class Praticien
    {
        DAOPraticien praticien = new DAOPraticien();

        String codePraticien;
        String raisonSociale;
        String adresse;
        String telephone;
        String contact;
        String coefNotoriete;
        String coefConfiance;
        String specialite;

        public void ajouterPraticien(String unCodePraticien, String uneRaisonSociale, String uneAdresse,
            String unTelephone, String unContact, String unCoefNotoriete, String unCoefConfiance,
            String uneSpecialite)
        {
            codePraticien = unCodePraticien;
            raisonSociale = uneRaisonSociale;
            adresse = uneAdresse;
            telephone = unTelephone;
            contact = unContact;
            coefNotoriete = unCoefNotoriete;
            coefConfiance = unCoefConfiance;
            specialite = uneSpecialite;

            praticien.ajouterPraticien(codePraticien, raisonSociale, adresse, telephone, contact, coefNotoriete, coefConfiance, specialite);
        }

    }
}
