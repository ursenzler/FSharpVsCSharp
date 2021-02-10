namespace CSharpConsoleApp
{
    public class SingleCaseDiscriminatedUnions
    {
        public class Lazy
        {
            public bool Compute()
            {
                var customerId = 17;
                var itemId = 17;

                var same = customerId == itemId; // no compile error

                return same;
            }
        }

        // public class WithRecords
        // {
        //     public record CustomerId(int Value);
        //     public record ItemId(int Value);
        //
        //     public bool Compute()
        //     {
        //         var customerId = new CustomerId(17);
        //         var itemId = new ItemId(17);
        //
        //         var same = customerId == itemId; // compile error
        //
        //         return same;
        //     }
        // }
    }
}