using BenchmarkDotNet.Running;
using System;

namespace BenchMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListVsArraySummary = BenchmarkRunner.Run<ListVsArray>();
            var ForVsForeachSummary = BenchmarkRunner.Run<ForVsForeach>();
            var StringVsStringBuilkderSummary = BenchmarkRunner.Run<StringVsStringBuilder>();
            var ClassVsStructSummary = BenchmarkRunner.Run<ClassVsStruct>();
            var ThreadVsTaskSummary = BenchmarkRunner.Run<ThreadVsTask>();

        }
    }

}
