using System;
using System.Threading.Tasks;

namespace CSharpConsoleApp
{
    public class HappyPathCoding
    {
        public record Customer(int Id, string? Name);
        public record Data(int Id, int Amount);

        private async Task<Customer?> GetCustomer(
            int customerId)
        {
            return new(customerId, "Charles");
        }

        private async Task<Data?> GetData(
            int dataId)
        {
            return new(dataId, 100);
        }

        private string? GetNameOfCustomer(
            Customer customer)
        {
            return customer.Name;
        }

        public async Task<(string Name, int Amount)?>
            GetCustomerNameAndAmount(
                int customerId, int dataId)
        {
            var customer = await GetCustomer(customerId)
                .ConfigureAwait(false);

            if (customer == null)
            {
                return null;
            }

            var data = await GetData(dataId)
                .ConfigureAwait(false);

            if (data == null)
            {
                return null;
            }

            var name = GetNameOfCustomer(customer);

            if (name == null)
            {
                return null;
            }

            return (name, data.Amount);
        }

        public async Task Compute()
        {
            var result = await GetCustomerNameAndAmount(42, 17);
            if (result != null)
            {
                Console.WriteLine($"customer = {result.Value.Name}, amount = {result.Value.Amount}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}