// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

bool Palindrome (int[] array)
{
    int N = array.Length;
    bool result = false;
    for (int i = 0; i < N / 2; i ++)
    {
        if (array[i] != array[N-i-1]) 
        {
            Console.WriteLine ("It's not a palindrome");
            return result;
        }
    }
    result = true;
    
    Console.WriteLine ("This is a palindrome");
    return result;
}


