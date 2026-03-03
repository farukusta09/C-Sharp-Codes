using System.Formats.Tar;

Console.WriteLine("**** Usta Hava Yolları ****");
Console.WriteLine();

string passengerName, passengerSurname;

Console.Write("Yolcu Adı: ");
passengerName = Console.ReadLine();

Console.Write("Yolcu Soyadı: ");
passengerSurname = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine("Yolcu Adı Ve Soyadı: " + passengerName + " " + passengerSurname );
