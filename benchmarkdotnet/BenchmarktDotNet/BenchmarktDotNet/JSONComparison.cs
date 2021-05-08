using BenchmarkDotNet.Attributes;

namespace Perform_BenchmarkDotNet
{
    [RankColumn]
    [MemoryDiagnoser]
    public class JSONComparison
    {
        [Benchmark]
        public void ParseJsonNewton()
        {
            string strBookName = "{\"name\": Test, \"age\": 31, \"city\": New York}";
            string strParseJSON = Newtonsoft.Json.JsonConvert.SerializeObject(strBookName);
        }

        [Benchmark]
        public void ParseJsonText()
        {
            string strBookName = "{\"name\": Test, \"age\": 31, \"city\": New York}";
            string strParseJSON = System.Text.Json.JsonSerializer.Serialize(strBookName);
        }
    }
}
