using outils;
using System;

namespace generateur_mot_de_passe
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NB_MOT_DE_PASSE = 10;
            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

            string miniscules = "abdcefghijklmnopqrstuvwxyz";
            string majuscules = miniscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "#&+-*/_@~.";
            string alphabet = "";
            while (true)
            {
                Console.WriteLine("Vous voulez un mot de passe avec : ");
                Console.WriteLine("1 - Uniquement des caractères en minuscules");
                Console.WriteLine("2 - Des caractères minuscules et majuscules");
                Console.WriteLine("3 - Des caractères et des chiffres");
                Console.WriteLine("4 - Caractères, chiffres et caractères spéciaux");
                int choix = outils.DemanderNombreEntre("Veuillez rentrer un nombre : ", 1, 4);
                try
                {
                    switch(choix)
                    {
                        case 1:
                            alphabet = miniscules;
                            break;
                        case 2:
                            alphabet = miniscules + majuscules;
                            break;
                        case 3:
                            alphabet = miniscules + majuscules + chiffres;
                            break;
                        case 4:
                            alphabet = miniscules + majuscules + chiffres + caracteresSpeciaux;
                            break;
                        //default:
                          //  continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }
            string motDePasse = "";
            int longueurAlphabet = alphabet.Length;
            Random rand = new Random();
            for(int j = 0;  j < NB_MOT_DE_PASSE; j++)
            {
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    //Console.WriteLine(alphabet[index]);
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }
                motDePasse += "\n";
            }
            Console.WriteLine($"voici le/les mot de passes générés : ");
            Console.WriteLine(motDePasse);
        }
    }
}
