// Показать кубы чисел заканчивающиеся на чётную цифру
Console.Write("Введите число: ");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
int Kub;
Console.WriteLine("Кубами заканчивающемися на чётную цифру являются: ");
for (int i=1; i<=Chislo;i++)
{
Kub = i*i*i;
if ((Kub%10)%2==0)
Console.Write($"{Kub} ");
};