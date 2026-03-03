
int Sayı1, Sayı2, Sayı3;
string result = "Hata...";

Console.Write("Sayı1 giriniz: ");
Sayı1 = int.Parse(Console.ReadLine());

Console.Write("Sayı2 giriniz: ");
Sayı2 = int.Parse(Console.ReadLine());

Console.Write("Sayı3 giriniz: ");
Sayı3 = int.Parse(Console.ReadLine());

int average = (Sayı1 + Sayı2 + Sayı3 )/3;

if (average > 0 & average <= 50)
{
result = "sonuç vasat...";
}
if (average > 50 & average <= 70)
{
result = "sonuç orta...";
}
if (average > 70 & average <= 84)
{
result = "sonuç iyi...";
}
if (average > 84)
{
result = "sonuç çok iyi...";
}

Console.WriteLine("Ortalamanız: " + average);
Console.WriteLine(result);
