using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchMarks
{
    public class StringVsStringBuilder
    {
        string firstName = "Rupika ";
        string lastName = "Pawar";
        public string stringBuilder { get; set; }
        [Benchmark]
        public void ConcatUsingString()
        {
            string fullNmae;

            for (int i = 0; i < 100; i++)
                fullNmae = firstName + lastName;
        }
        [Benchmark]
        public void ConcatUsingStringBuilder()
        {
            StringBuilder fullName = new StringBuilder(firstName);
            for (int i = 0; i < 100; i++)
                fullName.Append(lastName);
        }
    }

}
