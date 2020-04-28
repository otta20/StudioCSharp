using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace MorraCinese
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        // Funzioni date
        static bool IsEqualToNumber(string stringToVerify, int targetNumber)
        {
            int parsedInt;
            return int.TryParse(stringToVerify, out parsedInt) &&
                   parsedInt == targetNumber;
        }
        
        private static int GetRandomNumber(int minInclusive, int maxInclusive)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return random.Next(minInclusive, maxInclusive + 1);
        }
    }
}
