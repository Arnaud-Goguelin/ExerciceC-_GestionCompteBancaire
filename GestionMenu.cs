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
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                    {
                    Console.WriteLine
                        (
                        "[I] Voir les informations sur le titulaire du compte;" + Environment.NewLine +
                        "[CS] Compte courant - Consulter le solde" + Environment.NewLine +
                        "[CD] Compte courant - Déposer des fonds" + Environment.NewLine +
                        "[CR] Compte courant - Retirer des fonds" + Environment.NewLine +
                        "[ES] Compte épargne - Consulter le solde" + Environment.NewLine +
                        "[ED] Compte épargne - Déposer des fonds" + Environment.NewLine +
                        "[ER] Compte épargne - Retirer des fonds" + Environment.NewLine +
                        "[X] Quitter"
                        );
                    break;
                }
            }
        }
        
    }
}
