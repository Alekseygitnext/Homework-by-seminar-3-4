// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел
void FillArray(int[] massiv)
{
    Random Numbers = new Random();
    for (int ind = 0; ind < massiv.Length; ind++)
    {
        massiv[ind] = Numbers.Next(0, 1000);
    }
}
void PrintArray(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int Kolichestvo_chisel(int[] massiv, int proverka_chet)
{
    int kolichestvo = 0;
    if (proverka_chet == 1)
    {
        for(int i =0; i<massiv.Length;i++)
        {
            if (massiv[i]%2==1) kolichestvo++;
        }        
    }
    else if (proverka_chet == 0)
    {
        for(int i =0; i<massiv.Length;i++)
        {
            if (massiv[i]%2==0) kolichestvo++;
        } 
    }
    return kolichestvo;
}
Console.Write("Введите длинну массива: ");
int dlinna = int.Parse(Console.ReadLine() ?? "0");
int[] Array = new int[dlinna];
FillArray(Array);
PrintArray(Array);
Console.WriteLine(" ");
Console.WriteLine($"Количество четных элементов: {Kolichestvo_chisel(Array, 0)}");
Console.WriteLine($"Количество нечетных элементов: {Kolichestvo_chisel(Array, 1)}");