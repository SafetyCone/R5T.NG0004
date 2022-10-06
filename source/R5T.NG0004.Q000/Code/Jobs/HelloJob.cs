using System;
using System.Threading.Tasks;

using Quartz;


namespace R5T.NG0004.Q000
{
    public class HelloJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }
    }
}
