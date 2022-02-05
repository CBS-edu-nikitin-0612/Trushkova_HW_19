// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Teacher!");
while (true)
{
    Console.WriteLine("\nВведите дату своего рождения:");
    string? dateOfBirthString = Console.ReadLine();

    if (!string.IsNullOrEmpty(dateOfBirthString))
    {
        if (DateTime.TryParse(dateOfBirthString, out DateTime dateOfBirth))
        {
            //Проверка в этом году будет день рождения или в следующем
            int year = DateTime.Now.Year;
            if ((dateOfBirth.Month < DateTime.Now.Month) ||
                (dateOfBirth.Month == DateTime.Now.Month && dateOfBirth.Day < DateTime.Now.Day))
                year++;

            //Создание ближайшей даты дня рождения
            DateTime dateOfBirthThisYear = new DateTime(year, dateOfBirth.Month, dateOfBirth.Day);
            Console.WriteLine($"Ближайший день рождения будет {dateOfBirthThisYear.ToString()}");

            //Расчет количества дней до ближайшей даты дня рождения
            TimeSpan timeSpanBirthday = dateOfBirthThisYear - DateTime.Now;
            Console.WriteLine($"До дня рождения осталось {timeSpanBirthday.Days} дней");
        }
        else Console.WriteLine("Дата введена неправильно");
    }
}
