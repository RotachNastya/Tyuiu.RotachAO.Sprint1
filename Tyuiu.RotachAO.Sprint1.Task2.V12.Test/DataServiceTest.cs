using Tyuiu.RotachAO.Sprint1.Task2.V12.Lib; 
 
namespace Tyuiu.RotachAO.Sprint1.Task2.V12.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        int x = 2;
        int y = 3;
        int z = 4;
        var res = ds.CalculateParallelepipedVolume(x, y, z);
        Assert.AreEqual(24, res);
    } 
} 
