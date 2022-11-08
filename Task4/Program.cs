// Программа, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

int[] CreateArray(int length = 8)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(minValue: 0, maxValue: 10);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    Console.Write(value: $"{intArray[0]}");
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write(value: $", {intArray[i]}");
    }
}

int findSecondMax(int[] intArray)
{
    int tempMax = intArray[0];
    int tempSecMax = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if(tempMax<intArray[i])
        {
            tempSecMax = tempMax;
            tempMax = intArray[i];
        }
        else
        {
            if(tempSecMax <= intArray[i] && intArray[i] != tempMax)
            {
                tempSecMax = intArray[i];
            }
        }
    }
    return tempSecMax;
}



Console.Write(value: "random array of length 8 with value 0 and 1: ");
int[]maxArray = CreateArray();
printArray(intArray: maxArray);
Console.Write(value: $": = {findSecondMax(intArray: maxArray)}");


