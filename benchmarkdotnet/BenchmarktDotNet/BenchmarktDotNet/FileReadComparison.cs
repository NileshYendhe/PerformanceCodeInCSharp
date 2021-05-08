using BenchmarkDotNet.Attributes;
using System.IO;
using System.Threading.Tasks;

namespace Perform_BenchmarkDotNet
{
    [RankColumn]
    [MemoryDiagnoser]
    public class FileReadComparison
    {
        private const string strFileName = @""; //TODO :: Provide the file name before executing

        [Benchmark]
        public void ReadLine()
        {
            using var stream = File.Open(strFileName, FileMode.Open);
            using var reader = new StreamReader(stream);
            var line = reader.ReadLine();
        }

        [Benchmark]
        public void ReadLines()
        {
            var file = File.ReadLines(strFileName);
        }

        [Benchmark]
        public void ReadAllText()
        {
            var text = File.ReadAllText(strFileName);
        }

        [Benchmark]
        public void ReadAllBytes()
        {
            var bytes = File.ReadAllBytes(strFileName);
        }

        [Benchmark]
        public void ReadAllLines()
        {
            string[] lines = File.ReadAllLines(strFileName);
        }

        [Benchmark]
        public async Task ReadFileTaskAsync()
        {
            string[] strFileContent = File.ReadAllLinesAsync(strFileName).Result;
        }
    }
}
