using StoreModel.Model;
using StoreModel;
namespace Store.service.DAL
{ 
    public class CustomerRepository: ICustomerRepository
    {

        readonly StoreContext _storeContext;
        public CustomerRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public bool AddCustomer(Customer customer)
        {
            try
            {
                _storeContext.Add(customer);
                _storeContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Customer> GetAll()
        {
            return _storeContext.Customer.ToList();
        }

        public Customer GetCustomer(string Name)
        {
            return _storeContext.Customer.Where(c => c.Name == Name).FirstOrDefault();
        }

        public bool RemoveCustomer(string Name)
        {
            try
            {
                Customer c = _storeContext.Customer.Where(c => c.Name == Name).FirstOrDefault();
                if (c != null)
                {
                    _storeContext.Remove(c);
                    _storeContext.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public void Add(Customer customer)
        //{
        //    _storeContext.Add(customer);
        //    _storeContext.SaveChanges();
        //}


    }
}