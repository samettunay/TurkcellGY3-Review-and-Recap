namespace Inheritance
{
    public class Student : Occupation
    {
        public int ClassNumber { get; set; }
        public string Department { get; set; }
        public double Grade { get; set; }
        public double GradeAverage { get; set; }

        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
}
