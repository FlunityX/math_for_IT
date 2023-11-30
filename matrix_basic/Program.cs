namespace matrix_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so hang ma tran :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so cot ma tran :");
            int b = int.Parse(Console.ReadLine());
            int[,] matrix = new int[a, b];
            nhapmatran(a, b, matrix);
            inmatran(a, b, matrix);
            Console.ReadLine();
        }
        static void nhapmatran(int a, int b, int[,] matrix)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("phan tu [{0}],[{1}]", i + 1, j + 1);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void inmatran(int a, int b, int[,] matrix)
        {
            Console.WriteLine(" ma tran do la :");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(matrix[i,j]+"   ");
                }
                  // hết vòng lặp j thì xuống dòng
                Console.WriteLine();
            }
        }
    }
}