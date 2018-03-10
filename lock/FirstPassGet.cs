
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

namespace lockd
{
    public partial class FirstPassGet : Form
{
    public FirstPassGet()
    {
        InitializeComponent();
            TextBoxWatermarkExtensionMethod.SetWatermark(she, "New Password");
            TextBoxWatermarkExtensionMethod.SetWatermark(he, "Confirm new password");
        }

    private void button2_Click(object sender, EventArgs e)
    {
        Application.ExitThread();
    }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
            if (she.Text.Equals(he.Text))
            {

                try { 
                this.DialogResult = DialogResult.OK;
                @lock.Properties.Settings.Default.pass = she.Text;
                @lock.Properties.Settings.Default.Save();

                }
                catch(Exception c) { MessageBox.Show(c+""); }
               RestartApp();

            }
            else
            {
                MessageBox.Show("oOOPz !");
            }
        }
        static void RestartApp()
        {
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
            Info.WindowStyle = ProcessWindowStyle.Hidden;
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
            Application.Exit();
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
