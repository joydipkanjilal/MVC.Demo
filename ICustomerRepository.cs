namespace MVC.Demo
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAll();

        public Customer GetById(int id);

        public void Create(Customer customer);

        public void Update(Customer customer);

        public void Delete(Customer customer);
    }
}