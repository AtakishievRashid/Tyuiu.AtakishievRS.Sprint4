using Tyuiu.AtakishievRS.Sprint4.Task2.V21.Lib;
namespace Tyuiu.AtakishievRS.Sprint4.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            int[] array = { 2, 3, 4, 5, 6 }; 

            int result = ds.Calculate(array);

            Assert.AreEqual(48, result);
        }
    }
}
