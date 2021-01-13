namespace CSharpConsoleApp
{
    public class Expressions
    {
        public int Compute(bool b)
        {
            var result = 17;
            if (b)
            {
                result = 42;
            }

            return result;
        }

        public int Compute2(bool b)
        {
            return b ? 42 : 17;
        }
    }
}