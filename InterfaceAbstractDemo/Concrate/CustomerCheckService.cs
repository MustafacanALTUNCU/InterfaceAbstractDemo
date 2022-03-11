using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrate
{
    public class CustomerCheckService : ICustomerCheckService
    {
        
        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
