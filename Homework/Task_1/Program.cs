/*Задача 1: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    Console.WriteLine(message);
    while (!isCorrect)
    {
        isCorrect = int.TryParse(Console.ReadLine(), out result);
        if (!isCorrect)
        {
            Console.WriteLine($"Ввели не число или оно слишком большое. Введите корректное число \n");
        }
    }
    return result;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    Random number = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = number.Next(100, 1000);
    }

    return array;
}

void ShowEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++; 
    }
    Console.WriteLine("В массиве: [{0}], {1} четных элемента", string.Join(", ", array), count);
}

ShowEvenNumbers(
    GetArray(
        GetNumber("Введите размер массива: ")
    )
);