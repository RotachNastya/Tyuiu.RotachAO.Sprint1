using Tyuiu.RotachAO.Sprint1.Task5.V6.Lib; 
 
namespace Tyuiu.RotachAO.Sprint1.Task5.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        int k = 8;
        DataService ds = new DataService();
        int res = ds.Calculate(k);
        Assert.AreEqual(1, res);

   } 
} 
