using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace INT86Payload
{

    public class icon_move
    {
        public void moves_icon()
        {
            while (true)
            {
                Random rand;
                rand = new Random();
                int x = Screen.PrimaryScreen.Bounds.Width; int y = Screen.PrimaryScreen.Bounds.Height;
                IntPtr handle = dllimport.dport.FindWindow("Progman", null);
                handle = dllimport.dport.FindWindowEx(handle, IntPtr.Zero, "SHELLDLL_DefView", null);
                handle = dllimport.dport.FindWindowEx(handle, IntPtr.Zero, "SysListView32", null);
                DirectoryInfo dirinfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                FileInfo[] finfo = dirinfo.GetFiles();
                for (int num = 0; num <= finfo.Length + 2; num++)
                {
                    dllimport.dport.SendMessage(handle, dllimport.dport.LVM_SETITEMPOSITION, (IntPtr)num, dllimport.dport.MakeLParam(rand.Next(x), rand.Next(y)));
                    Thread.Sleep(100);
                }
            }
        }
    }

}
