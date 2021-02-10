namespace CSharpConsoleApp
{
    public class Equality
    {
        public record Data(string Name, string[] Values);

        public bool Compute()
        {
            var a = new Data(
                "Charles",
                new[] {"1", "2"});

            var b = new Data(
                "Charles",
                new[] {"1", "2"});

            return a == b;
        }
    }
}