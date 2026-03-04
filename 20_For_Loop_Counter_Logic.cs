int counter = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0)
    {
        counter++;
        Console.WriteLine("Beşe tam bölünen " + counter + ". sayı: " + i);
    }
}
