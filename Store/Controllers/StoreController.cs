using Microsoft.AspNetCore.Mvc;
using Store.service.BL;
using StoreModel.Model;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        [Route("Post")]
        public ActionResult Post(Customer customer)
        {
            bool? succeed = _customerService.AddCustomer(customer);
            if (succeed == null)
                return NoContent();
            else if (succeed.Value)
                return Ok();
            return BadRequest();
        }
        [HttpGet]
        [Route("Get All")]
        public List<Customer> GetAll()
        {
            return _customerService.GetAll();
        }
        [HttpGet]
        [Route("Get By Customer Name")]
        public Customer GetCustomer(string CustomerName)
        {
            return _customerService.GetCustomer(CustomerName);
        }
        [HttpDelete]
        [Route("Delete")]
        public bool RemoveCustomer(string CustomerName)
        {
            return _customerService.RemoveCustomer(CustomerName);
        }
    }
}