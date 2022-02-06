// See https://aka.ms/new-console-template for more information
using Task2; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

//Вывод списка цветов по умолчанию
Console.WriteLine("Список цветов:");
Array namesColor = Enum.GetValues(typeof(ColorText));

for (int i = 0; i < namesColor.Length; i++)
{ 
    Console.WriteLine("Название цвета: {0}, номер: {0:D}", namesColor.GetValue(i));
}

while (true)
{
    try
    {
        //Получение строки от пользователя
        Console.WriteLine("\nВведите строку:");
        string? stroka = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(stroka))
        {
            //Изменение цвета текста путем ввода названия цвета на английском или по номеру
            Console.WriteLine("Введите название цвета на английском или его номер:");
            
            string? color = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(color))
            {
                if (Enum.TryParse(typeof(ColorText), color, true, out object? colorText) && colorText != null
                    && Enum.IsDefined(typeof(ColorText), colorText))                    
                    //Вывод строки с указанным цветом
                    Printer.Print(stroka, (int)colorText);

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