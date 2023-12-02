using StoreModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.service.BL
{
    public interface ICustomerService
    {
        bool? AddCustomer(Customer customer);
        public List<Customer> GetAll();
        bool RemoveCustomer(string Name);
        Customer GetCustomer(string Name);
    }
}
