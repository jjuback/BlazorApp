using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BlazorApp.Data
{
    public class ProcessService
    {
        public Task<Process[]> GetProcessesAsync()
        {
            return Task.FromResult(Process.GetProcesses().Where(p => !String.IsNullOrEmpty(p.ProcessName)).ToArray());
        }
    }
}
