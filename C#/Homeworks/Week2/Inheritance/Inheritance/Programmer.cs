namespace Inheritance
{
    public class Programmer : Occupation
    {
        public List<ProgramingLanguage> ProgramingLanguages { get; set; }

        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
}
