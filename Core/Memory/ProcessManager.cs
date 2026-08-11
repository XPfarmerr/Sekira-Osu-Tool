using System;
using System.Diagnostics;

namespace InternalSDK.Memory
{
    public class ProcessManager
    {
        public int ProcessId { get; private set; }
        public IntPtr BaseAddress { get; private set; }

        public bool Attach(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 0)
            {
                ProcessId = processes[0].Id;
                BaseAddress = processes[0].MainModule.BaseAddress;
                return true;
            }
            return false;
        }
    }
}
