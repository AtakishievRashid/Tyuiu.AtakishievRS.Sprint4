using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AtakishievRS.Sprint4.Task5.V5.Lib
{
    public class DataService : ISprint4Task5V5
    {
        public int Calculate(int[,] matrix)
        {
            int RowsOfArray = matrix.GetLength(0);
            int ColumnsOfArray = matrix.GetLength(1);
            int Result = 0;

            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        Result += matrix[i, j];
                    }
                }
            }

            return Result;
        }
    }
}
