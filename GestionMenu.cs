using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceC__GestionnaireCompteBancaire
{
    internal class GestionMenu
    {
        public static void AfficherMenu()
        {

            while (true)
            {
                Console.WriteLine("Appuyez sur Entrée pour afficher le menu.");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine
                        (
                        "[I] Voir les informations sur le titulaire du compte" + Environment.NewLine +
                        "[CS] Compte courant - Consulter le solde" + Environment.NewLine +
                        "[CD] Compte courant - Déposer des fonds" + Environment.NewLine +
                        "[CR] Compte courant - Retirer des fonds" + Environment.NewLine +
                        "[ES] Compte épargne - Consulter le solde" + Environment.NewLine +
                        "[ED] Compte épargne - Déposer des fonds" + Environment.NewLine +
                        "[ER] Compte épargne - Retirer des fonds" + Environment.NewLine +
                        "[X] Quitter"
                        );
                    string saisieUtilisateur = Console.ReadLine();
                    GestionChoixUtilisateur(saisieUtilisateur);
                    break;
                }
            }
        }

        public static void GestionChoixUtilisateur(string saisieUtilisateur)
        {
            switch (saisieUtilisateur)
            {
                case "I":
                    Console.WriteLine("Voir les informations sur le titulaire du compte");
                    break;
                case "CS":
                    Console.WriteLine("Compte courant - Consulter le solde");
                    break;
                case "CD":
                    Console.WriteLine("Compte courant - Déposer des fonds");
                    break;
                case "CR":
                    Console.WriteLine("Compte courant - Retirer des fonds");
                    break;
                case "ES":
                    Console.WriteLine("Compte épargne - Consulter le solde");
                    break;
                case "ED":
                    Console.WriteLine("Compte épargne - Déposer des fonds");
                    break;
                case "ER":
                    Console.WriteLine("Compte épargne - Retirer des fonds");
                    break;
                case "X":
                    Console.WriteLine("Quitter");
                    break;
                default:
                    Console.WriteLine("Veuillez saisir un choix possible dans le menu");
                    AfficherMenu();
                    break;
            }
        }
    }
}
