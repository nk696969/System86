using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace INT86x
{
    internal class dllimport
    {
        public class dport
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr hWndChildAfter, string className, string windowTitle);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
            public static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
            [DllImport("USER32.dll")]
            public static extern short GetKeyState(VirtualKeyStates nVirtKey);
            [DllImport("user32.dll")]
            public static extern bool BlockInput(bool fBlockIt);

            public const int KEY_PRESSED = 0x8000;

            public enum VirtualKeyStates : int
            {
                VK_LBUTTON = 0x01,
                VK_RBUTTON = 0x02,
                VK_CANCEL = 0x03,
                VK_MBUTTON = 0x04,
                //
                VK_XBUTTON1 = 0x05,
                VK_XBUTTON2 = 0x06,
                //
                VK_BACK = 0x08,
                VK_TAB = 0x09,
                //
                VK_CLEAR = 0x0C,
                VK_RETURN = 0x0D,
                //
                VK_SHIFT = 0x10,
                VK_CONTROL = 0x11,
                VK_MENU = 0x12,
                VK_PAUSE = 0x13,
                VK_CAPITAL = 0x14,
                //
                VK_KANA = 0x15,
                VK_HANGEUL = 0x15,  /* old name - should be here for compatibility */
                VK_HANGUL = 0x15,
                VK_JUNJA = 0x17,
                VK_FINAL = 0x18,
                VK_HANJA = 0x19,
                VK_KANJI = 0x19,
                //
                VK_ESCAPE = 0x1B,
                //
                VK_CONVERT = 0x1C,
                VK_NONCONVERT = 0x1D,
                VK_ACCEPT = 0x1E,
                VK_MODECHANGE = 0x1F,
                //
                VK_SPACE = 0x20,
                VK_PRIOR = 0x21,
                VK_NEXT = 0x22,
                VK_END = 0x23,
                VK_HOME = 0x24,
                VK_LEFT = 0x25,
                VK_UP = 0x26,
                VK_RIGHT = 0x27,
                VK_DOWN = 0x28,
                VK_SELECT = 0x29,
                VK_PRINT = 0x2A,
                VK_EXECUTE = 0x2B,
                VK_SNAPSHOT = 0x2C,
                VK_INSERT = 0x2D,
                VK_DELETE = 0x2E,
                VK_HELP = 0x2F,
                //
                VK_LWIN = 0x5B,
                VK_RWIN = 0x5C,
                VK_APPS = 0x5D,
                //
                VK_SLEEP = 0x5F,
                //
                VK_NUMPAD0 = 0x60,
                VK_NUMPAD1 = 0x61,
                VK_NUMPAD2 = 0x62,
                VK_NUMPAD3 = 0x63,
                VK_NUMPAD4 = 0x64,
                VK_NUMPAD5 = 0x65,
                VK_NUMPAD6 = 0x66,
                VK_NUMPAD7 = 0x67,
                VK_NUMPAD8 = 0x68,
                VK_NUMPAD9 = 0x69,
                VK_MULTIPLY = 0x6A,
                VK_ADD = 0x6B,
                VK_SEPARATOR = 0x6C,
                VK_SUBTRACT = 0x6D,
                VK_DECIMAL = 0x6E,
                VK_DIVIDE = 0x6F,
                VK_F1 = 0x70,
                VK_F2 = 0x71,
                VK_F3 = 0x72,
                VK_F4 = 0x73,
                VK_F5 = 0x74,
                VK_F6 = 0x75,
                VK_F7 = 0x76,
                VK_F8 = 0x77,
                VK_F9 = 0x78,
                VK_F10 = 0x79,
                VK_F11 = 0x7A,
                VK_F12 = 0x7B,
                VK_F13 = 0x7C,
                VK_F14 = 0x7D,
                VK_F15 = 0x7E,
                VK_F16 = 0x7F,
                VK_F17 = 0x80,
                VK_F18 = 0x81,
                VK_F19 = 0x82,
                VK_F20 = 0x83,
                VK_F21 = 0x84,
                VK_F22 = 0x85,
                VK_F23 = 0x86,
                VK_F24 = 0x87,
                //
                VK_NUMLOCK = 0x90,
                VK_SCROLL = 0x91,
                //
                VK_OEM_NEC_EQUAL = 0x92,   // '=' key on numpad
                                           //
                VK_OEM_FJ_JISHO = 0x92,   // 'Dictionary' key
                VK_OEM_FJ_MASSHOU = 0x93,   // 'Unregister word' key
                VK_OEM_FJ_TOUROKU = 0x94,   // 'Register word' key
                VK_OEM_FJ_LOYA = 0x95,   // 'Left OYAYUBI' key
                VK_OEM_FJ_ROYA = 0x96,   // 'Right OYAYUBI' key
                                         //
                VK_LSHIFT = 0xA0,
                VK_RSHIFT = 0xA1,
                VK_LCONTROL = 0xA2,
                VK_RCONTROL = 0xA3,
                VK_LMENU = 0xA4,
                VK_RMENU = 0xA5,
                //
                VK_BROWSER_BACK = 0xA6,
                VK_BROWSER_FORWARD = 0xA7,
                VK_BROWSER_REFRESH = 0xA8,
                VK_BROWSER_STOP = 0xA9,
                VK_BROWSER_SEARCH = 0xAA,
                VK_BROWSER_FAVORITES = 0xAB,
                VK_BROWSER_HOME = 0xAC,
                //
                VK_VOLUME_MUTE = 0xAD,
                VK_VOLUME_DOWN = 0xAE,
                VK_VOLUME_UP = 0xAF,
                VK_MEDIA_NEXT_TRACK = 0xB0,
                VK_MEDIA_PREV_TRACK = 0xB1,
                VK_MEDIA_STOP = 0xB2,
                VK_MEDIA_PLAY_PAUSE = 0xB3,
                VK_LAUNCH_MAIL = 0xB4,
                VK_LAUNCH_MEDIA_SELECT = 0xB5,
                VK_LAUNCH_APP1 = 0xB6,
                VK_LAUNCH_APP2 = 0xB7,
                //
                VK_OEM_1 = 0xBA,   // ';:' for US
                VK_OEM_PLUS = 0xBB,   // '+' any country
                VK_OEM_COMMA = 0xBC,   // ',' any country
                VK_OEM_MINUS = 0xBD,   // '-' any country
                VK_OEM_PERIOD = 0xBE,   // '.' any country
                VK_OEM_2 = 0xBF,   // '/?' for US
                VK_OEM_3 = 0xC0,   // '`~' for US
                                   //
                VK_OEM_4 = 0xDB,  //  '[{' for US
                VK_OEM_5 = 0xDC,  //  '\|' for US
                VK_OEM_6 = 0xDD,  //  ']}' for US
                VK_OEM_7 = 0xDE,  //  ''"' for US
                VK_OEM_8 = 0xDF,
                //
                VK_OEM_AX = 0xE1,  //  'AX' key on Japanese AX kbd
                VK_OEM_102 = 0xE2,  //  "<>" or "\|" on RT 102-key kbd.
                VK_ICO_HELP = 0xE3,  //  Help key on ICO
                VK_ICO_00 = 0xE4,  //  00 key on ICO
                                   //
                VK_PROCESSKEY = 0xE5,
                //
                VK_ICO_CLEAR = 0xE6,
                //
                VK_PACKET = 0xE7,
                //
                VK_OEM_RESET = 0xE9,
                VK_OEM_JUMP = 0xEA,
                VK_OEM_PA1 = 0xEB,
                VK_OEM_PA2 = 0xEC,
                VK_OEM_PA3 = 0xED,
                VK_OEM_WSCTRL = 0xEE,
                VK_OEM_CUSEL = 0xEF,
                VK_OEM_ATTN = 0xF0,
                VK_OEM_FINISH = 0xF1,
                VK_OEM_COPY = 0xF2,
                VK_OEM_AUTO = 0xF3,
                VK_OEM_ENLW = 0xF4,
                VK_OEM_BACKTAB = 0xF5,
                //
                VK_ATTN = 0xF6,
                VK_CRSEL = 0xF7,
                VK_EXSEL = 0xF8,
                VK_EREOF = 0xF9,
                VK_PLAY = 0xFA,
                VK_ZOOM = 0xFB,
                VK_NONAME = 0xFC,
                VK_PA1 = 0xFD,
                VK_OEM_CLEAR = 0xFE
            }

            public static IntPtr MakeLParam(int wLow, int wHigh)
            {
                return (IntPtr)(((short)wHigh << 16) | (wLow & 0xffff));
            }
            public const uint LVM_SETITEMPOSITION = 0x1000 + 15;

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr GetDC(IntPtr hWnd);
            [DllImport("gdi32.dll")]
            public static extern bool StretchBlt(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest,
            IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc,
            TernaryRasterOperations dwRop);
            [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
            public static extern bool DeleteDC(IntPtr hdc);
            public enum TernaryRasterOperations : uint
            {
                /// <summary>dest = source</summary>
                SRCCOPY = 0x00CC0020,
                /// <summary>dest = source OR dest</summary>
                SRCPAINT = 0x00EE0086,
                /// <summary>dest = source AND dest</summary>
                SRCAND = 0x008800C6,
                /// <summary>dest = source XOR dest</summary>
                SRCINVERT = 0x00660046,
                /// <summary>dest = source AND (NOT dest)</summary>
                SRCERASE = 0x00440328,
                /// <summary>dest = (NOT source)</summary>
                NOTSRCCOPY = 0x00330008,
                /// <summary>dest = (NOT src) AND (NOT dest)</summary>
                NOTSRCERASE = 0x001100A6,
                /// <summary>dest = (source AND pattern)</summary>
                MERGECOPY = 0x00C000CA,
                /// <summary>dest = (NOT source) OR dest</summary>
                MERGEPAINT = 0x00BB0226,
                /// <summary>dest = pattern</summary>
                PATCOPY = 0x00F00021,
                /// <summary>dest = DPSnoo</summary>
                PATPAINT = 0x00FB0A09,
                /// <summary>dest = pattern XOR dest</summary>
                PATINVERT = 0x005A0049,
                /// <summary>dest = (NOT dest)</summary>
                DSTINVERT = 0x00550009,
                /// <summary>dest = BLACK</summary>
                BLACKNESS = 0x00000042,
                /// <summary>dest = WHITE</summary>
                WHITENESS = 0x00FF0062,
                /// <summary>
                /// Capture window as seen on screen.  This includes layered windows
                /// such as WPF windows with AllowsTransparency="true"
                /// </summary>
                CAPTUREBLT = 0x40000000,
                CUSTOM = 0x00100C85
            }
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetCursorPos(int x, int y);
            [DllImport("user32.dll")]
            public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData,
            UIntPtr dwExtraInfo);
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetCursorPos(out POINT lpPoint);
            [DllImport("user32.dll")]
            public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);
            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr GetWindow(IntPtr hWnd, GetWindowType uCmd);

            public static int isCritical = 1;
            public static int BreakOnTermination = 0x1D;

            public const uint GenericRead = 0x80000000;
            public const uint GenericWrite = 0x40000000;
            public const uint GenericExecute = 0x20000000;
            public const uint GenericAll = 0x10000000;

            public const uint FileShareRead = 0x1;
            public const uint FileShareWrite = 0x2;

            //dwCreationDisposition
            public const uint OpenExisting = 0x3;

            //dwFlagsAndAttributes
            public const uint FileFlagDeleteOnClose = 0x4000000;

            public const uint MbrSize = 512u;

            public const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
            public const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
            public const uint MOUSEEVENTF_LEFTUP = 0x0004;
            public const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
            public const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
            public const uint MOUSEEVENTF_MOVE = 0x0001;
            public const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
            public const uint MOUSEEVENTF_RIGHTUP = 0x0010;
            public const uint MOUSEEVENTF_XDOWN = 0x0080;
            public const uint MOUSEEVENTF_XUP = 0x0100;
            public const uint MOUSEEVENTF_WHEEL = 0x0800;
            public const uint MOUSEEVENTF_HWHEEL = 0x01000;

            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int Left;        // x position of upper-left corner
                public int Top;         // y position of upper-left corner
                public int Right;       // x position of lower-right corner
                public int Bottom;      // y position of lower-right corner
            }
            public enum GetWindowType : uint
            {
                /// <summary>
                /// The retrieved handle identifies the window of the same type that is highest in the Z order.
                /// <para/>
                /// If the specified window is a topmost window, the handle identifies a topmost window.
                /// If the specified window is a top-level window, the handle identifies a top-level window.
                /// If the specified window is a child window, the handle identifies a sibling window.
                /// </summary>
                GW_HWNDFIRST = 0,
                /// <summary>
                /// The retrieved handle identifies the window of the same type that is lowest in the Z order.
                /// <para />
                /// If the specified window is a topmost window, the handle identifies a topmost window.
                /// If the specified window is a top-level window, the handle identifies a top-level window.
                /// If the specified window is a child window, the handle identifies a sibling window.
                /// </summary>
                GW_HWNDLAST = 1,
                /// <summary>
                /// The retrieved handle identifies the window below the specified window in the Z order.
                /// <para />
                /// If the specified window is a topmost window, the handle identifies a topmost window.
                /// If the specified window is a top-level window, the handle identifies a top-level window.
                /// If the specified window is a child window, the handle identifies a sibling window.
                /// </summary>
                GW_HWNDNEXT = 2,
                /// <summary>
                /// The retrieved handle identifies the window above the specified window in the Z order.
                /// <para />
                /// If the specified window is a topmost window, the handle identifies a topmost window.
                /// If the specified window is a top-level window, the handle identifies a top-level window.
                /// If the specified window is a child window, the handle identifies a sibling window.
                /// </summary>
                GW_HWNDPREV = 3,
                /// <summary>
                /// The retrieved handle identifies the specified window's owner window, if any.
                /// </summary>
                GW_OWNER = 4,
                /// <summary>
                /// The retrieved handle identifies the child window at the top of the Z order,
                /// if the specified window is a parent window; otherwise, the retrieved handle is NULL.
                /// The function examines only child windows of the specified window. It does not examine descendant windows.
                /// </summary>
                GW_CHILD = 5,
                /// <summary>
                /// The retrieved handle identifies the enabled popup window owned by the specified window (the
                /// search uses the first such window found using GW_HWNDNEXT); otherwise, if there are no enabled
                /// popup windows, the retrieved handle is that of the specified window.
                /// </summary>
                GW_ENABLEDPOPUP = 6
            }
            public enum MouseEventFlags : uint
            {
                LEFTDOWN = 0x00000002,
                LEFTUP = 0x00000004,
                MIDDLEDOWN = 0x00000020,
                MIDDLEUP = 0x00000040,
                MOVE = 0x00000001,
                ABSOLUTE = 0x00008000,
                RIGHTDOWN = 0x00000008,
                RIGHTUP = 0x00000010,
                WHEEL = 0x00000800,
                XDOWN = 0x00000080,
                XUP = 0x00000100
            }

            public enum MouseEventDataXButtons : uint
            {
                XBUTTON1 = 0x00000001,
                XBUTTON2 = 0x00000002
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int X;
                public int Y;

                public POINT(int x, int y)
                {
                    this.X = x;
                    this.Y = y;
                }

                public static implicit operator System.Drawing.Point(POINT p)
                {
                    return new System.Drawing.Point(p.X, p.Y);
                }

                public static implicit operator POINT(System.Drawing.Point p)
                {
                    return new POINT(p.X, p.Y);
                }

                public override string ToString()
                {
                    return $"X: {X}, Y: {Y}";
                }
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct INPUT
            {
                internal InputType type;
                internal InputUnion U;
                public static int Size
                {
                    get { return Marshal.SizeOf(typeof(INPUT)); }
                }
            }

            public enum InputType : uint
            {
                INPUT_MOUSE,
                INPUT_KEYBOARD,
                INPUT_HARDWARE
            }

            [StructLayout(LayoutKind.Explicit)]
            public struct InputUnion
            {
                [FieldOffset(0)]
                internal MOUSEINPUT mi;
                [FieldOffset(0)]
                internal KEYBDINPUT ki;
                [FieldOffset(0)]
                internal HARDWAREINPUT hi;
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct KEYBDINPUT
            {
                internal VirtualKeyShort wVk;
                internal ScanCodeShort wScan;
                internal KEYEVENTF dwFlags;
                internal int time;
                internal UIntPtr dwExtraInfo;
            }
            [Flags]
            public enum KEYEVENTF : uint
            {
                EXTENDEDKEY = 0x0001,
                KEYUP = 0x0002,
                SCANCODE = 0x0008,
                UNICODE = 0x0004
            }

            public enum VirtualKeyShort : short
            {
                ///<summary>
                ///Left mouse button
                ///</summary>
                LBUTTON = 0x01,
                ///<summary>
                ///Right mouse button
                ///</summary>
                RBUTTON = 0x02,
                ///<summary>
                ///Control-break processing
                ///</summary>
                CANCEL = 0x03,
                ///<summary>
                ///Middle mouse button (three-button mouse)
                ///</summary>
                MBUTTON = 0x04,
                ///<summary>
                ///Windows 2000/XP: X1 mouse button
                ///</summary>
                XBUTTON1 = 0x05,
                ///<summary>
                ///Windows 2000/XP: X2 mouse button
                ///</summary>
                XBUTTON2 = 0x06,
                ///<summary>
                ///BACKSPACE key
                ///</summary>
                BACK = 0x08,
                ///<summary>
                ///TAB key
                ///</summary>
                TAB = 0x09,
                ///<summary>
                ///CLEAR key
                ///</summary>
                CLEAR = 0x0C,
                ///<summary>
                ///ENTER key
                ///</summary>
                RETURN = 0x0D,
                ///<summary>
                ///SHIFT key
                ///</summary>
                SHIFT = 0x10,
                ///<summary>
                ///CTRL key
                ///</summary>
                CONTROL = 0x11,
                ///<summary>
                ///ALT key
                ///</summary>
                MENU = 0x12,
                ///<summary>
                ///PAUSE key
                ///</summary>
                PAUSE = 0x13,
                ///<summary>
                ///CAPS LOCK key
                ///</summary>
                CAPITAL = 0x14,
                ///<summary>
                ///Input Method Editor (IME) Kana mode
                ///</summary>
                KANA = 0x15,
                ///<summary>
                ///IME Hangul mode
                ///</summary>
                HANGUL = 0x15,
                ///<summary>
                ///IME Junja mode
                ///</summary>
                JUNJA = 0x17,
                ///<summary>
                ///IME final mode
                ///</summary>
                FINAL = 0x18,
                ///<summary>
                ///IME Hanja mode
                ///</summary>
                HANJA = 0x19,
                ///<summary>
                ///IME Kanji mode
                ///</summary>
                KANJI = 0x19,
                ///<summary>
                ///ESC key
                ///</summary>
                ESCAPE = 0x1B,
                ///<summary>
                ///IME convert
                ///</summary>
                CONVERT = 0x1C,
                ///<summary>
                ///IME nonconvert
                ///</summary>
                NONCONVERT = 0x1D,
                ///<summary>
                ///IME accept
                ///</summary>
                ACCEPT = 0x1E,
                ///<summary>
                ///IME mode change request
                ///</summary>
                MODECHANGE = 0x1F,
                ///<summary>
                ///SPACEBAR
                ///</summary>
                SPACE = 0x20,
                ///<summary>
                ///PAGE UP key
                ///</summary>
                PRIOR = 0x21,
                ///<summary>
                ///PAGE DOWN key
                ///</summary>
                NEXT = 0x22,
                ///<summary>
                ///END key
                ///</summary>
                END = 0x23,
                ///<summary>
                ///HOME key
                ///</summary>
                HOME = 0x24,
                ///<summary>
                ///LEFT ARROW key
                ///</summary>
                LEFT = 0x25,
                ///<summary>
                ///UP ARROW key
                ///</summary>
                UP = 0x26,
                ///<summary>
                ///RIGHT ARROW key
                ///</summary>
                RIGHT = 0x27,
                ///<summary>
                ///DOWN ARROW key
                ///</summary>
                DOWN = 0x28,
                ///<summary>
                ///SELECT key
                ///</summary>
                SELECT = 0x29,
                ///<summary>
                ///PRINT key
                ///</summary>
                PRINT = 0x2A,
                ///<summary>
                ///EXECUTE key
                ///</summary>
                EXECUTE = 0x2B,
                ///<summary>
                ///PRINT SCREEN key
                ///</summary>
                SNAPSHOT = 0x2C,
                ///<summary>
                ///INS key
                ///</summary>
                INSERT = 0x2D,
                ///<summary>
                ///DEL key
                ///</summary>
                DELETE = 0x2E,
                ///<summary>
                ///HELP key
                ///</summary>
                HELP = 0x2F,
                ///<summary>
                ///0 key
                ///</summary>
                KEY_0 = 0x30,
                ///<summary>
                ///1 key
                ///</summary>
                KEY_1 = 0x31,
                ///<summary>
                ///2 key
                ///</summary>
                KEY_2 = 0x32,
                ///<summary>
                ///3 key
                ///</summary>
                KEY_3 = 0x33,
                ///<summary>
                ///4 key
                ///</summary>
                KEY_4 = 0x34,
                ///<summary>
                ///5 key
                ///</summary>
                KEY_5 = 0x35,
                ///<summary>
                ///6 key
                ///</summary>
                KEY_6 = 0x36,
                ///<summary>
                ///7 key
                ///</summary>
                KEY_7 = 0x37,
                ///<summary>
                ///8 key
                ///</summary>
                KEY_8 = 0x38,
                ///<summary>
                ///9 key
                ///</summary>
                KEY_9 = 0x39,
                ///<summary>
                ///A key
                ///</summary>
                KEY_A = 0x41,
                ///<summary>
                ///B key
                ///</summary>
                KEY_B = 0x42,
                ///<summary>
                ///C key
                ///</summary>
                KEY_C = 0x43,
                ///<summary>
                ///D key
                ///</summary>
                KEY_D = 0x44,
                ///<summary>
                ///E key
                ///</summary>
                KEY_E = 0x45,
                ///<summary>
                ///F key
                ///</summary>
                KEY_F = 0x46,
                ///<summary>
                ///G key
                ///</summary>
                KEY_G = 0x47,
                ///<summary>
                ///H key
                ///</summary>
                KEY_H = 0x48,
                ///<summary>
                ///I key
                ///</summary>
                KEY_I = 0x49,
                ///<summary>
                ///J key
                ///</summary>
                KEY_J = 0x4A,
                ///<summary>
                ///K key
                ///</summary>
                KEY_K = 0x4B,
                ///<summary>
                ///L key
                ///</summary>
                KEY_L = 0x4C,
                ///<summary>
                ///M key
                ///</summary>
                KEY_M = 0x4D,
                ///<summary>
                ///N key
                ///</summary>
                KEY_N = 0x4E,
                ///<summary>
                ///O key
                ///</summary>
                KEY_O = 0x4F,
                ///<summary>
                ///P key
                ///</summary>
                KEY_P = 0x50,
                ///<summary>
                ///Q key
                ///</summary>
                KEY_Q = 0x51,
                ///<summary>
                ///R key
                ///</summary>
                KEY_R = 0x52,
                ///<summary>
                ///S key
                ///</summary>
                KEY_S = 0x53,
                ///<summary>
                ///T key
                ///</summary>
                KEY_T = 0x54,
                ///<summary>
                ///U key
                ///</summary>
                KEY_U = 0x55,
                ///<summary>
                ///V key
                ///</summary>
                KEY_V = 0x56,
                ///<summary>
                ///W key
                ///</summary>
                KEY_W = 0x57,
                ///<summary>
                ///X key
                ///</summary>
                KEY_X = 0x58,
                ///<summary>
                ///Y key
                ///</summary>
                KEY_Y = 0x59,
                ///<summary>
                ///Z key
                ///</summary>
                KEY_Z = 0x5A,
                ///<summary>
                ///Left Windows key (Microsoft Natural keyboard)
                ///</summary>
                LWIN = 0x5B,
                ///<summary>
                ///Right Windows key (Natural keyboard)
                ///</summary>
                RWIN = 0x5C,
                ///<summary>
                ///Applications key (Natural keyboard)
                ///</summary>
                APPS = 0x5D,
                ///<summary>
                ///Computer Sleep key
                ///</summary>
                SLEEP = 0x5F,
                ///<summary>
                ///Numeric keypad 0 key
                ///</summary>
                NUMPAD0 = 0x60,
                ///<summary>
                ///Numeric keypad 1 key
                ///</summary>
                NUMPAD1 = 0x61,
                ///<summary>
                ///Numeric keypad 2 key
                ///</summary>
                NUMPAD2 = 0x62,
                ///<summary>
                ///Numeric keypad 3 key
                ///</summary>
                NUMPAD3 = 0x63,
                ///<summary>
                ///Numeric keypad 4 key
                ///</summary>
                NUMPAD4 = 0x64,
                ///<summary>
                ///Numeric keypad 5 key
                ///</summary>
                NUMPAD5 = 0x65,
                ///<summary>
                ///Numeric keypad 6 key
                ///</summary>
                NUMPAD6 = 0x66,
                ///<summary>
                ///Numeric keypad 7 key
                ///</summary>
                NUMPAD7 = 0x67,
                ///<summary>
                ///Numeric keypad 8 key
                ///</summary>
                NUMPAD8 = 0x68,
                ///<summary>
                ///Numeric keypad 9 key
                ///</summary>
                NUMPAD9 = 0x69,
                ///<summary>
                ///Multiply key
                ///</summary>
                MULTIPLY = 0x6A,
                ///<summary>
                ///Add key
                ///</summary>
                ADD = 0x6B,
                ///<summary>
                ///Separator key
                ///</summary>
                SEPARATOR = 0x6C,
                ///<summary>
                ///Subtract key
                ///</summary>
                SUBTRACT = 0x6D,
                ///<summary>
                ///Decimal key
                ///</summary>
                DECIMAL = 0x6E,
                ///<summary>
                ///Divide key
                ///</summary>
                DIVIDE = 0x6F,
                ///<summary>
                ///F1 key
                ///</summary>
                F1 = 0x70,
                ///<summary>
                ///F2 key
                ///</summary>
                F2 = 0x71,
                ///<summary>
                ///F3 key
                ///</summary>
                F3 = 0x72,
                ///<summary>
                ///F4 key
                ///</summary>
                F4 = 0x73,
                ///<summary>
                ///F5 key
                ///</summary>
                F5 = 0x74,
                ///<summary>
                ///F6 key
                ///</summary>
                F6 = 0x75,
                ///<summary>
                ///F7 key
                ///</summary>
                F7 = 0x76,
                ///<summary>
                ///F8 key
                ///</summary>
                F8 = 0x77,
                ///<summary>
                ///F9 key
                ///</summary>
                F9 = 0x78,
                ///<summary>
                ///F10 key
                ///</summary>
                F10 = 0x79,
                ///<summary>
                ///F11 key
                ///</summary>
                F11 = 0x7A,
                ///<summary>
                ///F12 key
                ///</summary>
                F12 = 0x7B,
                ///<summary>
                ///F13 key
                ///</summary>
                F13 = 0x7C,
                ///<summary>
                ///F14 key
                ///</summary>
                F14 = 0x7D,
                ///<summary>
                ///F15 key
                ///</summary>
                F15 = 0x7E,
                ///<summary>
                ///F16 key
                ///</summary>
                F16 = 0x7F,
                ///<summary>
                ///F17 key  
                ///</summary>
                F17 = 0x80,
                ///<summary>
                ///F18 key  
                ///</summary>
                F18 = 0x81,
                ///<summary>
                ///F19 key  
                ///</summary>
                F19 = 0x82,
                ///<summary>
                ///F20 key  
                ///</summary>
                F20 = 0x83,
                ///<summary>
                ///F21 key  
                ///</summary>
                F21 = 0x84,
                ///<summary>
                ///F22 key, (PPC only) Key used to lock device.
                ///</summary>
                F22 = 0x85,
                ///<summary>
                ///F23 key  
                ///</summary>
                F23 = 0x86,
                ///<summary>
                ///F24 key  
                ///</summary>
                F24 = 0x87,
                ///<summary>
                ///NUM LOCK key
                ///</summary>
                NUMLOCK = 0x90,
                ///<summary>
                ///SCROLL LOCK key
                ///</summary>
                SCROLL = 0x91,
                ///<summary>
                ///Left SHIFT key
                ///</summary>
                LSHIFT = 0xA0,
                ///<summary>
                ///Right SHIFT key
                ///</summary>
                RSHIFT = 0xA1,
                ///<summary>
                ///Left CONTROL key
                ///</summary>
                LCONTROL = 0xA2,
                ///<summary>
                ///Right CONTROL key
                ///</summary>
                RCONTROL = 0xA3,
                ///<summary>
                ///Left MENU key
                ///</summary>
                LMENU = 0xA4,
                ///<summary>
                ///Right MENU key
                ///</summary>
                RMENU = 0xA5,
                ///<summary>
                ///Windows 2000/XP: Browser Back key
                ///</summary>
                BROWSER_BACK = 0xA6,
                ///<summary>
                ///Windows 2000/XP: Browser Forward key
                ///</summary>
                BROWSER_FORWARD = 0xA7,
                ///<summary>
                ///Windows 2000/XP: Browser Refresh key
                ///</summary>
                BROWSER_REFRESH = 0xA8,
                ///<summary>
                ///Windows 2000/XP: Browser Stop key
                ///</summary>
                BROWSER_STOP = 0xA9,
                ///<summary>
                ///Windows 2000/XP: Browser Search key
                ///</summary>
                BROWSER_SEARCH = 0xAA,
                ///<summary>
                ///Windows 2000/XP: Browser Favorites key
                ///</summary>
                BROWSER_FAVORITES = 0xAB,
                ///<summary>
                ///Windows 2000/XP: Browser Start and Home key
                ///</summary>
                BROWSER_HOME = 0xAC,
                ///<summary>
                ///Windows 2000/XP: Volume Mute key
                ///</summary>
                VOLUME_MUTE = 0xAD,
                ///<summary>
                ///Windows 2000/XP: Volume Down key
                ///</summary>
                VOLUME_DOWN = 0xAE,
                ///<summary>
                ///Windows 2000/XP: Volume Up key
                ///</summary>
                VOLUME_UP = 0xAF,
                ///<summary>
                ///Windows 2000/XP: Next Track key
                ///</summary>
                MEDIA_NEXT_TRACK = 0xB0,
                ///<summary>
                ///Windows 2000/XP: Previous Track key
                ///</summary>
                MEDIA_PREV_TRACK = 0xB1,
                ///<summary>
                ///Windows 2000/XP: Stop Media key
                ///</summary>
                MEDIA_STOP = 0xB2,
                ///<summary>
                ///Windows 2000/XP: Play/Pause Media key
                ///</summary>
                MEDIA_PLAY_PAUSE = 0xB3,
                ///<summary>
                ///Windows 2000/XP: Start Mail key
                ///</summary>
                LAUNCH_MAIL = 0xB4,
                ///<summary>
                ///Windows 2000/XP: Select Media key
                ///</summary>
                LAUNCH_MEDIA_SELECT = 0xB5,
                ///<summary>
                ///Windows 2000/XP: Start Application 1 key
                ///</summary>
                LAUNCH_APP1 = 0xB6,
                ///<summary>
                ///Windows 2000/XP: Start Application 2 key
                ///</summary>
                LAUNCH_APP2 = 0xB7,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_1 = 0xBA,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the '+' key
                ///</summary>
                OEM_PLUS = 0xBB,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the ',' key
                ///</summary>
                OEM_COMMA = 0xBC,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the '-' key
                ///</summary>
                OEM_MINUS = 0xBD,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the '.' key
                ///</summary>
                OEM_PERIOD = 0xBE,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_2 = 0xBF,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_3 = 0xC0,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_4 = 0xDB,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_5 = 0xDC,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_6 = 0xDD,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_7 = 0xDE,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_8 = 0xDF,
                ///<summary>
                ///Windows 2000/XP: Either the angle bracket key or the backslash key on the RT 102-key keyboard
                ///</summary>
                OEM_102 = 0xE2,
                ///<summary>
                ///Windows 95/98/Me, Windows NT 4.0, Windows 2000/XP: IME PROCESS key
                ///</summary>
                PROCESSKEY = 0xE5,
                ///<summary>
                ///Windows 2000/XP: Used to pass Unicode characters as if they were keystrokes.
                ///The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information,
                ///see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
                ///</summary>
                PACKET = 0xE7,
                ///<summary>
                ///Attn key
                ///</summary>
                ATTN = 0xF6,
                ///<summary>
                ///CrSel key
                ///</summary>
                CRSEL = 0xF7,
                ///<summary>
                ///ExSel key
                ///</summary>
                EXSEL = 0xF8,
                ///<summary>
                ///Erase EOF key
                ///</summary>
                EREOF = 0xF9,
                ///<summary>
                ///Play key
                ///</summary>
                PLAY = 0xFA,
                ///<summary>
                ///Zoom key
                ///</summary>
                ZOOM = 0xFB,
                ///<summary>
                ///Reserved
                ///</summary>
                NONAME = 0xFC,
                ///<summary>
                ///PA1 key
                ///</summary>
                PA1 = 0xFD,
                ///<summary>
                ///Clear key
                ///</summary>
                OEM_CLEAR = 0xFE
            }
            public enum ScanCodeShort : short
            {
                LBUTTON = 0,
                RBUTTON = 0,
                CANCEL = 70,
                MBUTTON = 0,
                XBUTTON1 = 0,
                XBUTTON2 = 0,
                BACK = 14,
                TAB = 15,
                CLEAR = 76,
                RETURN = 28,
                SHIFT = 42,
                CONTROL = 29,
                MENU = 56,
                PAUSE = 0,
                CAPITAL = 58,
                KANA = 0,
                HANGUL = 0,
                JUNJA = 0,
                FINAL = 0,
                HANJA = 0,
                KANJI = 0,
                ESCAPE = 1,
                CONVERT = 0,
                NONCONVERT = 0,
                ACCEPT = 0,
                MODECHANGE = 0,
                SPACE = 57,
                PRIOR = 73,
                NEXT = 81,
                END = 79,
                HOME = 71,
                LEFT = 75,
                UP = 72,
                RIGHT = 77,
                DOWN = 80,
                SELECT = 0,
                PRINT = 0,
                EXECUTE = 0,
                SNAPSHOT = 84,
                INSERT = 82,
                DELETE = 83,
                HELP = 99,
                KEY_0 = 11,
                KEY_1 = 2,
                KEY_2 = 3,
                KEY_3 = 4,
                KEY_4 = 5,
                KEY_5 = 6,
                KEY_6 = 7,
                KEY_7 = 8,
                KEY_8 = 9,
                KEY_9 = 10,
                KEY_A = 30,
                KEY_B = 48,
                KEY_C = 46,
                KEY_D = 32,
                KEY_E = 18,
                KEY_F = 33,
                KEY_G = 34,
                KEY_H = 35,
                KEY_I = 23,
                KEY_J = 36,
                KEY_K = 37,
                KEY_L = 38,
                KEY_M = 50,
                KEY_N = 49,
                KEY_O = 24,
                KEY_P = 25,
                KEY_Q = 16,
                KEY_R = 19,
                KEY_S = 31,
                KEY_T = 20,
                KEY_U = 22,
                KEY_V = 47,
                KEY_W = 17,
                KEY_X = 45,
                KEY_Y = 21,
                KEY_Z = 44,
                LWIN = 91,
                RWIN = 92,
                APPS = 93,
                SLEEP = 95,
                NUMPAD0 = 82,
                NUMPAD1 = 79,
                NUMPAD2 = 80,
                NUMPAD3 = 81,
                NUMPAD4 = 75,
                NUMPAD5 = 76,
                NUMPAD6 = 77,
                NUMPAD7 = 71,
                NUMPAD8 = 72,
                NUMPAD9 = 73,
                MULTIPLY = 55,
                ADD = 78,
                SEPARATOR = 0,
                SUBTRACT = 74,
                DECIMAL = 83,
                DIVIDE = 53,
                F1 = 59,
                F2 = 60,
                F3 = 61,
                F4 = 62,
                F5 = 63,
                F6 = 64,
                F7 = 65,
                F8 = 66,
                F9 = 67,
                F10 = 68,
                F11 = 87,
                F12 = 88,
                F13 = 100,
                F14 = 101,
                F15 = 102,
                F16 = 103,
                F17 = 104,
                F18 = 105,
                F19 = 106,
                F20 = 107,
                F21 = 108,
                F22 = 109,
                F23 = 110,
                F24 = 118,
                NUMLOCK = 69,
                SCROLL = 70,
                LSHIFT = 42,
                RSHIFT = 54,
                LCONTROL = 29,
                RCONTROL = 29,
                LMENU = 56,
                RMENU = 56,
                BROWSER_BACK = 106,
                BROWSER_FORWARD = 105,
                BROWSER_REFRESH = 103,
                BROWSER_STOP = 104,
                BROWSER_SEARCH = 101,
                BROWSER_FAVORITES = 102,
                BROWSER_HOME = 50,
                VOLUME_MUTE = 32,
                VOLUME_DOWN = 46,
                VOLUME_UP = 48,
                MEDIA_NEXT_TRACK = 25,
                MEDIA_PREV_TRACK = 16,
                MEDIA_STOP = 36,
                MEDIA_PLAY_PAUSE = 34,
                LAUNCH_MAIL = 108,
                LAUNCH_MEDIA_SELECT = 109,
                LAUNCH_APP1 = 107,
                LAUNCH_APP2 = 33,
                OEM_1 = 39,
                OEM_PLUS = 13,
                OEM_COMMA = 51,
                OEM_MINUS = 12,
                OEM_PERIOD = 52,
                OEM_2 = 53,
                OEM_3 = 41,
                OEM_4 = 26,
                OEM_5 = 43,
                OEM_6 = 27,
                OEM_7 = 40,
                OEM_8 = 0,
                OEM_102 = 86,
                PROCESSKEY = 0,
                PACKET = 0,
                ATTN = 0,
                CRSEL = 0,
                EXSEL = 0,
                EREOF = 93,
                PLAY = 0,
                ZOOM = 98,
                NONAME = 0,
                PA1 = 0,
                OEM_CLEAR = 0,
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct HARDWAREINPUT
            {
                internal int uMsg;
                internal short wParamL;
                internal short wParamH;
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct MOUSEINPUT
            {
                internal int dx;
                internal int dy;
                internal int mouseData;
                internal MOUSEEVENTF dwFlags;
                internal uint time;
                internal UIntPtr dwExtraInfo;
            }
            [Flags]
            public enum MOUSEEVENTF : uint
            {
                ABSOLUTE = 0x8000,
                HWHEEL = 0x01000,
                MOVE = 0x0001,
                MOVE_NOCOALESCE = 0x2000,
                LEFTDOWN = 0x0002,
                LEFTUP = 0x0004,
                RIGHTDOWN = 0x0008,
                RIGHTUP = 0x0010,
                MIDDLEDOWN = 0x0020,
                MIDDLEUP = 0x0040,
                VIRTUALDESK = 0x4000,
                WHEEL = 0x0800,
                XDOWN = 0x0080,
                XUP = 0x0100
            }
            [DllImport("kernel32")]
            public static extern IntPtr CreateFile(
                string lpFileName,
                uint dwDesiredAccess,
                uint dwShareMode,
                IntPtr lpSecurityAttributes,
                uint dwCreationDisposition,
                uint dwFlagsAndAttributes,
                IntPtr hTemplateFile);

            [DllImport("kernel32")]
            public static extern bool WriteFile(
                IntPtr hFile,
                byte[] lpBuffer,
                uint nNumberOfBytesToWrite,
                out uint lpNumberOfBytesWritten,
                IntPtr lpOverlapped);
            [DllImport("ntdll.dll", SetLastError = true)]
            public static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

            [DllImport("user32.dll")]
            static extern int GetSystemMetrics(SystemMetric smIndex);

            public enum SystemMetric : int
            {
                SM_CXSCREEN = 0,
                SM_CYSCREEN = 1,
                SM_CYVSCROLL = 2,
                SM_CXVSCROLL = 3,
                SM_CYCAPTION = 4,
                SM_CXBORDER = 5,
                SM_CYBORDER = 6,
                SM_CXDLGFRAME = 7,
                SM_CYDLGFRAME = 8,
                SM_CYVTHUMB = 9,
                SM_CXHTHUMB = 10,
                SM_CXICON = 11,
                SM_CYICON = 12,
                SM_CXCURSOR = 13,
                SM_CYCURSOR = 14,
                SM_CYMENU = 15,
                SM_CXFULLSCREEN = 16,
                SM_CYFULLSCREEN = 17,
                SM_CYKANJIWINDOW = 18,
                SM_MOUSEWHEELPRESENT = 75,
                SM_CYHSCROLL = 20,
                SM_CXHSCROLL = 21,
                SM_DEBUG = 22,
                SM_SWAPBUTTON = 23,
                SM_RESERVED1 = 24,
                SM_RESERVED2 = 25,
                SM_RESERVED3 = 26,
                SM_RESERVED4 = 27,
                SM_CXMIN = 28,
                SM_CYMIN = 29,
                SM_CXSIZE = 30,
                SM_CYSIZE = 31,
                SM_CXFRAME = 32,
                SM_CYFRAME = 33,
                SM_CXMINTRACK = 34,
                SM_CYMINTRACK = 35,
                SM_CXDOUBLECLK = 36,
                SM_CYDOUBLECLK = 37,
                SM_CXICONSPACING = 38,
                SM_CYICONSPACING = 39,
                SM_MENUDROPALIGNMENT = 40,
                SM_PENWINDOWS = 41,
                SM_DBCSENABLED = 42,
                SM_CMOUSEBUTTONS = 43,
                SM_CXFIXEDFRAME = SM_CXDLGFRAME,
                SM_CYFIXEDFRAME = SM_CYDLGFRAME,
                SM_CXSIZEFRAME = SM_CXFRAME,
                SM_CYSIZEFRAME = SM_CYFRAME,
                SM_SECURE = 44,
                SM_CXEDGE = 45,
                SM_CYEDGE = 46,
                SM_CXMINSPACING = 47,
                SM_CYMINSPACING = 48,
                SM_CXSMICON = 49,
                SM_CYSMICON = 50,
                SM_CYSMCAPTION = 51,
                SM_CXSMSIZE = 52,
                SM_CYSMSIZE = 53,
                SM_CXMENUSIZE = 54,
                SM_CYMENUSIZE = 55,
                SM_ARRANGE = 56,
                SM_CXMINIMIZED = 57,
                SM_CYMINIMIZED = 58,
                SM_CXMAXTRACK = 59,
                SM_CYMAXTRACK = 60,
                SM_CXMAXIMIZED = 61,
                SM_CYMAXIMIZED = 62,
                SM_NETWORK = 63,
                SM_CLEANBOOT = 67,
                SM_CXDRAG = 68,
                SM_CYDRAG = 69,
                SM_SHOWSOUNDS = 70,
                SM_CXMENUCHECK = 71,
                SM_CYMENUCHECK = 72,
                SM_SLOWMACHINE = 73,
                SM_MIDEASTENABLED = 74,
                SM_MOUSEPRESENT = 19,
                SM_XVIRTUALSCREEN = 76,
                SM_YVIRTUALSCREEN = 77,
                SM_CXVIRTUALSCREEN = 78,
                SM_CYVIRTUALSCREEN = 79,
                SM_CMONITORS = 80,
                SM_SAMEDISPLAYFORMAT = 81,
                SM_IMMENABLED = 82,
                SM_CXFOCUSBORDER = 83,
                SM_CYFOCUSBORDER = 84,
                SM_TABLETPC = 86,
                SM_MEDIACENTER = 87,
                SM_CMETRICS_OTHER = 76,
                SM_CMETRICS_2000 = 83,
                SM_CMETRICS_NT = 88,
                SM_REMOTESESSION = 0x1000,
                SM_SHUTTINGDOWN = 0x2000,
                SM_REMOTECONTROL = 0x2001,
            }

            [DllImport("user32.dll")]
            static extern IntPtr GetWindowDC(IntPtr hWnd);

            [DllImport("user32.dll")]
            static extern IntPtr GetDesktopWindow();

            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool SetProcessDPIAware();
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool DrawIcon(IntPtr hdc, int xLeft, int yTop, IntPtr hIcon);

            [StructLayout(LayoutKind.Sequential)]
            public struct CURSORINFO
            {
                public Int32 cbSize;        // Specifies the size, in bytes, of the structure.
                                            // The caller must set this to Marshal.SizeOf(typeof(CURSORINFO)).
                public Int32 flags;         // Specifies the cursor state. This parameter can be one of the following values:
                                            //    0             The cursor is hidden.
                                            //    CURSOR_SHOWING    The cursor is showing.
                                            //    CURSOR_SUPPRESSED    (Windows 8 and above.) The cursor is suppressed. This flag indicates that the system is not drawing the cursor because the user is providing input through touch or pen instead of the mouse.
                public IntPtr hCursor;          // Handle to the cursor.
                public POINT ptScreenPos;       // A POINT structure that receives the screen coordinates of the cursor.
            }

            [DllImport("user32.dll")]
            static extern IntPtr LoadIcon(IntPtr hInstance, SystemIcons lpIconName);
            public enum SystemIcons
            {
                IDI_APPLICATION = 32512,
                IDI_HAND = 32513,
                IDI_QUESTION = 32514,
                IDI_EXCLAMATION = 32515,
                IDI_ASTERISK = 32516,
                IDI_WINLOGO = 32517,
                IDI_WARNING = IDI_EXCLAMATION,
                IDI_ERROR = IDI_HAND,
                IDI_INFORMATION = IDI_ASTERISK,
            }
        }
    }
}