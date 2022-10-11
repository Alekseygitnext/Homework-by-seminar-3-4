// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
int result = 1;
for (int i=1; i<=Chislo;i++)
{
result = result * i;
Console.WriteLine(result);
}