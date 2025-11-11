using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AtakishievRS.Sprint4.Task3.V3.Lib
{
    public class DataService : ISprint4Task3V3
    {
        public int Calculate(int[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                max = Math.Max(max, array[2, i]);
            }
            return max;
        }
    }
}
