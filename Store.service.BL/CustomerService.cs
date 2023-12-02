using Store.service.DAL;
using StoreModel.Model;

namespace Store.service.BL
{
    public class CustomerService : ICustomerService
    {
        readonly ICustomerRepository _CustomerRepository;
        public CustomerService(ICustomerRepository repository)
        {
            _CustomerRepository = repository;
        }

        //public void Add(int CustomerId, string CustomerName, string Adress, string PhoneNumber)
        //{
        //    Customer c = new Customer() {CustomerId = CustomerId, CustomerName = CustomerName, Adress = Adress, PhoneNumber = PhoneNumber};
        //    _Repository.Add(c);
        //}

        public bool? AddCustomer(Customer customer)
        {
            Customer customerExists = _CustomerRepository.GetCustomer(customer.Name);
            if (customerExists != null)
                return null;
            return _CustomerRepository.AddCustomer(customer);
        }

        public List<Customer> GetAll()
        {
            return _CustomerRepository.GetAll();
        }

        public Customer GetCustomer(string Name)
        {
            return _CustomerRepository.GetCustomer(Name);
        }

        public bool RemoveCustomer(string Name)
        {
            return _CustomerRepository.RemoveCustomer(Name);
        }
    }
}