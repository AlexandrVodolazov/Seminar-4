// программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray(int length = 8)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(minValue: 0, maxValue: 2);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    Console.Write(value: $"{intArray[0]}");
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write(value: $"{intArray[i]}");
    }
}
Console.Write(value: "random array of length 8 with value 0 and 1: ");
printArray(intArray: CreateArray());


