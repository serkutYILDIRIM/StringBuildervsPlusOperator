using BenchmarkDotNet.Attributes;
using System.Text;

namespace StringBuildervsPlusOperator
{
    [MemoryDiagnoser(false)]
    public class StringConcatenationOperations
    {
        [Benchmark]
        public string StringConcatenationUsingStringBuilder()
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                stringBuilder.Append("Serkut Yildirim" + i);
            }

            return stringBuilder.ToString();
        }

        [Benchmark]
        public string StringConcatenationUsingPlusOperator()
        {
            var finalString = string.Empty;

            for (int i = 0; i < 1000; i++)
            {
                finalString += "Serkut Yildirim" + i;
            }

            return finalString;
        }
    }
}
