namespace đường_chéo_chính_va_ma_tran_cheo
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
            duongcheochinh(a, b, matrix);
            bool ismatrancheo = matrancheo(a, b, matrix);
            Console.WriteLine(ismatrancheo ? "day la ma tran cheo " : " day ko la ma tran cheo ");
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
                    Console.Write(matrix[i, j] + "   ");
                }
                // hết vòng lặp j thì xuống dòng
                Console.WriteLine();
            }
        }
        static void duongcheochinh(int a, int b, int[,] matrix)
        {
            Console.Write(" duong cheo chinh cua ma tran la : ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (matrix[i, j] == matrix[i, i])
                    {
                        Console.Write(matrix[i, j] + "   ");
                    }
                }
            }
        }
        static bool matrancheo(int a, int b, int[,] matrix)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                   
                    if (matrix[i,j] != matrix[i, i])
                    {
                        if (matrix[i,j]!= 0)
                        {
                            return false;
                        }
                         
                    }
                }
            }
            return true;
           
        }
    }
}