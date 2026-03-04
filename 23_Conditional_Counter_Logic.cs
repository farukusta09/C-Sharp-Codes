int count = 0;

for (int i = 1; i <= 50; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine(i);
        count++;
    }
}

Console.WriteLine("50 den küçük 7 ye tam bölünen " + count + " tane sayı var");
