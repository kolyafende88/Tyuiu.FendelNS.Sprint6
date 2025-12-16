using Tyuiu.FendelNS.Sprint6.Task5.V3.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\Tyuiu.FendelNS.Sprint6\TXTs";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 2.5, -2.6, 5.7, -6.8, 9.9 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}