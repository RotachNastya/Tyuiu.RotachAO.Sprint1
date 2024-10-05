using Tyuiu.RotachAO.Sprint1.Task6.V2.Lib; 
 
namespace Tyuiu.RotachAO.Sprint1.Task6.V2.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string k = "Hello";
        DataService ds = new DataService();
        bool res = ds.CheckHello(k);
        Assert.AreEqual(res, true);
    } 
} 
