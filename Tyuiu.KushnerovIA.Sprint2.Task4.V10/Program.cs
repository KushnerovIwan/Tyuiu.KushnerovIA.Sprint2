using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint2.Task4.V10.Lib;

namespace Tyuiu.KushnerovIA.Sprint2.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Кушнеров И. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Кушнеров Иван Антонович | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь                 *");
            Console.WriteLine("* вводит значение переменных x, y c клавиатуры,                           *");
            Console.WriteLine("* если (x*2)<(y+3), то z=Math.Pow((1+3/(y*y)), x), иначе z=(y+10*x)-(5/x) *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
