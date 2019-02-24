//Александр Копчиков. Lesson 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Написать метод, возвращающий минимальное из трёх чисел.

//namespace Lesson1_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string x1String, x2String, x3String;
//            int x1, x2, x3;

//            //Пользовательский ввод и преобразование значений
//            Console.WriteLine("Введите 3 числа для сравнения.");

//            Console.WriteLine("Первое число: ");
//            x1String = Console.ReadLine();
//            x1 = Convert.ToInt32(x1String);

//            Console.WriteLine("Второе число: ");
//            x2String = Console.ReadLine();
//            x2 = Convert.ToInt32(x2String);

//            Console.WriteLine("Третье число: ");
//            x3String = Console.ReadLine();
//            x3 = Convert.ToInt32(x3String);

//            //Нахождение наибольшего значения

//            int max = (x1 > x2 && x1 > x3) ? x1 : ((x2 > x3) ? x2 : x3);
//            Console.WriteLine($"Наибольше число равно: {max}");


//            Console.ReadKey();
//        }
//    }
//}

//2. Написать метод подсчета количества цифр числа.
//namespace Lesson2_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string x1String;
//            int x1;

//            //Пользовательский ввод и преобразование значений
//            Console.WriteLine("Эта программа подсчитывает количество цифр числа. Введите натуральное целое число: ");

//            x1String = Console.ReadLine();
//            x1 = Convert.ToInt32(x1String);

//            //Нахождение количесвта циифр в числе

//            int i = 0;
//            while (x1 > 0)
//            {
//                x1 = x1 / 10;
//                i++;
//            }
//            Console.WriteLine($"Количество цифр в числе равно: {i}");


//            Console.ReadKey();
//        }
//    }
//}

//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных
//namespace Lesson2_3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string x1String;
//            int x1 = 1;
//            int sum = 0;
//            //Пользовательский ввод и преобразование значений
//            Console.WriteLine("Эта программа подсчитывает сумму всех введенных чисел.\nВводите числа которые нужно скложить.\nДля вывода результата введите 0:");
//            while (x1 != 0)
//            {
//            x1String = Console.ReadLine();
//            x1 = Convert.ToInt32(x1String);
//            sum = sum + x1;
//            }
//            Console.WriteLine($"Сумма чисел равна: {sum}");

//            Console.ReadKey();
//        }
//    }
//}

//4. Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На
//выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
//GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
//вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
//цикла do while ограничить ввод пароля тремя попытками.

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных и пользовательский ввод данных
            string LoginInput, PasswordInput;

            string LoginTrue = "имя";
            string PasswordTrue = "пароль";

            Console.WriteLine("Для работы в системе пройдите авторизацию.\nВведите свой логин: ");
            LoginInput = Console.ReadLine();
            Console.WriteLine("пароль: ");
            PasswordInput = Console.ReadLine();

            {
                if (LoginInput == LoginTrue)
                {
                    if (PasswordInput == PasswordTrue)
                    {
                        Console.WriteLine($"Авторизация пользователя {LoginInput} прошла успешно.");
                    }
                    else if (i < 3)
                    {
                        i++;
                        Console.WriteLine($"Введен неверный пароль. Повторите ввод пароля. Осталось {3 - i} попыток.");
                    } else Console.WriteLine($"Введен неверный пароль. Доступ к системе заблокированля. Осталось {3 - i} попыток.");
                }
                else
                {
                    Console.WriteLine($"Введены неверные учетыне данные.");
                }

                Console.ReadKey();
            }
        }
    }
}
