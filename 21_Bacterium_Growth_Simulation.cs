int bacterium = 1;

for (int clock = 1; clock <= 24; clock++)
{
    bacterium *= 2;
    
    // İşlem ile çıktı arasına boşluk ekleyerek okunabilirliği artırdık
    Console.WriteLine(clock + ". saatin sonunda oluşan mevcut bakteri: " + bacterium);
}
