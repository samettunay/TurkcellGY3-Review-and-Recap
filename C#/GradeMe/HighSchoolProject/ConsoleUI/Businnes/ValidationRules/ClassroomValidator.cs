using ConsoleUI.Models;
using FluentValidation;

namespace ConsoleUI.Businnes.ValidationRules
{
    public class ClassroomValidator : AbstractValidator<Classroom>
    {
        public ClassroomValidator()
        {
            RuleFor(c => c.ResponsibleTeacher).NotEmpty().WithMessage("Sorumlu öğretmenin seçilmesi gerekli!");
        }
    }
}
