// Программа, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int Prompt(string message)
{
    Console.Write(message + ": ");
    return int.Parse(Console.ReadLine());
}

bool ValidateNumber(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("number must be positive");
        return false;
    }
    return true;
}

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int number = Prompt("Enter digit");
if(ValidateNumber(number))
{
    int sum = SumNumbers(number);
    Console.WriteLine($"sum of numbers from 1 to {number} equals {sum}");
}



