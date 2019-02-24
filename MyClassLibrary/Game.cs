using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Game
    {
        public static void CreateNps(int Step, string m)
        {
            for (int i = 0; i < Step; i++)
            {
                Console.Write(m);
            }
            Console.WriteLine();
        }

        public static void CreateNps2(int Start, int Step, string m)
        {
            if(Start<=Step)
            {
                Console.Write(m);
                CreateNps2(Start + 1, Step, m);
            }
            if (Start == 1) Console.WriteLine();
        }
    }
}
