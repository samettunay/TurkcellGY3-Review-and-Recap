namespace Inheritance
{
    public class Teacher : Occupation
    {
        public string Department { get; set; }
        public double Salary { get; set; }

        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
}
