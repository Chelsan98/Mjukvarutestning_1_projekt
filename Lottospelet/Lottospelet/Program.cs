using Lottospelet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Projektuppgift Grupp 5
// Therese Lissel, Maria Lyrberg, Markus Nygren
// Projekt uppgift med AnnaMaria och Markus för Mjukvarutestning 1

namespace LottospeletDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<IKonto, Betalning> output = Spel.SkapaKonto("LifeSux", "BraLösenOrd", "Spelare");
            Dictionary<IKonto, Betalning> output1 = Spel.SkapaKonto("BeAfraid", "MerBraLösenord", "Prenumerant");            

            Spel.SkrivUt(output);
            Spel.SkrivUt(output1);
            Console.WriteLine("\n\tInloggning: {0}", Spel.LoggaIn("LifeSux", "BraLösenOrd") ? "Lyckades" : "Misslyckades");

            Dictionary<int, int[]> LottoDict = spelaLotto.SkapaLottorad();
            spelaLotto.SkrivUt(LottoDict);
            Console.ReadLine();
            Lotteri.RaderaLottoRader(LottoDict, true);
            Console.ReadLine();
            spelaLotto.SkrivUt(LottoDict);
            Console.ReadLine();
        }        
    }    
}
