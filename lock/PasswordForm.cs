using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

// Set the TextBox's PasswordChar property
// to X or something at design time.

namespace howto_simple_password
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

            TextBoxWatermarkExtensionMethod.SetWatermark(txtPassword, "Old Password");
            TextBoxWatermarkExtensionMethod.SetWatermark(t1, "New Password");
            TextBoxWatermarkExtensionMethod.SetWatermark(t2, "Confirm new password");
        }

        // Validate the password.
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(@lock.Properties.Settings.Default.pass))
            {
             
                if(t1.Text.Equals(t2.Text))
                { 
                this.DialogResult = DialogResult.OK;
                    @lock.Properties.Settings.Default.pass = t2.Text;
                    @lock.Properties.Settings.Default.Save();


                }
            }
            else
            {
               
                txtPassword.Clear();
                MessageBox.Show("      oOOOPs..      ");
                txtPassword.Focus();
            }
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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
