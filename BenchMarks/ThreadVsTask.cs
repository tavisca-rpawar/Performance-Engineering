using BenchmarkDotNet.Attributes;
using System.Threading;
using System.Threading.Tasks;

namespace BenchMarks
{
    public class ThreadVsTask
    {
        [Benchmark]
        public void ForThread()
        {
            Thread thread1 = new Thread(SleepForSmallTime);
            Thread thread2 = new Thread(SleepForLargeTime);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }
        [Benchmark]
        public void ForTask()
        {
            Task.Run(async () =>
            {
                var task1 = DelayTaskForSmallTime();
                var task2 = DelayTaskForLargeTime();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();
        }
        public void SleepForSmallTime()
        {
            Thread.Sleep(2000);
        }
        public void SleepForLargeTime()
        {
            Thread.Sleep(4000);
        }
        public static async Task DelayTaskForSmallTime()
        {
            await Task.Delay(2000);
        }
        public static async Task DelayTaskForLargeTime()
        {
            await Task.Delay(4000);
        }

    }
}
