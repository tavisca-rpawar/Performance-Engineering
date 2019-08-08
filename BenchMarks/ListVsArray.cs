using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchMarks
{

    public class ListVsArray
    {
        [Params(100)]
        public int countNumber { get; set; }

        List<int> list = new List<int>();
        int[] array;
        [Benchmark]
        public void AddNumberInArray()
        {
            array = new int[countNumber];
            for(int i=0;i<countNumber;i++)
            {
                array[i] = i;
            }
        }
        [Benchmark]
        public void AddNumberInList()
        {
            for (int i = 0; i < countNumber; i++)
            {
                list.Add(i);
            }
        }

    }

}
