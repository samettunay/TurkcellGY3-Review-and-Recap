using Inheritance;

Person samet = new Person() {
    Name = "Samet",
    LastName = "TUNAY",
    Age = 24,
    Occupation = new Programmer() {
        Title = "Full Stack",
        Salary = 0,
        ProgramingLanguages = new List<ProgramingLanguage>()
        {
            new Python(),
            new TypeScript(),
            new CSharp()
        }
    },
};

foreach (var item in ((Programmer)samet.Occupation).ProgramingLanguages)
{
    if (item is IProgrammable)
    {
        IProgrammable programmable = (IProgrammable)item;
        programmable.Coding();
    }
}




