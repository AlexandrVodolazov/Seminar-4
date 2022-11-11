// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}
bool IsEven(int N)
{
    if (N % 2 == 0) return true;
    return false;
}

bool IsNegative(int N)
{
    if (N < 0) return true;
    return false;
}

int CustomPower(int intBase, int intPower)
{
    if (intPower == 0) return 1;
    if (IsNegative(intPower)) intPower *= -1;
    if (IsEven(intPower))
    {
        int Result = CustomPower(intBase, intPower / 2);
        return Result * Result;
    }
    else return intBase * CustomPower(intBase, intPower - 1);
}


Console.WriteLine("raises number A to natural power B");
int intA = PromptInt("Enter number A: ");
int intB = PromptInt("Enter number B: ");
if (IsNegative(intB)) Console.Write("the degree is: 1/");
else Console.Write("the degree is: ");
Console.WriteLine(CustomPower(intA, intB));

