using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    class Program
    {  /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     *  8
       UDDDUDUU
     */

        public static int countingValleys(int steps, string path)
        {
            int count = 0;
            int numberValley = 0;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'D')
                {
                    count--;
                }
                else
                {
                    count++;
                }
                if (count==0 &&path[i] =='U')
                {
                    numberValley++;
                }
            }

           

            return numberValley;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Program.countingValleys(steps, path);

            Console.WriteLine(result);

         
        }
    }

}