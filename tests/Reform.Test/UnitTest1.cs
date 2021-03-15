using Reform.Test.Utils;
using Xunit;
using Xunit.Abstractions;

namespace Reform.Test
{
    public class UnitTest1
    {

        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void Test1()
        {



            var result = new object();


            output.Dump(result);

        }
    }
}
