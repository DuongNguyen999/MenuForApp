internal class Program
{
    private static void Main(string[] args)
    {
        int choice;

        do
        {
            // Bước 2: Hiển thị thông tin menu gồm 3 lựa chọn
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            // Bước 3: Sử dụng cấu trúc switch…case để xử lý các tình huống lựa chọn
            switch (choice)
            {
                case 1:
                    DrawTriangle();
                    break;
                case 2:
                    DrawSquare();
                    break;
                case 3:
                    DrawRectangle();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }
        while (choice != 0);
    }

    // Hàm vẽ tam giác
    static void DrawTriangle()
    {
        Console.WriteLine("Draw the triangle");
        Console.WriteLine("******");
        Console.WriteLine("*****");
        Console.WriteLine("****");
        Console.WriteLine("***");
        Console.WriteLine("**");
        Console.WriteLine("*");
    }

    // Hàm vẽ hình vuông
    static void DrawSquare()
    {
        Console.WriteLine("Draw the square");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("* * * * * *");
        }
    }

    // Hàm vẽ hình chữ nhật
    static void DrawRectangle()
    {
        Console.WriteLine("Draw the rectangle");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("* * * * * *");
        }

    }
}
