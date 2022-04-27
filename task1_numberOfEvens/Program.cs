using System;
using System.Linq;

Console.Clear();
int[] numbers = genetateArray(10, 100, 999);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Число чётных элементов в массиве: {countEvens(numbers)}.");

int[] genetateArray(int size, int mixValue, int maxValue)
{
    int[] generatedArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return generatedArray;
}

int countEvens(int[] numArray)
{
    int counter = numArray.Where(x => x % 2 == 0).Count();
    return counter;
}