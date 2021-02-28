using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }



}
