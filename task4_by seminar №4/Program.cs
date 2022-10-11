// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
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
int Kolichestvo_chisel(int[] massiv)
{
    int kolichestvo = 0;
        for(int i =0; i<massiv.Length;i++)
        {
            if (massiv[i]>=10 && massiv[i]<=99) kolichestvo++;
        } 
    return kolichestvo;
}
Console.Write("Введите минимальное число для значений массива:");
int Min = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите максимальное число для значений массива:");
int Max = int.Parse(Console.ReadLine()??"0");
int[] Array = new int[123];
FillArray(Array, Min, Max+1);
PrintArray(Array);
Console.WriteLine("");
Console.WriteLine($"Количество элементов в диапазоне [10,99]: {Kolichestvo_chisel(Array)}");