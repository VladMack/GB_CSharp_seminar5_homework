using System;
using System.Linq;

Console.Clear();
int[] numbers = genetateArray(10, 0, 99);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Разность максимального и минимального элементов массива: {findMax(numbers) - findMin(numbers)}.");

int[] genetateArray(int size, int mixValue, int maxValue)
{
    int[] generatedArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return generatedArray;
}

int findMin(int[] numArr)
{
    int min = numArr.Min();
    return min;
}

int findMax(int[] numArray)
{
    int max = numArray.Max();
    return max;
}