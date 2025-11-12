using Tyuiu.AtakishievRS.Sprint4.Task5.V5.Lib;
namespace Tyuiu.AtakishievRS.Sprint4.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { { 1, -5, 3 },
                                           { 2, -5, 4 },
                                           { 3, -5, 5 } };
            int res = ds.Calculate(matrix);
            int wait = 18;

            Assert.AreEqual(wait, res);
        }
    }
}
