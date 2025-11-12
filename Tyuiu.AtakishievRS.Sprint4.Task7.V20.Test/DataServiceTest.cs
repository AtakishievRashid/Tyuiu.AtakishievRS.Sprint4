using Tyuiu.AtakishievRS.Sprint4.Task7.V20.Lib;
namespace Tyuiu.AtakishievRS.Sprint4.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "357951248632587";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 6144;
            Assert.AreEqual(wait, res);
        }
    }
}
