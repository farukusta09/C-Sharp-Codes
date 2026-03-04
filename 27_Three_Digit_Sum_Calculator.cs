Console.Write("Lütfen Basamakları Toplamını Merak Ettiğiniz Sayıyı Yazınız: ");

int input = int.Parse(Console.ReadLine());

int ones, tens, hundreds;
int sum;

// Matematiksel parçalama işlemleri
ones = input % 10;
hundreds = input / 100;
tens = (input % 100) / 10;

sum = tens + ones + hundreds;

Console.WriteLine("Girdiğiniz Sayının Rakamları Toplamı: " + hundreds + " + " + tens + " + " + ones + " = " + sum);
