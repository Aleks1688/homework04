//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountEven(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            number++;
        }
    }
    return number;
}

int minimum = 100;
int maximum = 1000;

Console.WriteLine("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
PrintArray(arrayMain);

Console.WriteLine();

Console.WriteLine("количество чётных чисел в массиве равно:");

Console.WriteLine(CountEven(arrayMain));
