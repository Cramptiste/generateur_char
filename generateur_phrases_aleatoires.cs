using System;

namespace Program
{

    
    class Program
    {
        static string ObtenirElementAleatoire(List<string> t)
        {
            Random rand = new Random();
            
            string resultat = t[rand.Next(0, t.Count)];
            return resultat;

        }
        static void Main(string[] args)
        {
            var sujets = new List<string> { "un lapin", "une grand-mère", "un chat", "un oiseau", "une souris", "un homme", "une tortue" };
            var verbes = new List<string> { "mange", "écrase", "détruit", "observe", "attrape", "regarde", "avale", "néttoie", "se bat avec", "s'accroche à" };
            var complements = new List<string> { "un arbre", "un livre", "la lune", "le soleil", "un serpent", "une carte", "une girafe", "le ciel", "la piscine", "un gateau", "une souris", "un crapaud" };
            const int NB_PHRASES = 100;
            var listeDePhrases = new List<string>();
            var phrase = "";
            int doublons = 0;
            int PhrasesUniques = 0;

            for (int i = 0; i < NB_PHRASES; i++)
            {

                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);
                phrase = sujet + " " + verbe + " " + complement;

                phrase = phrase.Replace("à le", "au");
                listeDePhrases.Add(phrase);
            }
            for (int i = 0; i < listeDePhrases.Count; i++)
            {
                if (phrase == listeDePhrases[i])
                {
                    doublons++;
                    continue;
                }
                Console.WriteLine(listeDePhrases[i]);
                PhrasesUniques++;

            }

            
            Console.WriteLine();
            Console.WriteLine("Doublons évités : " + doublons);
            Console.WriteLine("Nombre de phrase uniques : " + PhrasesUniques);
        }
    }
}
