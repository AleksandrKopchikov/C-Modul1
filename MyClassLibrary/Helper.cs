using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Helper
    {

        public static string IsOdd(int n)
        {
            if (n % 2 == 0) return ("Да");
            else return ("Нет");
        }

        static public void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

    }
}
