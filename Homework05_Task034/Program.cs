//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

void FillArray(int [] array)
{
    for (int i = 0; i < n; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
    Console.Write("Массив: ");
}
void PrintArray (int [] arr)
{
    int qty = 0;

    for (int a = 0; a < n; a++)
    {
        if (array[a] % 2 == 0)
        {
            qty ++;
        }    
    }
    Console.Write("[ ");
    for (int i = 0; i < n; i++)
    {
        Console.Write (arr [i] + " ");
    }
    Console.WriteLine("]");
    Console.WriteLine($"Количество четных чисел в массиве: {qty} ");
}
FillArray(array);
PrintArray(array);