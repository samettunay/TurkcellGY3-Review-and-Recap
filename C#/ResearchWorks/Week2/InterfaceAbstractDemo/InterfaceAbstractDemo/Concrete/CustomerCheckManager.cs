using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPerson(Customer customer)
        {
            bool result = true;
            return await Task.FromResult(result);
        }
    }
}
