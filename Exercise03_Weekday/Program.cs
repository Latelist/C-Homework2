/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/




string Weekend(int number)
{
    string weekend = "It's not a weekend.";
    
    while (number > 7)
    {
        int i = number / 7;
        number = number - 7 * (i);
        if (number == 0)
        {
            number = number + 7;
        }
        Console.WriteLine(number);
    }

    if (number == 6 || number == 7)
    {
        weekend = "It's a weekend.";
    }
    return weekend;
}

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Weekend(num));