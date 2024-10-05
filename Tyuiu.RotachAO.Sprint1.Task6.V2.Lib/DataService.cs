using tyuiu.cources.programming.interfaces.Sprint1; 
 
namespace Tyuiu.RotachAO.Sprint1.Task6.V2.Lib;

public class DataService : ISprint1Task6V2
{
    public bool CheckHello(string value)
    {
        string CheckString = "Hello";
        bool result = value.Contains(CheckString);
        return result;
    }
}

