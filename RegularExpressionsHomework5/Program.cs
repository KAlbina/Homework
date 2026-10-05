using RegularExpressionsHomework5;
using System.Text.RegularExpressions;

string text1 = "Заказ #123 выполнен [456] успешно, сумма 1500 рублей";

string result1 = RegexTask.RemoveServiceNumbers(text1);

Console.WriteLine(result1);


Console.WriteLine(RegexTask.Checklogin("user_01"));

Console.WriteLine(RegexTask.Checklogin("_user01"));

Console.WriteLine(RegexTask.Checklogin("user_"));


string text3 = "Версия v2beta обновлена 15 раз, build42 устарел, код 404.";

MatchCollection numbers = RegexTask.FindNumbers(text3);

foreach (Match number in numbers)
{
    Console.WriteLine(number.Value);
}


Console.WriteLine(RegexTask.CheckPassword("Abc12345"));
Console.WriteLine(RegexTask.CheckPassword("Abc123!@#"));
