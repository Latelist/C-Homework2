/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void PrintThirdDigit(int number)
{
    if (number / 100 == 0)
    {
        Console.WriteLine("There is no third digit");
    }
    else
    {
        while (number >= 1000)
        {
            number = number / 10;
        }
        int third_digit = number % 10;
        Console.WriteLine($"Third digit is {third_digit}");
    }
}


Console.WriteLine("Enter number: ");
int numb = Convert.ToInt32(Console.ReadLine());

PrintThirdDigit(numb);