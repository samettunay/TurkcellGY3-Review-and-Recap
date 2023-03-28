namespace Inheritance
{
    public abstract class Occupation
    {
        public string Title { get; set; }
        public int Salary { get; set; }
        public abstract void Work();
    }
}
