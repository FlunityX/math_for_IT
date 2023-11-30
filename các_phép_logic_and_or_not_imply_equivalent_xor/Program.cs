using System;

class HelloWorld
{
    static void Main()
    {
        int userInput;
        int userInput1;

        while (true)
        {
            Console.WriteLine("Nhập giá trị đầu tiên (0 hoặc 1):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userInput))
            {
                if (userInput == 0 || userInput == 1)
                {
                    break; // Giá trị hợp lệ, thoát khỏi vòng lặp
                }
            }
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }

        while (true)
        {
            Console.WriteLine("Nhập giá trị thứ hai (0 hoặc 1):");
            string input1 = Console.ReadLine();

            if (int.TryParse(input1, out userInput1))
            {
                if (userInput1 == 0 || userInput1 == 1)
                {
                    break; // Giá trị hợp lệ, thoát khỏi vòng lặp
                }
            }
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }

        // Phủ định (NOT)
        int notA = userInput == 0 ? 1 : 0;
        int notB = userInput1 == 0 ? 1 : 0;

        // Hội (AND)
        int andResult = userInput & userInput1;

        // Tuyển (OR)
        int orResult = userInput | userInput1;

        // Kéo theo (IMPLY)
        int implyResult = (notA == 0 ? 1 : 0) | userInput1;

        // Tương đương (EQUIVALENT)
        int equivalentResult = (userInput == userInput1) ? 1 : 0;

        // Tuyển loại (XOR)
        int xorResult = userInput ^ userInput1;

        Console.WriteLine("Phủ định (NOT):");
        Console.WriteLine($"!{userInput} = {notA}");
        Console.WriteLine($"!{userInput1} = {notB}");

        Console.WriteLine("\nHội (AND):");
        Console.WriteLine($"{userInput} && {userInput1} = {andResult}");

        Console.WriteLine("\nTuyển (OR):");
        Console.WriteLine($"{userInput} || {userInput1} = {orResult}");

        Console.WriteLine("\nKéo theo (IMPLY):");
        Console.WriteLine($"{notA} => {userInput1} = {implyResult}");

        Console.WriteLine("\nTương đương (EQUIVALENT):");
        Console.WriteLine($"{userInput} <=> {userInput1} = {equivalentResult}");

        Console.WriteLine("\nTuyển loại (XOR):");
        Console.WriteLine($"{userInput} ^ {userInput1} = {xorResult}");

        Console.ReadLine();
    }
}