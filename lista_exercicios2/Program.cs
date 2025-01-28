double dia = 0;

for (; ; )
{
    Console.WriteLine("digite dias trabalhados (zero para sair): ");
    double d = Convert.ToInt32(Console.ReadLine());
    if (d == 0) break;
    dia++;
}
Console.WriteLine($"total de dias traalhados: {dia}");
//while
int dia = 0;
int d;
while (true)
{
    Console.WriteLine("digite dias trabalhados (zero para sair): ");
    if (dia == 0) break;
    d++;
}
Console.WriteLine($"total de dias traalhados: {dia}");
//do while
int dia = 0;
int d;
do
{
    Console.WriteLine("digite dias trabalhados (zero para sair): ");
    dia Convert.ToInt32(Console.ReadLine());
    if (dia != 0) d++;
}
while (dia != 0);
Console.WriteLine($"total de dias traalhados: {dia}");

