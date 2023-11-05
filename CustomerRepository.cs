using Microsoft.EntityFrameworkCore;

namespace MVC.Demo
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _context;

        public CustomerRepository()
        {
            var options = new DbContextOptionsBuilder<CustomerDbContext>()
                .UseInMemoryDatabase("OrderManagementSystem")
                .Options;

            _context = new CustomerDbContext(options);
            _context.Database.EnsureCreated();
        }

        public List<Customer> GetAll() => _context.Customers.ToList<Customer>();

        public Customer GetById(int id) => _context.Customers.SingleOrDefault(p => p.Id == id);

        public void Create(Customer customer) => _context.Customers.Add(customer);

        public void Delete(Customer customer) => _context.Customers.Remove(customer);

        public void Update(Customer customer) => _context.Customers.Update(customer);
    }
}