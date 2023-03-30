using ReservationProject.Validator.Abstract;
using System.Text.RegularExpressions;

namespace ReservationProject.Validator.Concrete
{
    public class CustomerValidator : ICustomerValidator
    {
        public bool Validate(Customer customer)
        {
            return Regex.IsMatch(customer.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
