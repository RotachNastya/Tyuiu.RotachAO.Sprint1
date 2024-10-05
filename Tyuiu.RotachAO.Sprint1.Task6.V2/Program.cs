using Tyuiu.RotachAO.Sprint1.Task6.V2.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task6.V2; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #1 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #1                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #2                                                           *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите строку"); 
        string k = Convert.ToString(Console.ReadLine()!);
        DataService ds = new DataService();
        bool res = ds.CheckHello(k);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Ответ = {res}");
        Console.ReadKey();
    } 
} 
