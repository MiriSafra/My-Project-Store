using Store.service.DAL;
using StoreModel.Model;

namespace Store.service.BL
{
    public class CustomerService : ICustomerService
    {
        readonly ICustomerRepository _Repository;
        public CustomerService(ICustomerRepository Repository)
        {
            _Repository = Repository;
        }

        public void Add(int CustId, string CustomerName, string Adress, string PhoneNumber)
        {
            Customer c = new Customer() { CustId = CustId, Name = CustomerName, Adress = Adress, PhoneNumber = PhoneNumber };
            _Repository.Add(c);
        }

        public List<Customer> GetAll()
        {
            return _Repository.GetAll();
        }

    }
}