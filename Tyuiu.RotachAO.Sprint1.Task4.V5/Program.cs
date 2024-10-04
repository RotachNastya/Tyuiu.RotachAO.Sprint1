using Tyuiu.RotachAO.Sprint1.Task4.V5.Lib;

namespace Tyuiu.BarbashinAV.Sprint1.Task2.V12;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Ротач. А. О. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #4                                                         *");
        Console.WriteLine("* Вариант #5                                                         *");
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Введите переменную X:");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную Y:");
        int y = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        double res = ds.Calculate(x, y);
        Console.WriteLine($"Ответ = {res} ");
        Console.ReadKey();
    }
}
