using Tyuiu.RotachAO.Sprint1.Task1.V19.Lib; 
 
namespace Tyuiu.RotachAO.Sprint1.Task1.V19.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        double x = 1.0;
        double y = 2.0;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(-1, res);
   } 
} 
