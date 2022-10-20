/*Задача 2: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        array[i] = number.Next(-1000, 1001);
    }
    Console.WriteLine("Original array: [{0}]", string.Join(", ", array));
    return array;
}

int UnevenSum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result = result + array[i];
    }
    Console.WriteLine("Sum of uneven array elements: {0}", result);
    return result;
}


UnevenSum(
    GetArray(
        GetNumber("Enter the size of the array: ")
    )
);
