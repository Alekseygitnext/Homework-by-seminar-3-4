// Найти произведение пар чисел в одномерном массиве. Парой считать первый и последний элемент, второй и предпоследний и т.д.
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
Console.Write("Введите минимальное число значения массива: ");
int Min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное число значениz массива: ");
int Max = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] Array = new int[length];
FillArray(max: Max + 1, min: Min, massiv: Array);
PrintArray(Array);
Console.WriteLine(" ");
for (int i = 0; i <= Array.Length / 2; i++)
{
    if (((Array.Length % 2) == 1) && (i == Array.Length / 2)) 
    Console.WriteLine($"В массиве нечётное количество элементов поэтому у  {Array[Array.Length / 2]} нет пары");
    else Console.WriteLine($"Произведение пары чисел: {Array[i] * Array[Array.Length -1 -i]}");
}