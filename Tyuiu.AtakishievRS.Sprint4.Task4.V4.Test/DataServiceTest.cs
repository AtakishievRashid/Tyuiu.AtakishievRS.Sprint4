using Tyuiu.AtakishievRS.Sprint4.Task4.V4.Lib;
namespace Tyuiu.AtakishievRS.Sprint4.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var expected = new int[,] { { 1, 1 }, { 1, 7 } };
            var input = new int[,] { { 2, 4 }, { 8, 7 } };

            CollectionAssert.AreEqual(expected, ds.Calculate(input));
        }
    }
}
