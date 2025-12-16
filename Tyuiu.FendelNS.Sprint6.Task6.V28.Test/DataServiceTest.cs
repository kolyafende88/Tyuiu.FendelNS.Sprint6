using Tyuiu.FendelNS.Sprint6.Task6.V28.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task6.V28.Test;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCollectTextFromFile()
    {
        var dataService = new DataService();
        string path = @"C:\Users\kolia\source\repos\Tyuiu.FendelNS.Sprint6\TXTs\InPutDataFileTask6V28.txt";
        Assert.AreEqual("wFrlYaZtHI", dataService.CollectTextFromFile(path).Split(' ')[0]);
    }
}