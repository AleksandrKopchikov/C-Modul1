using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JoinJob
{
    /// <summary>
    /// Уровень игры
    /// </summary>
    enum GameLevel
    {
        /// <summary>
        /// Легкий уровень
        /// </summary>
        Easy = 5,

        /// <summary>
        /// Средний уровень
        /// </summary>
        Medium = 10,

        /// <summary>
        /// Сложный уровень
        /// </summary>
        Hard = 20
    }


    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {

            #region Пример 8 v 2.1

            GameLevel level = GameLevel.Easy;
            Game.CreateNps((int)level, " * ");

            level = GameLevel.Medium;
            Game.CreateNps2(1,(int)level, " + ");

            level = GameLevel.Hard;
            Game.CreateNps((int)level, " - ");

            #endregion
            #region Пример 8 v 2.0

            //GameLevel level = GameLevel.Medium;

            ////int lvl = 3;//1-easy, 2-medium, 3-hard

            //if (level == GameLevel.Easy)
            //{
            //    CreateNps(5);
            //}
            //else
            //{
            //    if (level == GameLevel.Medium)
            //    {
            //        CreateNps(10);
            //    }
            //    else
            //    {
            //        CreateNps(20);
            //    }
            //}


            #endregion

            #region Пример 11


            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 3 == 0) continue;
            //    Console.Write($"{i} ");
            //}


            //while (true)
            //{
            //    Console.Write("* ");
            //    break;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 4) break;
            //    Console.Write($"{i} ");
            //}


            #endregion

            #region Пример 10

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        if (j == 1) break;
            //        for (int k = 1; k <= 3; k++)
            //        {
            //            Console.WriteLine($"[{i}, {j}, {k}]");
            //            if (k == 2) break;
            //        }

            //    }
            //}


            #endregion

            #region Пример 9

            //Console.Write("for Введите n: ");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int i;
            //for (i = n; i <= 10; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            //Console.Write("\n\nwhile Введите n: ");

            //n = Convert.ToInt32(Console.ReadLine());

            //i = n;

            //while (i <= 10)
            //{
            //    Console.Write($"{i} ");
            //    i++;
            //}

            //Console.Write("\n\ndo-while Введите n: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //i = n;

            //if (i <= 10)
            //{
            //    do
            //    {
            //        Console.Write($"{i} ");
            //        i++;
            //    } while (i <= 10);
            //}

            #endregion

            #region Пример 8

            //GameLevel level = GameLevel.Medium;

            ////int lvl = 3;//1-easy, 2-medium, 3-hard

            //if (level == GameLevel.Easy)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.Write(" + ");
            //    }
            //}
            //else
            //{
            //    if (level == GameLevel.Medium)
            //    {
            //        int i = 0;

            //        while (i < 10)
            //        {
            //            Console.Write(" + ");
            //            i = i + 1;
            //        }
            //    }
            //    else
            //    {
            //        int i = 0;
            //        do
            //        {
            //            Console.Write(" + ");
            //            i = i + 1;
            //        } while (i < 10);
            //    }
            //}


            #endregion

            #region Пример 7

            //GameLevel level = GameLevel.Medium;

            ////int lvl = 3;//1-easy, 2-medium, 3-hard

            //if (level == GameLevel.Easy)
            //{
            //    Console.Write(" + ");
            //    Console.Write(" + ");
            //    Console.Write(" + ");
            //    Console.Write(" + ");
            //    Console.Write(" + ");
            //}
            //else
            //{
            //    if(level == GameLevel.Medium)
            //    {
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //    }
            //    else
            //    {
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //        Console.Write(" + ");
            //    }
            //}


            #endregion

            #region  Пример 6

            //Console.Write("Введите Ваше имя: ");

            //string name = Console.ReadLine();


            //switch (name.ToLower())
            //{
            //    case "роман": 
            //    case  "Саша":
            //        Console.WriteLine($"Я так ждала Вас, {name}! :-)");
            //        break;

            //    case "иван":
            //        Console.WriteLine($"Хооо хоооо, {name}! :-) Какие люди!");
            //        break;

            //    default:
            //        Console.WriteLine($"Привет, {name}! :-(");
            //        break;
            //}

            //if (
            //    name == "Роман"
            //    || name == "Саша"
            //    )
            //{
            //    // выполняется, если <условие> истино
            //    Console.WriteLine($"Я так ждала Вас, {name}! :-)");
            //}
            //else
            //{
            //    if (name == "Иван")
            //    {
            //        // выполняется, если <условие> истино
            //        Console.WriteLine($"Хооо хоооо, {name}! :-) Какие люди!");
            //    }
            //    else
            //    {
            //        // выполняется, если <условие> ложно
            //        Console.WriteLine($"Привет, {name}! :-(");
            //    }
            //}
            #endregion

            #region   Пример 5

            //int a = 1, b = 2, c = 3;
            //int max;

            //if (a > b && a > c) { max = a; }
            //else if (b > c) { max = b; }
            //else { max = c; }

            //max = (a > b && a > c) ? a : ((b > c) ? b : c);

            #endregion

            #region  Пример 4

            //Console.Write("Введите первое число: ");
            //int valueA = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int valueB = Convert.ToInt32(Console.ReadLine());

            //int max = 0;

            //if (valueA > valueB) max = (valueA);
            //else max = (valueB);

            //max = valueA > valueB ? valueA : valueB;

            //Console.WriteLine(max);

            #endregion

            #region Пример 3 

            //int n = 123;

            //if (n % 2 == 0) Console.WriteLine("Да");
            //else Console.WriteLine("Нет");

            //string result = n % 2 == 0 ? "Да" : "Нет";

            //Console.WriteLine(result);

            //Console.WriteLine(n % 2 == 0 ? "Да" : "Нет");





            #endregion

            #region Привет 2


            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine( Helper.IsOdd(n));

            #endregion

            #region Пример 1

            //if (Console.ReadKey(true).KeyChar == 'y') Console.WriteLine("Доступ разрешён");
            //else Console.WriteLine("Доступ ! разрешён");

            //Console.Write("Введите Ваше имя: ");

            //string name = Console.ReadLine();

            //if (
            //    name == "Роман"
            //    || name == "Саша"
            //    )
            //{
            //    // выполняется, если <условие> истино
            //    Console.WriteLine($"Я так ждала Вас, {name}! :-)");
            //}
            //else if (name == "Иван")
            //{
            //    // выполняется, если <условие> истино
            //    Console.WriteLine($"Хооо хоооо, {name}! :-) Какие люди!");
            //}
            //else
            //{
            //    // выполняется, если <условие> ложно
            //    Console.WriteLine($"Привет, {name}! :-(");
            //}

            Console.ReadKey();              // задержка черного экрана

            #endregion

        }

        
    }
}