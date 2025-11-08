using Tyuiu.AtakishievRS.Sprint4.Task1.V14.Lib;
namespace Tyuiu.AtakishievRS.Sprint4.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, new DataService().Calculate([3, 4, 2, 0, 1, 7, 1, -2]));
        }
    }
}
