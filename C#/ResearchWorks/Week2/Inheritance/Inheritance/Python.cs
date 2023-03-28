namespace Inheritance
{
    public class Python : ProgramingLanguage, IProgrammable
    {
        public Python()
        {
            Name = "Python";
            Version = "3.10";
        }
        public void Coding()
        {
            Console.WriteLine($"coding with {Name} language");
        }
    }
}
