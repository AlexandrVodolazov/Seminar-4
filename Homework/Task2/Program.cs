// Программа, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

bool IsNegative(int N)
{
    if (N < 0) return true;
    return false;
}


int SumOfDigits(int intN)
{
    Console.Write($"the sum of the digits of the number is {intN} equals: ");
    if (IsNegative(intN)) intN *= -1;
    int result = 0;
    while (intN > 0)
    {
        result += intN % 10;
        intN /= 10;
    }
    return result;
}

Console.WriteLine("calculate the sum of the digits in a number");
int intN = PromptInt("Enter positive number: ");
int result = SumOfDigits(intN);
Console.WriteLine(result);

