string username;
Console.Write("kullanıcı adı giriniz...");
username = Console.ReadLine();

if( username != "admin")
{
    Console.WriteLine("kullanıcı bulunamadı...");
}
else
{
    Console.WriteLine("kullanıcı bulundu");
}
