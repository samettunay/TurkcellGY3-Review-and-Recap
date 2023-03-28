// Tam Sayılar;
//8 - 16 - 32 - 64
//s - u  - u - u

byte enKucuk = 255;
sbyte eksiOlabilenByte = -128;

short onaltiBit = -32767;
ushort sadecePozitif = 65535;

int otuzikiBit = -2147483647;
uint sadecePozitifInt = 4294967295;

long eksiOlabilen = -946744073709551615;
ulong bayaabüyüktamsayi = 18446744073709551615;

// Ondalıklı Sayılar;
double pi = 3.14;
float piFloat = 3.14f;
decimal piDecimal = 3.145900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001M;


//Sözel:
char symbol = '!';
string name = "Samet"; //c#
String word = "bilgisayar"; //.net


//mantıksal
bool olurMu = false; // soyisim

byte x = 255;
int y = 1000;

try
{
    byte result = (byte)(x + y);
    Console.WriteLine(result);
}
catch (OverflowException)
{

    Console.WriteLine("toplam değeri byte sınırlarından büyük!");
}

Console.WriteLine("Lütfen kilonuzu giriniz: ");
int kilo = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen boyunuzu giriniz:");
double boy = Convert.ToDouble(Console.ReadLine());

double bmi = kilo / (boy * boy);
Console.WriteLine(bmi); 

