// Задать массив из 8 элементов, заполненных нулями и единицами, вывести их на экран
void FillArray(int[] massiv)
{
    Random Numbers = new Random();
        for(int ind = 0;ind<massiv.Length;ind++)
    {
        massiv[ind] = Numbers.Next(0,2);
    }
}
void PrintArray(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int[] Array = new int[8];
FillArray(Array);
PrintArray(Array);