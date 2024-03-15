namespace GBHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            Sort2dArray(a);
            Show2dArray(a);

        }
        static void Sort2dArray(int[,] array)
        {
            int[] newArr = array.Cast<int>().Order().ToArray();

            for(int i = 0, newArrIndx = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0;  j < array.GetLength(1); j++)
                {
                    array[i,j] = newArr[newArrIndx];
                    newArrIndx++;
                }
            }

        }
        static void Show2dArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
