using SingleResponsibilityPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Concrete
{
    public class SmsNotifier : INotifier
    {
        public void SendNotifier(Customer customer, Earthquake earthquake)
        {
            Console.WriteLine($"{customer.FirstName}, {customer.Location}: Dikkat Depremin büyüklüğü {earthquake.Magnitude}!");
        }
    }
}
