using ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ConsoleUI.Businnes.ValidationRules
{
    public class HomeworkValidator : AbstractValidator<Homework>
    {
        public HomeworkValidator()
        {
            RuleFor(h => h.Title).NotEmpty().WithMessage("Başlık gerekli!");
            RuleFor(h => h.Description).NotEmpty().WithMessage("Açıklama gerekli!");
            RuleFor(h => h.DueDate).NotEmpty().WithMessage("Son Tarih gerekli!");
            RuleFor(h => h.DueDate).GreaterThan(DateTime.Now).WithMessage("Son tarih, geçerli tarihten daha büyük olmalıdır!");
        }
    }
}
