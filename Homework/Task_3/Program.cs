/*Задача 3: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
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
            Console.WriteLine($"\nВвели не число или оно слишком большое. Введите корректное число:");
        }
    }
    return result;
}

double[] GetArray(int size)
{
    double[] array = new double[size];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(number.NextDouble() * 1000, 2);
    }
    Console.WriteLine("Original array: [{0}]", string.Join("; ", array));
    return array;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine("Maximum array element: {0}", max);
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine("Minimum array element: {0}", min);
    return min;
}

double DiferenceNumbers(double max, double min) {
    return max - min;
}

double[] array = GetArray(GetNumber("Enter the size of the array: "));
double maxElement = MaxElement(array);
double minElement = MinElement(array);
Console.WriteLine("The diference between the maximum and minimum array elements: {0}", DiferenceNumbers(maxElement, minElement));