//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

//double difference = double max - double min;
void FillArray(double[] array)
{
    int i = 0;
    while (i < n)
    {
        Console.Write($"Введите элемент массива с индексом {i}:  ");
        array[i] = Convert.ToDouble(Console.ReadLine());
        i++;
    }
    Console.Write("[ ");
    foreach (double elem in array)
    {
        Console.Write("{0}", $"{elem} ");
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    double _Max = array[0];
    double _Min = array[0];

    for (int i = 1; i < n; i++)
    {
        if (array [i] > _Max)
        {
            _Max = array[i];
        }
        if (array[i] < _Min)
        {
            _Min = array[i];
        }
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {_Max - _Min} ");
}
FillArray(array);
PrintArray(array);
