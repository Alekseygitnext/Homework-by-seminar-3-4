// Найти кубы чисел от 1 до N
Console.Write("Введите число: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
while (count <= chislo)
{
    /*double res = Math.Pow(count, 3);*/
    int res = count*count*count;
    Console.WriteLine($"{res} является кубом {count}");
    count++;
}

