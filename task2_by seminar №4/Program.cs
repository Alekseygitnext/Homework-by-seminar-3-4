// Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива.
void FillArray(int[] massiv)
{
    Random Numbers = new Random();
    for (int ind = 0; ind < massiv.Length; ind++)
    {
        massiv[ind] = Numbers.Next(-10, 10);
    }
}
void PrintArray(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int[] Array = new int[12];
FillArray(Array);
PrintArray(Array);
Console.WriteLine(" ");
int sum_polojitelnih = 0;
int sum_otricatelnih = 0;
for (int ind = 0; ind < Array.Length; ind++)
{
    if (Array[ind] < 0)
    {
        sum_otricatelnih -= Array[ind];
    }
    if (Array[ind] > 0)
    {
        sum_polojitelnih += Array[ind];
    }
};
Console.WriteLine($"Сумма положительных чисел {sum_polojitelnih}");
Console.WriteLine($"Сумма отрицательных чисел {-sum_otricatelnih}");