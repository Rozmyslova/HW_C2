
class Program

{

    static void Main(string[] args)

    {

        int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        PrintArray(array);
        Console.WriteLine();
        BubbleSort(array);
        PrintArray(array);


        void BubbleSort(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < rows; k++)
                    {
                        for (int l = 0; l < columns; l++)
                        {
                            if (array[i, j] < array[k, l])
                            {
                                int temp = array[i, j];
                                array[i, j] = array[k, l];
                                array[k, l] = temp;
                            }
                        }
                    }
                }
            }
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

