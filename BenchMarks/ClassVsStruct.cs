using BenchmarkDotNet.Attributes;

namespace BenchMarks
{
    public class ClassVsStruct
    {
        [Benchmark]
        public void ForStruct()
        {
            ExampleStruct myStruct = new ExampleStruct();
            myStruct.value = new int[100];
            for (int i = 0; i < 100; i++)
                myStruct.value[i] = i;
        }
        [Benchmark]
        public void ForClass()
        {
            ExampleClass myClass = new ExampleClass();
            myClass.value = new int[100];
            for (int i = 0; i < 100; i++)
                myClass.value[i] = i;
        }
    }
    struct ExampleStruct
    {
        public int[] value;
    }
    class ExampleClass
    {
        public int[] value;
    }

}
