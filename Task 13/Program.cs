/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ( n < 100){
    Console.WriteLine($"третьей цифры нет");
}
else
{
    while (n > 999)
    {
        n = n / 10;
    }
    n= n % 10;
    Console.WriteLine(n);
}    

/*
//  Нерабочий код "Идеального решения"...
int Prompt(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int nember = Prompt("Введите число > ");
    if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}
*/



