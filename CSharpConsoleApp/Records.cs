namespace CSharpConsoleApp
{
    public class Records
    {
        public record A(string Name, int Id);

        public record B
        {
            public string Name { get; init; }
            public int Id { get; init; }
        }

        public void Instantiate()
        {
            var a = new A("Hugo", 42);
            var b = new B { Name = "Hugo2", Id = 42 };
        }
    }
}