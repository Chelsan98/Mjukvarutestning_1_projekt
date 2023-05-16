using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottospelet
{
     class spelaLotto
    {
        private static string AnvändarNamn { get; set; }
        private static string Lösenord { get; set; }
        private static string KontoTyp { get; set; }

        public static bool LoggaIn(string namn, string lösenord)
        {
            if (externalIDTjänst.lyckadInloggning())
                return true;
            else return false;

        }
        public static void SkapaKonto(string namn, string lösenord, string konto)
        {
            Console.WriteLine("Här skapar användaren sitt konto");
        }
        public static Dictionary<int, int[]> SkapaLottorad()
        {
            Lotteri lotteri = new Lotteri();
            Dictionary<int, int[]> LottoDict = lotteri.SkapaDict();
            return LottoDict;
        }
        public static void LoggaUt()
        {
            Console.WriteLine("Här ska användaren logga ut");
        }
        public static void RaderaKonto()
        {
            Console.WriteLine("Här ska användaren kunna radera sitt konto");
        }
        public static void SkrivUt(Dictionary<int, int[]> LottoDict)
        {
            Console.WriteLine("Skriver ut:");
            if (LottoDict.Count == 0) // kollar om Lottodict är tom, är den det så skrivs texten ut
            {
                Console.WriteLine("Det finns inga lottorader!");
            }
            else
            {
                foreach (KeyValuePair<int, int[]> lotter in LottoDict)
                {
                    Console.Write("Key: {0}  \tValue: ", lotter.Key);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("{0}, ", lotter.Value[i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
