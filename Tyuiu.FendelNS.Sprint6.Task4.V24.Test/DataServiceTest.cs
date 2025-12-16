using Tyuiu.FendelNS.Sprint6.Task4.V24.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(1, 3);
            double[] wait = { -3.3, -5.53, -6.25 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}