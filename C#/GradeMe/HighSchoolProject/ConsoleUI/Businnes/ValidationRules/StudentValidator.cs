using ConsoleUI.Models;
using FluentValidation;

namespace ConsoleUI.Businnes.ValidationRules
{
    public class StudentValidator : AbstractValidator<Student>
    {
        private readonly List<Student> _students;
        public StudentValidator(List<Student> students)
        {
            _students = students;
            RuleFor(s => s.StudentNumber).NotEmpty().WithMessage("Öğrenci no gerekli!");
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Ad gerekli!");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Soyad gerekli!");
            RuleFor(c => c)
            .Must(CheckIfSameStudentNumber)
            .WithMessage("Aynı numaraya sahip bir öğrenci zaten var!");
        }
        private bool CheckIfSameStudentNumber(Student student)
        {
            return !_students.Any(s => s.StudentNumber == student.StudentNumber);
        }
    }
}
