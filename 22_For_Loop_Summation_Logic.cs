int totalValue = 0;

Console.Write("1 den başlayarak verdiğiniz sayıya kadar olan toplamlarını görmek istediğiniz sayıyı yazınız: ");

int j = int.Parse(Console.ReadLine());

for (int i = 1; i <= j; i++)
{
    totalValue += i;
}

Console.WriteLine("toplam değer: " + totalValue);
