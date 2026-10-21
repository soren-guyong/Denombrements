using System;

namespace Denombrements
{
    /// <summary>
    /// Interface calculs de dénombrements
    /// Permet de calculer des permutations, des arrangements et des combinaisons
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calcul du produit de plusieurs entiers successifs entre deux valeurs
        /// </summary>
        /// <param name="valeurDepart">Valeur du départ du calcul</param>
        /// <param name="valeurArrivee">Valeur d'arrivée du calcul</param>
        /// <returns>Résultat du produit des entiers</returns>
        static long ProduitEntiers(int valeurDepart, int valeurArrivee)
        {
            long produit = 1;
            for (int k = valeurDepart; k <= valeurArrivee; k++)
            {
                produit *= k;
            }
            return produit;
        }
        /// <summary>
        /// Menu permettant de faire, plusieurs fois, 3 calculs : permutation, arrangement, combinaison
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();
                // vérification du choix
                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());
                        // choix permutation
                        if (choix == "1")
                        {
                            long resultPermutation = ProduitEntiers(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + resultPermutation);
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsemble = int.Parse(Console.ReadLine());
                            // calcul de l'arrangement, utile pour la combinaison également
                            long resultArrangement = ProduitEntiers(nbTotal - nbSousEnsemble + 1, nbTotal);
                            // choix arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("A(" + nbTotal + "/" + nbSousEnsemble + ") = " + resultArrangement);
                            }
                            // choix combinaison
                            else
                            {
                                long factorielleNbSousEnsemble = ProduitEntiers(1, nbSousEnsemble);
                                Console.WriteLine("C(" + nbTotal + "/" + nbSousEnsemble + ") = " + (resultArrangement / factorielleNbSousEnsemble));
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Calcul impossible : valeur(s) incorrecte(s) ou trop grande(s).");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
