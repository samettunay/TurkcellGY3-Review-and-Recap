/*
 * 1. Bir kelime koleksiyonu içinden rastgele bir kelime SEÇ.
 * 2. Seçilen kelimeyi, "* * * *" biçiminde bulmacaya ÇEVİR.
 * 3. Kullanıcıdan harf İSTE.
 * 4. girilen Harfi Kelimede ARA
 * 5. Varsa; o yıldızı harfe ÇEVİR
 * 6. Tüm *'lar açılana kadar bu adımlar devam etsin.
 * 
 * 
 */
List<string> words = new List<string>() { "ayna" };
var choosingWord = getRandomWord(words);
var puzzledWord = convertToPuzzle(choosingWord);
showOnScreen(puzzledWord);

while (true)
{
    char suggestedLetter = getLetterFromUser();
    if (isLetterFindInWord(choosingWord, suggestedLetter))
    {
        puzzledWord = replaceStarWithLetter(choosingWord, puzzledWord, suggestedLetter);
        showOnScreen(puzzledWord);
    }
    else
    {
        showOnScreen("Bir hakkınız yandı...");
    }

    if (checkUserWon(puzzledWord))
    {
        Console.WriteLine("Tebrikler kazandınız!!!!");
        break;
    }
}

bool checkUserWon(string puzzle)
{
    return !puzzle.Contains('*');
}

string getRandomWord(List<string> words)
{
    var index = new Random().Next(words.Count);
    return words[index];
}

string convertToPuzzle(string word)
{
    string puzzle = string.Empty;
    for (int i = 0; i < word.Length; i++)
    {
        puzzle += "*";
    }
    return puzzle;

}

void showOnScreen(string word)
{
    Console.WriteLine(word);
}

char getLetterFromUser()
{
    Console.WriteLine("Bir harf giriniz....");
    return char.Parse(Console.ReadLine());
}

bool isLetterFindInWord(string word, char letter)
{
    return word.ToLower().Contains(letter.ToString().ToLower());
}

string replaceStarWithLetter(string word, string puzzle, char harf)
{
    char[] charPuzzle = puzzle.ToCharArray();
    int startIndex = 0;
    bool isFind = word.IndexOf(harf, startIndex) != -1;

    while (isFind)
    {
        int findingIndex = word.IndexOf(harf, startIndex);
        startIndex = findingIndex + 1;
        charPuzzle[findingIndex] = harf;
        isFind = word.IndexOf(harf, startIndex) != -1;
    }
    return new string(charPuzzle);
}

