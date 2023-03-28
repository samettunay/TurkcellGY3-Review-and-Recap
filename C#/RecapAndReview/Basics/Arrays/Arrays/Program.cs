string[] books = new string[8];
string[] seasons = new string[] {"İlkbahar", "Yaz", "Sonbahar", "Kış"};

books[0] = "Yüzüklerin Efiendisi";
books[7] = "Otostopçunun Galaksi Rehberi";

Console.WriteLine(seasons[1]);
Console.WriteLine(seasons.Length -1);

string[] onlar = {"", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
string[] birler = {"", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz"};

Console.WriteLine("Üç basamaklı bir sayı giriniz: ");
int number = int.Parse(Console.ReadLine());

int yuzlerBasamagindakiDeger = number / 100;
int onlarBasamagindakiDeger = number % 100 / 10;
int birlerBasamagindakiDeger = number % 10;

Console.WriteLine($"{birler[yuzlerBasamagindakiDeger]} yüz {onlar[onlarBasamagindakiDeger]} {birler[birlerBasamagindakiDeger]}"); 