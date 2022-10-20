//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
System.Console.WriteLine();

int size = 20;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
    System.Console.WriteLine();
}

PrintResult(FillArray(size));


// фигня какая-то
//int[] GetArray(int size, int arrayLenght, int arrayMaxValue, arrayMinValue)
//{            
// int[] arrayLenght = 6;
//             arrayMaxValue = 1000;
//             arrayMinValue = 100;
//             int count = 0;
//             arrayInt = intGenerator(arrayLenght, arrayMaxValue, arrayMinValue);

//             /            for (int i = 0; i < arrayLenght; i++)
//             {
//                 if (int[i] % 2 == 0) count++;
//             }
//             Console.WriteLine($"Количество чётных чисел = {count}");
//             WaitingToAnyKey();