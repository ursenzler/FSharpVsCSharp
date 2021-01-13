using System.Collections.Generic;
using System.Linq;

namespace CSharpConsoleApp
{
    public class Equality
    {
        public record Customer(int Id, string? Name);

        public bool Compute()
        {
            var listOfEmployees1 = new List<Customer>
            {
                new Customer(1, "Charles"),
                new Customer(2, null)
            };

            var listOfEmployees2 = new List<Customer>
            {
                new Customer(1, "Charles"),
                new Customer(2, null)
            };

            //return listOfEmployees1 == listOfEmployees2;
            return listOfEmployees1.SequenceEqual(listOfEmployees2);
        }
    }
}