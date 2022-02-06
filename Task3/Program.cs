// See https://aka.ms/new-console-template for more information
using Task3; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

Post employee1 = new Post("Ivanov", "CEO");
int hours = 10;

//Проверятся дадут ли премию сотруднику или нет исходя из его должности и соответствующих отработанных часов в неделю
bool isBonus = Accountant.AskForBonus(employee1, hours);

if (isBonus)
    Console.WriteLine("Сотруднику положена премия");
else
    Console.WriteLine("Сотруднику не положена премия");
