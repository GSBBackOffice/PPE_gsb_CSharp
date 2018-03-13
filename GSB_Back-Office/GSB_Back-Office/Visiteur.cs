using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Back_Office
{
    class Visiteur
    {
        private static DAOVisiteur db = new DAOVisiteur();
        public static List<Visiteur> lesVisiteurs = new List<Visiteur>();
        private string nomVisiteur;
        private string prenomVisiteur;
        private string adresse;
        private string cpVisiteur;
        private string villeVisiteur;
        private DateTime dateEmbauche;
        private string secteurVisiteur;


        public Visiteur(string nomVisiteur, string prenomVisiteur, string adresse, string cpVisiteur, string villeVisiteur, DateTime dateEmbauche, string secteurVisiteur)
        {
            this.nomVisiteur = nomVisiteur;
            this.prenomVisiteur = prenomVisiteur;
            this.adresse = adresse;
            this.cpVisiteur = cpVisiteur;
            this.villeVisiteur = villeVisiteur;
            this.dateEmbauche = dateEmbauche;
            this.secteurVisiteur = secteurVisiteur;
        }
        #region Accesseurs

        public string NomVisiteur
        {
            get
            {
                return nomVisiteur;
            }

            set
            {
                nomVisiteur = value;
            }
        }

        public string PrenomVisiteur
        {
            get
            {
                return prenomVisiteur;
            }

            set
            {
                prenomVisiteur = value;
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

        public string CpVisiteur
        {
            get
            {
                return cpVisiteur;
            }

            set
            {
                cpVisiteur = value;
            }
        }

        public string VilleVisiteur
        {
            get
            {
                return villeVisiteur;
            }

            set
            {
                villeVisiteur = value;
            }
        }

        public DateTime DateEmbauche
        {
            get
            {
                return dateEmbauche;
            }

            set
            {
                dateEmbauche = value;
            }
        }

        public string SecteurVisiteur
        {
            get
            {
                return secteurVisiteur;
            }

            set
            {
                secteurVisiteur = value;
            }
        } 
        #endregion

        public static void ajouterVisiteur(Visiteur unVisiteur)
        {
            lesVisiteurs.Add(unVisiteur);
            db.creerVisiteur(unVisiteur);
            

        }

    }
}
