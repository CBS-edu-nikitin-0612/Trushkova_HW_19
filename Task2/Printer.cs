namespace Task2
{
    internal static class Printer
    {
        public static void Print(string stroka, int color)
        {            
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
