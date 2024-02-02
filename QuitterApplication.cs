using ExerciceC__GestionnaireCompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceC__GestionCompteBancaire
{
    public class QuitterApplication
    {
        public static void Quitter()
        {
            Console.WriteLine("Voulez-vous quitter l'application?" + Environment.NewLine + "Saisissez 'O' pour quitter, 'N' pour continuez.");
            string saisieUtilisateur = Console.ReadLine();

            switch (saisieUtilisateur)
            {
                case "O":
                    Environment.Exit(0);
                    break;
                case "N":
                    GestionMenu.AfficherMenu();
                    break;
                default:
                    Console.WriteLine("Saisie invalide.");
                    Quitter();
                    break;
            }
        }
    }
}