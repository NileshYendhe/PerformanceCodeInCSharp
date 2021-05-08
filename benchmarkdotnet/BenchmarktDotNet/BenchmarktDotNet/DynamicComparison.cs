using BenchmarkDotNet.Attributes;
using Newtonsoft.Json.Linq;

namespace Perform_BenchmarkDotNet
{
    [RankColumn]
    [MemoryDiagnoser]
    public class DynamicComparison
    {
        [Benchmark]
        public void PayloadJObject()
        {
            string strBookName = $"Dot Net Framework";
            double dblBookPrice = 450.58;
            string strBookAuthor = $"Microsoft";
            JObject jsonPayload = new JObject();
            jsonPayload["BookName"] = strBookName;
            jsonPayload["BookPrice"] = dblBookPrice;
            jsonPayload["BookAuthor"] = strBookAuthor;
        }

        [Benchmark]
        public void PayloadDynamic()
        {
            string strBookName = $"Dot Net Framework";
            double dblBookPrice = 450.58;
            string strBookAuthor = $"Microsoft";
            dynamic jsonPayload = new JObject();
            jsonPayload.BookName = strBookName;
            jsonPayload.BookPrice = dblBookPrice;
            jsonPayload.BookAuthor = strBookAuthor;
        }
    }
}
