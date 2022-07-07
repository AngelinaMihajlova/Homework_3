// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write ("Enter a Number To Check Palindrome : ");

int number = int.Parse(Console.ReadLine());
int remineder, sum = 0;
int temp = number;

while (number > 0)
{
    remineder = number % 10;
    sum = (sum * 10) + remineder;
    number = number / 10; 
}
            
    if (temp == sum)
    {
        Console.WriteLine ($"Number {temp} is Palindrome.");
    }
    else
    {
        Console.WriteLine($"Number {temp} is not Palindrome");
    }
        Console.ReadKey();
        