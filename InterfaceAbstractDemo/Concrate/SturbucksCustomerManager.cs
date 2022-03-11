using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrate
{
    public class SturbucksCustomerManager:CustomerManager
    {
        private ICustomerCheckService customerCheckService;

        public SturbucksCustomerManager()
        {
        }

        public SturbucksCustomerManager(ICustomerCheckService _customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        
       
    }
}
