using ConsoleUI.Models;
using FluentValidation;

namespace ConsoleUI.Businnes.ValidationRules
{
    public class ClassroomValidator : AbstractValidator<Classroom>
    {
        private readonly List<Classroom> _classrooms;
        public ClassroomValidator(List<Classroom> classrooms)
        {
            _classrooms = classrooms;
            RuleFor(c => c.ClassNumber).GreaterThanOrEqualTo(100).WithMessage("Sınıf numarası 3 rakamlı olmalı!");
            RuleFor(c => c.ClassNumber).NotEmpty().WithMessage("Sınıf numarası gerekli!");
            RuleFor(c => c.ResponsibleTeacher).NotEmpty().WithMessage("Sorumlu öğretmenin seçilmesi gerekli!");
            RuleFor(c => c)
            .Must(CheckIfSameClassroomNumber)
            .WithMessage("Aynı numaraya sahip bir sınıf zaten var!");
        }
        private bool CheckIfSameClassroomNumber(Classroom classroom)
        {
            return !_classrooms.Any(c => c.ClassNumber == classroom.ClassNumber);
        }
    }
}
