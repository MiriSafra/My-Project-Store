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
        List<Customer> GetAll();
        void Add( int CustId, string CustomerName, string Adress, string PhoneNumber);
    }
}
