namespace Task2
{
    internal static class ExceptionColor
    {
        public static Exception ExceptionNoColor { get;}
        public static Exception ExceptionNoText { get; }

        static ExceptionColor()
        {
            ExceptionNoColor = new Exception("Такого цвета текста нет в данном принтере");
            ExceptionNoText = new Exception("Вы ничего не ввели");
        }

        public static void ShowException(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ex.Message.ToString());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
