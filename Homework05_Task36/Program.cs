//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

void FillArray(int [] array)
{
    int i = 0;
    while (i < n)
    {
        array [i] = new Random().Next(-100, 100);
        i ++;
    }
}
void PrintArray (int [] array)
{
    int sum = 0;

    for (int i = 1; i < n; i+= 2)
    {
        sum = sum + array[i];
    }
    Console.Write("[ ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
}
FillArray(array);
PrintArray(array);
