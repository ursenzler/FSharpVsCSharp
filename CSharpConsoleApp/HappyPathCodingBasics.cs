using System.Threading.Tasks;

namespace CSharpConsoleApp
{
    public class HappyPathCodingBasics
    {
        public async Task<int> Asynchronous(int id)
        {
            return id + 1;
        }

        public async Task<int> Caller(int id)
        {
            var r = await Asynchronous(id);
            return r;
        }

        public int? Optional(int id)
        {
            var r =
                id % 2 == 0 ?
                    (int?)id :
                    null;
            return r;
        }

        public (int?, string?) Result(int id)
        {
            var r = id % 2 == 0 ?
                ((int?)id, null) :
                (default(int?), "odd number");
            return r;
        }

        public async Task<(int?, string?)> AsyncResult(
            int id)
        {
            var async =
                await Asynchronous(id).ConfigureAwait(false);

            var optional = Optional(id);
            if (optional == null)
            {
                return (null, "no value");
            }

            var result = Result(id);
            if (result.Item1 == null)
            {
                return result;
            }

            return
                (
                    async + optional.Value + result.Item1.Value,
                    null
                );
        }
    }
}