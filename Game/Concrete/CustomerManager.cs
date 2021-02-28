using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class CustomerManager : BaseCustomerManager
    {
        private readonly ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
           
        }
    }
}
