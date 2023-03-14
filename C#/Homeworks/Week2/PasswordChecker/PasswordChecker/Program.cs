/*
 *  1. En az 6 karakter
 *  2. Sadece harf ya da sadece sayı ise ZAYIF ya da sadece alfanümerik olmayan ise
 *  3. Hem harf hem sayı ise ORTA
 *  4. Hem sayı, hem harf hem de alfanümerik olmayan bir karakter varsa GÜÇLÜ şifre desin.
 *  
 *  İpucu: 
 *  char(.)
 */

Console.Write("Bir şifre giriniz: ");
string password = Console.ReadLine();
int maxPasswordLenght = 6;
PasswordChecker passwordChecker = new PasswordChecker();

if (passwordChecker.IsPasswordLessThanLength(password, maxPasswordLenght))
    Console.WriteLine("Şifre en az 6 karakter olmalıdır.");
else
    Console.WriteLine($"Şifrenizin güvenlik seviyesi: {passwordChecker.GetPasswordSecurityLevel(password)}");


public class PasswordChecker
{
    /// <summary>
    /// Kullanılan parametredeki şifrenin güvenlik seviyesini gösterir. ZAYIF, ORTA, GÜÇLÜ
    /// </summary>
    /// <param name="password">Şifre</param>
    /// <returns></returns>
    public string GetPasswordSecurityLevel(string password)
    {
        int securityLevel = 0;
        securityLevel = IsThereNumberInPassword(password) ? securityLevel += 1 : securityLevel;
        securityLevel = IsThereLetterInPassword(password) ? securityLevel += 1 : securityLevel;
        securityLevel = IsThereNonAlphaNumericInPassword(password) ? securityLevel += 1 : securityLevel;

        switch (securityLevel)
        {
            case 1:
                return "Zayıf";
                break;
            case 2:
                return "Orta";
            case 3:
                return "Güçlü";
            default:
                return "";
        }
    }
    /// <summary>
    /// Kullanılan şifrenin içerisinde sayı olup olmadığını öğrenmek için kullanılır.
    /// </summary>
    /// <param name="password">Şifre</param>
    /// <returns></returns>
    public bool IsThereNumberInPassword(string password)
    {
        foreach (Char letter in password)
        {
            if (Char.IsDigit(letter))
                return true;
        }
        return false;
    }
    /// <summary>
    /// Kullanılan şifrenin içerisinde harf olup olmadığını öğrenmek için kullanılır.
    /// </summary>
    /// <param name="password">Şifre</param>
    /// <returns></returns>
    public bool IsThereLetterInPassword(string password)
    {
        foreach (Char letter in password)
        {
            if (Char.IsLetter(letter))
                return true;
        }
        return false;
    }
    /// <summary>
    /// Kullanılan şifrenin içerisinde alfanümerik karakter olup olmadığını öğrenmek için kullanılır.
    /// </summary>
    /// <param name="password">Şifre</param>
    /// <returns></returns>
    public bool IsThereNonAlphaNumericInPassword(string password)
    {
        foreach (Char letter in password)
        {
            if (!Char.IsLetterOrDigit(letter))
                return true;
        }
        return false;
    }
    /// <summary>
    /// Kullanılan şifrenin belirlenen uzunlukta olup olmadığını öğrenmek için kullanılır.
    /// </summary>
    /// <param name="password">Şifre</param>
    /// <param name="lenght">Uzunluk</param>
    /// <returns></returns>
    public bool IsPasswordLessThanLength(string password, int lenght)
    {
        return password.Length < lenght;
    }
}

