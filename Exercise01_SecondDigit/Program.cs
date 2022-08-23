/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter three-digit number:");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    int a = (number / 10) % 10;
    return a;
}

Console.WriteLine(SecondDigit(num));