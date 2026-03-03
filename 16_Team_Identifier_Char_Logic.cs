
 char team;

 Console.Write("lütfen takımın ilk harfini giriniz...");

 team = char.Parse(Console.ReadLine());

 if (team == 'G' | team == 'g')
{
    Console.WriteLine("Galatasaray...");
}

if (team == 'F' | team == 'f')
{
    Console.WriteLine("Fenerbahçe...");
}

if (team == 'B' | team == 'b')
{
    Console.WriteLine("Beşiktaş...");
}
