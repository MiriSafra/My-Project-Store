using StoreModel.Model;
using StoreModel;
namespace Store.service.DAL
{ 
    public class CustomerRepository: ICustomerRepository
    {

        readonly StoreContext _StoreContext;
        public StudentRepository(HomeSchoolContext HomeSchoolContext)
        {
            _HomeSchoolContext = HomeSchoolContext;
        }


        public List<Student> GetAll()
        {
            return _HomeSchoolContext.Student.ToList();
        }

        public void add(Student st)
        {
            _HomeSchoolContext.Add(st);
            _HomeSchoolContext.SaveChanges();
        }

        List<Customer> ICustomerRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
}