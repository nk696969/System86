using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;

namespace INT86x
{
    public class cmd_func
    {
        public static void cmd(string filename, string argue)
        {
            ProcessStartInfo cmd_proc = new ProcessStartInfo();
            cmd_proc.FileName = filename;
            cmd_proc.WindowStyle = ProcessWindowStyle.Hidden;
            cmd_proc.Arguments = argue;
            Process.Start(cmd_proc);
            return;
        }
    }
}
