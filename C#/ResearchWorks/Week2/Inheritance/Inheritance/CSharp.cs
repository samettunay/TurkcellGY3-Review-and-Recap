namespace Inheritance
{
    public class CSharp : ProgramingLanguage, IProgrammable
    {
        public CSharp()
        {
            Name = "CSharp";
        }
        public void Coding()
        {
            Console.WriteLine($"coding with {Name} language");
        }
    }
}
