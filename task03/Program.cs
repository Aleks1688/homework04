//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] FlipArray(int[] array)
{
    int size = array.Length;
    int[] array2 = new int[size];

    for (int i = 0; i < size; i++)
    {
        array2[size - i - 1] = array[i];
    }
    return array2;
}

int minimum = 1;
int maximum = 100;

Console.WriteLine("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayMain = CreateArrayRndInt(count, minimum, maximum); // создаем массив случайных чисел
PrintArray(arrayMain);

Console.WriteLine(); //перенос строки

Console.WriteLine("вывод массива наоборот:");

PrintArray(FlipArray(arrayMain)); // вывод массива наоборот