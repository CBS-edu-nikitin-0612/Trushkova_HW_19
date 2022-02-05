// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, Teacher!");

Post employee1 = new Post("Ivanov", "CEO");
int hours = 10;
bool isBonus = Accountant.AskForBonus(employee1, hours);

if (isBonus)
    Console.WriteLine("Сотруднику положена премия");
else
    Console.WriteLine("Сотруднику не положена премия");
