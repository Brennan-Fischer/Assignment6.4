namespace Assignment6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { {1, 2, 3}, {4, 5, 6}, { 7, 8, 9 } };
            Stack<int> stack = new Stack<int>();





            //Prints old matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Saves all matrix values to stack
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    stack.Push(matrix[i, j]);
                }
            }

            //reassigns matrix values by 90 degrees by using a decreasing inner loop 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    matrix[j, i] = stack.Pop();
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            //Prints new matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
