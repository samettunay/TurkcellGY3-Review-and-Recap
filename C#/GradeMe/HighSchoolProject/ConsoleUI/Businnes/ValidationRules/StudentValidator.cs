using ConsoleUI.Models;
using FluentValidation;

namespace ConsoleUI.Businnes.ValidationRules
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Ad gerekli!");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Soyad gerekli!");
        }
    }
}
