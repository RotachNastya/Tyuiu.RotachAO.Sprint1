using Tyuiu.RotachAO.Sprint1.Task0.V13.Lib;

namespace Tyuiu.RotachAO.Sprint1.Task0.V13.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}