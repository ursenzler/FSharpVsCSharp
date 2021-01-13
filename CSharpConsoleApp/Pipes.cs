namespace CSharpConsoleApp
{
    public class Pipes
    {
        public record Customer(string Name);

        public Customer GetCustomer(int id)
            => new Customer("Charles");

        public string GetNameOfCustomer(Customer customer)
            => customer.Name;

        public string GetNameOfCustomerFromId(int id)
        {
            return GetNameOfCustomer(
                GetCustomer(
                    id));
        }

        public string GetNameOfCustomerFromIdVariant(int id)
        {
            var customer = GetCustomer(id);
            return GetNameOfCustomer(customer);
        }
    }
}