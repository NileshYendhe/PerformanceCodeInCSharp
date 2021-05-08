﻿using BenchmarkDotNet.Attributes;
using System.Text;

namespace Perform_BenchmarkDotNet
{
    [RankColumn]
    [MemoryDiagnoser]
    public class StringBuilderComparison
    {
        public string string1 = "a";
        public string string2 = "b";
        public string string3 = "c";
        public string string4 = "d";
        public string string5 = "e";

        [Benchmark(Baseline = true)]
        public string Interpolation()
        {
            return $"{string1} {string2} {string3} {string4} {string5}";
        }

        [Benchmark]
        public string PlusOperator()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5;
        }

        [Benchmark]
        public string StringConcatenate()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5);
        }

        [Benchmark]
        public string StringJoin()
        {
            return string.Join(" ", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringFormat()
        {
            return string.Format("{0} {1} {2} {3} {4}", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringBuilderAppend()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            return builder.ToString();
        }

    }
}
