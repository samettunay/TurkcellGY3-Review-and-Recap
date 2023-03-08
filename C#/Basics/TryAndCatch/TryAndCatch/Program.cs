try
{
    Console.WriteLine("Bir sayı giriniz: ");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Bir sayı daha giriniz: ");
    int sayi2 = int.Parse(Console.ReadLine());
    int bolum = sayi1 / sayi2;

    Console.WriteLine($"Bölme işleminin sonucu: {bolum}");
}
catch (FormatException)
{
    Console.WriteLine("Sayı diyoruz kardeş!");
}
catch (DivideByZeroException) 
{
    Console.WriteLine("Tam sayılar 0'a bölünemez!");
}
catch (Exception ex)
{
    Console.WriteLine($"Bir hata oluştu: {ex.Message}");
}
finally
{
    Console.WriteLine("Bu satır mutlaka çalışacak!");
}

