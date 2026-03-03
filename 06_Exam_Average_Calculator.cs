double exam1,exam2, exam3, result;

Console.Write("1. Sınav Notunuzu Giriniz: ");
exam1 = double.Parse(Console.ReadLine());

Console.Write("2. Sınav Notunuzu Giriniz: ");
exam2 = double.Parse(Console.ReadLine());

Console.Write("3. Sınav Notunuzu Giriniz: ");
exam3 = double.Parse(Console.ReadLine());

result= (exam1+exam2+exam3)/3;

Console.WriteLine("Result : " + result );
