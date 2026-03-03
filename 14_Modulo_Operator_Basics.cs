
int number1, number2, result;


Console.Write("lütfen birinci sayıyı giriniz: ");
number1 = int.Parse(Console.ReadLine());

Console.Write("lütfen ikinci sayıyı giriniz: ");
number2 = int.Parse(Console.ReadLine());

result = number1 % number2;

Console.WriteLine("birinci sayının ikinci sayıya bölümünden kalan: " + result);
