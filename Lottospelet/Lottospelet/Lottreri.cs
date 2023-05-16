using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottospelet
{
    public class Lotteri
    {
        private Lottorad lottorad { get; set; } = new Lottorad();

        public Dictionary<int, int[]> SkapaDict()
        {
            Dictionary<int, int[]> LottoDict = new Dictionary<int, int[]>();
            lottorad.SkapaLottoRad(1);
            for (int i = 2; i < 21; i++)
            {
                LottoDict = lottorad.SkapaLottoRad(i);
            }
            return LottoDict;
        }
        public static void SkapaDragning()
        {
            // här ska dragningen ske
        }
        public static Dictionary<int, int[]> RaderaLottoRader(Dictionary<int, int[]> keyValuePairs, bool isItTime)
        {
            if (isItTime)
            {
                keyValuePairs.Clear();
                Console.WriteLine("Raderna är raderade!");
            }
            return keyValuePairs;
        }
    }
}
