// Программа, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции: 
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8


int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max + 1);
    }
    return tempArray;
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

System.Console.WriteLine("output an array of 8 elements filled with random numbers.");
int intN = PromptInt("Enter the size of the array - N: ");
int intMin = PromptInt("Enter the minimum value of the random number - Min: ");
int intMax = PromptInt("Enter the maximum value of the random number - Max: ");

System.Console.Write($"Random array of length {intN} with values from {intMin} to {intMax}: ");
int[] maxArray = CreateArray(intN, intMin, intMax);
PrintArray(maxArray);


