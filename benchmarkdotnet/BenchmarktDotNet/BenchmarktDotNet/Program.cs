using BenchmarkDotNet.Running;

namespace Perform_BenchmarkDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringBuilderComparison>();
            BenchmarkRunner.Run<DynamicComparison>();
            BenchmarkRunner.Run<JSONComparison>();
            BenchmarkRunner.Run<FileReadComparison>();
        }
    }
}
