// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, Teacher!");
while (true)
{
    try
    {
        Console.WriteLine("\nВведите строку:");
        string? stroka = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(stroka))
        {
            //Изменение цвета текста путем ввода названия цвета на английском
            Console.WriteLine("Введите название цвета на английском:");
            string? color = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(color))
            {
                if (Enum.TryParse(typeof(ColorText), color, true, out object? colorText) && colorText != null)
                    Printer.Print(stroka, (int)(ColorText)colorText);
                else throw ExceptionColor.ExceptionNoColor;
            }
            else
            {
                throw ExceptionColor.ExceptionNoText;
            }

            //Изменение цвета текста путем ввода номера цвета
            Console.WriteLine("Введите номер названия цвета:");
            string? colorNum = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(colorNum))
            {
                int colorNumInt = Convert.ToInt32(colorNum);
                object? colorNumObj = Enum.ToObject(typeof(ColorText), colorNumInt);
                if (colorNumObj != null && Enum.IsDefined(typeof(ColorText), colorNumObj))
                {
                    ColorText colorNumCol = (ColorText)colorNumObj;
                    Printer.Print(stroka, (int)colorNumCol);
                }
                else throw ExceptionColor.ExceptionNoColor;
            }
            else
            {
                throw ExceptionColor.ExceptionNoText;
            }
        }
    }
    catch (Exception ex)
    {
        ExceptionColor.ShowException(ex);
    }
}