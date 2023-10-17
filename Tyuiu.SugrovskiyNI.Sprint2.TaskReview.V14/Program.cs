using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint2.TaskReview.V14.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint2.TaskReview.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт Review | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Контрольная sprint2 Review                                                *");
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Вариант #14                                                               *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу которая запрашивает исходные данные                    *");
            Console.WriteLine("* вычисляет, находится ли точка с координатами X,Y в заштрихованной области *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.Write("Введите координату X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = double.Parse(Console.ReadLine());


            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка с координатами (X, Y) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка с координатами (X, Y) не находится в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}
