using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    interface ICustomerCheckService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}
