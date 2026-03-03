

 int number1, number2, result;
 char symbol;

 Console.Write("Lütfen 1. Sayıyı Giriniz: ");
 number1 = int.Parse(Console.ReadLine());

 Console.Write("Lütfen 2. Sayıyı Giriniz: ");
 number2 = int.Parse(Console.ReadLine());

Console.Write("Lütfen Yapmak İstediğiniz İşlemi Gİriniz ");
 symbol = char.Parse(Console.ReadLine());

switch (symbol)
{
    case '+' : 
    result = number1 + number2;
    Console.WriteLine("Toplama İşleminin Değeri: " + result );
    break;

    case '-' : 
    result = number1 - number2;
    Console.WriteLine("Çıkartma İşleminin Değeri: " + result );
    break;

    case '*' : 
    result = number1 * number2;
    Console.WriteLine("Çarpma İşleminin Değeri: " + result );
    break;

    case '/' : 
    result = number1 / number2;
    Console.WriteLine("Bölme İşleminin Değeri: " + result );
    break;

    default : Console.WriteLine("Hatalı Giriş...");
    break;




}
