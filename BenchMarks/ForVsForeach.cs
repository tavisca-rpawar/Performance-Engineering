using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchMarks
{
    public class ForVsForeach
    {
        [Params(100)]
        public int countNumber { get; set; }

        private List<int> list1 = new List<int>();
        private List<int> list2 = new List<int>();
        private List<int> list3 = new List<int>();


        public void InitialisingList1()
        {
            for (int i = 0; i < countNumber; i++)
            {
                list1.Add(i);
            }
        }

        [Benchmark]
        public void AddNumberInListUsingFor()
        {
            for (int i = 0; i < countNumber; i++)
            {
                list2.Add(i);
            }
        }

        [Benchmark]

        public void AddNumberInListUsingForeach()
        {
            foreach (int number in list1)
            {
                list3.Add(number);
            }
        }

    }

}
