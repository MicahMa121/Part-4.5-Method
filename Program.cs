namespace Part_4._5_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawBear();
            int x = 0;
            int y = 0;
            Console.WriteLine("Enter the x coordinate");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Enter the y coordinate");
            int.TryParse(Console.ReadLine(), out y);
            DrawBear(x,y);
            Console.ReadLine();
            Console.Clear();
            Jokes();
        }

        public static void DrawBear(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" __         __");
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine("/  \\.-\"\"\"-./  \\");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("\\    -   -    /");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(" |   o   o   |");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(" \\  .-'''-.  /");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("  '-\\__Y__/-'");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("     `---`");
        }
        public static void DrawBear()
        {

            Console.WriteLine(" __         __");

            Console.WriteLine("/  \\.-\"\"\"-./  \\");

            Console.WriteLine("\\    -   -    /");

            Console.WriteLine(" |   o   o   |");

            Console.WriteLine(" \\  .-'''-.  /");

            Console.WriteLine("  '-\\__Y__/-'");
            Console.WriteLine("     `---`");
        }
        public static void Jokes()
        {
            Console.WriteLine("Knock, knock.");
            Thread.Sleep(500);
            Console.WriteLine("Who's there?");
            Thread.Sleep(500);
            Console.WriteLine("Tank.");
            Thread.Sleep(500);
            Console.WriteLine("Tank who?");
            Thread.Sleep(500);
            Console.WriteLine("You’re welcome.");
        }
    }
}
