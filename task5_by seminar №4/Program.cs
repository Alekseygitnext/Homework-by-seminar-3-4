// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] massiv, int min, int max)
{
    Random Numbers = new Random();
    for (int ind = 0; ind < massiv.Length; ind++)
    {
        massiv[ind] = Numbers.Next(min, max);
    }
}
void PrintArray(int[] massiv)
{
    foreach (int item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int Summa_chisel(int[] massiv)
{
    int sum = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (i % 2 == 1) sum += massiv[i];
    }
    return sum;
}
Console.Write("Введите минимальное число значения массива: ");
int Min = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите максимальное число значения массива: ");
int Max = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] Array = new int[length];
FillArray(max: Max+1, min: Min, massiv: Array);
PrintArray(Array);
Console.WriteLine(" ");
Console.WriteLine($"Сумма чисел на нечётной позиции: {Summa_chisel(Array)}");