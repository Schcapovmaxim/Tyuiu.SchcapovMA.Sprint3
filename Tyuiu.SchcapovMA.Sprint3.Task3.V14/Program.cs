using Tyuiu.SchcapovMA.Sprint3.Task3.V14.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task3.V14
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
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы d  на ’ в строке: dgt ghedd bed   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            string str = "dgt ghedd bed";
            
            char chr1 = 'd';
            char chr2 = '’';
            Console.WriteLine("Исходная строка = " + str);
            Console.WriteLine("Символ,который нужно заменить = " + chr1);
            Console.WriteLine("Символ,на который нужно заменить = " + chr2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
             
            Console.WriteLine("Произведение ряда равно = " + ds.ReplaceCharInString(str, chr1, chr2));
            Console.ReadKey();
        }
    }
}
