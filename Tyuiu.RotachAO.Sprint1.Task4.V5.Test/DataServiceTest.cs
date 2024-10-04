using Tyuiu.RotachAO.Sprint1.Task4.V5.Lib; 
 
namespace Tyuiu.RotachAO.Sprint1.Task4.V5.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        double x = 1;
        double y = 9;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(0.25, res);
    } 
} 
