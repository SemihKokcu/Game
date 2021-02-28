namespace Game.Concrete
{
    internal class BaseCustomerManager : ICustomer
    {
        public virtual void Add(Customer customer)
        {
            System.Console.WriteLine("Add a new Customer"+customer.FirstName);
        }

        public virtual void Delete(Customer customer)
        {
            System.Console.WriteLine("Delete a Customer" + customer.FirstName);
        }

        public virtual void Uptade(Customer customer)
        {
            System.Console.WriteLine("Uptade new Customer" + customer.FirstName);
        }
    }
}