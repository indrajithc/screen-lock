using howto_simple_password;
using lockBk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @lock
{
   
    public partial class Form1 : Form
    {
        Boolean loc = true;
        Boolean bshow = false;
        Boolean exac = true;
        public Form1()
        {
            InitializeComponent();

           
                runFirst(true);
            this.ShowInTaskbar = false;


            
            lockBkN obj = new lockBkN();
            obj.Show();
        }
       // public Form1(Boolean s)
     //   {
      //      Console.WriteLine("fffffffffffccccccccccccccccccfffffffffffffffffffffffff");
       //  bshow = true;
        //    sowEditing();
          //  this.Refresh();
      //  }
        
        private void runFirst(Boolean status)
        {
            if(status)
            {
                Screen scr = Screen.PrimaryScreen;
                int newWidth = scr.Bounds.Width;
                int newHeight = scr.Bounds.Height;
                this.ClientSize = new System.Drawing.Size(newWidth+9, newHeight+9);
                pch.Hide();


            }
        }


        public void ExitClickOk()
        {
            
            loc = false;
            if (System.Windows.Forms.Application.MessageLoop)
            {
            
                System.Windows.Forms.Application.Exit();
            }
            else
            {
              
                System.Environment.Exit(1);
            }
        }

        private void dont_do(object sender, FormClosingEventArgs e)
        {
            if (loc)
            {
                e.Cancel = true;
                base.OnClosing(e);
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lockBkN v = new lockBkN();
                Console.WriteLine("fffffffffffccccccccccccccccccfffffffffffffffffffffffff");

            //    v.sopuka();
            }
            catch { }

            ExitClickOk();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);


            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }


            try
            {
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.esc, " escape me");

            }
            catch { }
        }




        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
      
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

       

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        
            
        }

       public void sowEditing()
        {
            if (bshow)
            {
                pch.Show();
                bshow = false;
            }
            else
            {
                pch.Hide();
                bshow = true;
            }
        }
        private void settings_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button4_Click_1(object sender, EventArgs e)
        {
            PasswordForm frm = new PasswordForm();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                // The user canceled.
                this.Close();
            }
            frm.Close();
        }


     


void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
{
    if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
    {
        e.IsInputKey = false;
    }
}
private void Form1_DragLeave(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            readPass.passGet obh = new readPass.passGet();


            if (obh.ShowDialog() != DialogResult.OK)
            {

          //      The user canceled.
         
                    this.Close();
            }

            obh.Close();
           // obh.Show();
        }

        private void esc_Click(object sender, EventArgs e)
        {
           
        }
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        private void esc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                LockWorkStation();
                Application.ExitThread();
            }
            catch { }
        }
    }

    public static class TextBoxWatermarkExtensionMethod
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetWatermark(this TextBox textBox, string watermarkText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }

    }




}
