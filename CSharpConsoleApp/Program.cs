using System;
using System.Threading.Tasks;

namespace CSharpConsoleApp
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            new Pipes().GetNameOfCustomerFromId(42);
            new Pipes().GetNameOfCustomerFromIdVariant(42);
            new Records().Instantiate();
            var m = new DiscriminatedUnions().GetMeasure(new DiscriminatedUnions.Celsius(3.0));
            var b = new DiscriminatedUnions().IsItWarm(new DiscriminatedUnions.Celsius(3.0));
            await new HappyPathCoding().Compute();

            var result = new Equality().Compute();
            Console.WriteLine(result);

            var t = await new HappyPathCodingBasics().AsyncResult(17);
            var r = await new HappyPathCodingBasics().Caller(17);
        }
    }
}