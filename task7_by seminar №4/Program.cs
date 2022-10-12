// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void PrintArray(double[] massiv)
{
    foreach (double item in massiv)
    {
        Console.Write($"{item} ");
    }
}
double Diff_max_and_min(double[] massiv)
{
    double max = massiv[0] , min= massiv[0], raznica = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > max)
        {
            max = massiv[i];
        }
        if (massiv[i] < min)
        {
            min = massiv[i];
        }
        raznica = max - min;
    }
    return raznica;
}
double[] Array = {5.858, 6.17, 8.468, 4.586, 9.285, 1.55};
PrintArray(Array);
Console.WriteLine(" ");
Console.Write($"Разница между максимальным и минимальным значением массива: {Diff_max_and_min(Array)}");
