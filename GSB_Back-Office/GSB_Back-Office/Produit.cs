using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Back_Office
{
    class Produit
    {
<<<<<<< HEAD
        #region Propriétés
        public static List<Produit> lesProduits;
        private string numProduit;
        private string nomProduit;
        private string presProduit;
        private int dosageProduit;
        private float prixVenteHTProduit;
        private float prixEchantillonProduit;
        private FamilleProduit familleProduit;
        private List<Effet> lesEffets;
        #endregion
        #region accesseurs
        public string NumProduit
        {
            get
            {
                return numProduit;
            }

            set
            {
                numProduit = value;
            }
        }

        public string NomProduit
        {
            get
            {
                return nomProduit;
            }

            set
            {
                nomProduit = value;
            }
        }

        public string PresProduit
        {
            get
            {
                return presProduit;
            }

            set
            {
                presProduit = value;
            }
        }

        public int DosageProduit
        {
            get
            {
                return dosageProduit;
            }

            set
            {
                dosageProduit = value;
            }
        }

        public float PrixVenteHTProduit
        {
            get
            {
                return prixVenteHTProduit;
            }

            set
            {
                prixVenteHTProduit = value;
            }
        }

        public float PrixEchantillonProduit
        {
            get
            {
                return prixEchantillonProduit;
            }

            set
            {
                prixEchantillonProduit = value;
            }
        }

        public FamilleProduit FamilleProduit
        {
            get
            {
                return familleProduit;
            }

            set
            {
                familleProduit = value;
            }
        }
        #endregion
        #region Constructeur
        public Produit(string unNumProduit,string unNomProduit, string unePresProduit,int unDosageProduit,float unPrixVenteHTProduit,
                        float unPrixEchantillonProduit,FamilleProduit uneFamilleProduit,List<Effet> desEffets)
        {
            numProduit = unNumProduit;
            nomProduit = unNomProduit;
            presProduit = unePresProduit;
            dosageProduit = unDosageProduit;
            prixVenteHTProduit = unPrixVenteHTProduit;
            prixEchantillonProduit = unPrixEchantillonProduit;
            familleProduit = uneFamilleProduit;
            lesEffets = desEffets;
        }
        #endregion

=======
>>>>>>> CHARLES
    }
}
