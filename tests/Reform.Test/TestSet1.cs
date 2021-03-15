using System.IO;
using System.Reflection;
using Octopus.CoreParsers.Hcl;
using Reform.Core;
using Reform.Test.Utils;
using Xunit;
using Xunit.Abstractions;

namespace Reform.Test
{
    public class TestSet1
    {
        private readonly ITestOutputHelper output;

        public TestSet1(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void Test1()
        {
            var src = LoadFile("test1.hcl");
            var parser = new Parser();

            var result = parser.Parse(src);
            
            output.Dump(result);
        }


        protected string LoadFile(string fileName, string directory = "Cases")
        {
            var templatesPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, directory);

            return HclParser.NormalizeLineEndings(File.ReadAllText(Path.Combine(templatesPath, fileName))).Trim();
        }
    }
}