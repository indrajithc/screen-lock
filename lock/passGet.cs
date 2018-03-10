using howto_simple_password;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readPass
{
    public partial class passGet : Form
    {
        int x, y;
        public passGet()
        {
            InitializeComponent();
         //   this.backgroundWorker1.RunWorkerAsync();

            this.ShowInTaskbar = false;
       

        }
    
        private void setHereIN()
        {

            try
            {
                
                    this.Location = new System.Drawing.Point(x, y);

            }
            catch { }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          //  temps();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // sbyte//s
           
            try { ExitClickOk(); } catch (Exception s) { }


        }
        public void ExitClickOk()
        {

            if (passD.Text.Length < 1)
                return;
            if(passD.Text.Equals("admin"))
            {
              try {
                    sowEditing();
                } catch { }
            }


        //   Exit();

            if (passD.Text.Length == (@lock.Properties.Settings.Default.pass.Length))
            {
                if (passD.Text.Equals(@lock.Properties.Settings.Default.pass))
                    Exit();
                else
                    this.Dispose();
            }
            else
                this.Dispose();


               
        }

        private void sowEditing()
        {
            PasswordForm frm = new PasswordForm();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                // The user canceled.
                this.Close();
            }
            frm.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Exit();
        }
        public static void Exit()
        {
            Application.ExitThread();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {


            Exit();

        }

        private void passD_Enter(object sender, EventArgs e)
        {
          
        }

        private void passD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExitClickOk();
            }
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void passD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
