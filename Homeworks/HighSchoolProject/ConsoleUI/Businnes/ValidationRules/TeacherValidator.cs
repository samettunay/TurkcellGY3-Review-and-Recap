using ConsoleUI.Models;
using FluentValidation;

namespace ConsoleUI.Businnes.ValidationRules
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(t => t.Department).NotEmpty().WithMessage("Bölüm gerekli!");
            RuleFor(t => t.FirstName).NotEmpty().WithMessage("Ad gerekli!");
            RuleFor(t => t.LastName).NotEmpty().WithMessage("Soyad gerekli!");
        }
    }
}
