using @lock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lockBk
{
    public partial class lockBkN : Form
    {

        // this.CreateGraphics();
        System.Drawing.SolidBrush drawBrush;
        struct bkDis
        {
            public int fon_t;
            public float x;
            public float yy;
        };
        bkDis[] deta = new bkDis[1386];
        int dcLimit = 0;
        int newWidth=0;
        int newHeight=0;
        int colorf = 0;
        String w = "诶比西迪伊艾弗吉艾尺艾杰开艾勒艾马艾娜哦屁吉吾艾儿艾丝提伊吾维豆贝尔维艾克斯吾艾贼德";

        public lockBkN()
        {

            InitializeComponent();
            this.ShowInTaskbar = false;
            Screen scr = Screen.PrimaryScreen;
            newWidth = scr.Bounds.Width;
            newHeight = scr.Bounds.Height;
            this.ClientSize = new System.Drawing.Size(newWidth + 9, newHeight + 9);


            Thread di = new Thread(new ThreadStart(givetome));
            try
            { di.Start(); }
            catch { }

        }

        private void givetome()
        {
            try
            {
                Thread.Sleep(9000);
            }
            catch { }
            this.bw.RunWorkerAsync();
        }


     

        private void lockBk_Load(object sender, EventArgs e)
        {

        }

        private void lockBkN_Paint(object sender, PaintEventArgs e)
        {
            
          
        }

     private void addForEach()
        {

            int jj = -10;
           Random ra = new Random();
            // 
            int dl = 0;
            while (true)
            {
                    int f = 6 + ra.Next(10);
            
                    writeMe("" + w[ra.Next(40)], f, jj, 0,true,dl);
                dcLimit = dl;

                dl++;
                  

            //        Console.WriteLine("\n" + jj);

               /*     try
                    {
                        Thread.Sleep(3);
                    }
                    catch { }
                    */
                
                jj += 9 + ra.Next(10);
                if (jj > newWidth)
                {
                    break;

                }
            }

           
          
            continueMe();
        }


        private void continueMe()
        {
            Random ako = new Random();
            while(true)
            {
                for(int i=0,j= dcLimit; (i<dcLimit)&&(j>0); i+=6, j-= 6)
                {

                    fuckUbi(i+ako.Next(6));
                    try { Thread.Sleep(9); } catch { }
                    fuckUbi(j+ ako.Next(6));
                }
                try{ Thread.Sleep(153); }catch { }


                if (dcLimit < 1)
                    break;
            }
            drawBrush.Dispose();
            if(colorf==1)
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            if (colorf == 0)
                drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen);
            if (colorf == 2)
                drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            if (colorf == 3)
            {
                try { 
                LockWorkStation();
                Form1 exit_dude = new Form1();
                exit_dude.ExitClickOk();
                }
                catch { }
            }
               
            colorf++;
            addForEach();

        }

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        private void fuckUbi(int fucker)
        {
            Random raa = new Random();
            Random raaa = new Random();
            writeMe(""+ w[(raa.Next(20)+ raaa.Next(20)) +1], deta[fucker].fon_t, deta[fucker].x,deta[fucker].yy + deta[fucker].fon_t, true, fucker);
            if (deta[fucker].yy> newHeight)
                deleteMe(fucker);
        }

        private void deleteMe(int good)
        {

            for (int d=good ;d< dcLimit;d++)
            {
                deta[d] = deta[d + 1];
            }
            dcLimit--;

        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {


          //  drawBrush.Dispose();
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            addForEach();

        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void writeMe(string drawString, int fon_t, float x, float y,Boolean det_a,int dl)
        {
            if(det_a)
            {
                deta[dl].fon_t = fon_t;
                deta[dl].x = (float)x;
                deta[dl].yy = (float)y;
            }
            try
            {
              // Console.WriteLine("dd :" + drawString+": dd"+ fon_t+"gg"+x+"fff"+y+"jjjj  "+dl);
                System.Drawing.Graphics formGraphics = formGraphics = this.CreateGraphics();

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", fon_t);
               
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                drawFont.Dispose();
              

                formGraphics.Dispose();
            }
            catch (Exception g) { }
        }

    }
}
