using Tyuiu.RotachAO.Sprint1.Task5.V6.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task5.V6; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #1 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #1                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #6                                                           *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную k:"); 
        int k = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        DataService ds = new DataService();
        int res = ds.Calculate(k);
        Console.WriteLine($"Ответ = {res}");
        Console.ReadKey();
    } 
} 
