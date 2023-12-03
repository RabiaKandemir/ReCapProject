using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).Must(CantBiggerThanToday).WithMessage("Tarih bugünden büyük olamaz");

        }
        private bool CantBiggerThanToday(DateTime time)
        {
            if (time<DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
