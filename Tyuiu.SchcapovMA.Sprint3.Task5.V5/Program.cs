using Tyuiu.SchcapovMA.Sprint3.Task5.V5.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Щапов М.А. | ИБКСб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенный цикл for, которая вычисляет      *");
            Console.WriteLine("* сумму сумм ряда по формуле: 3      10                                   *");
            Console.WriteLine("*                            ----   ----                                  *");
            Console.WriteLine("*                            \\      \\         x                         *");
            Console.WriteLine("*                             |      |        -----                       *");
            Console.WriteLine("*                            /      /        sin(k)                       *");
            Console.WriteLine("*                           ----    ----                                  *");
            Console.WriteLine("*                           i=1     k=1                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма сумм ряда равна = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
