using Operation_Storm.LoadingProgress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace Operation_Storm.FormKD
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        public void Messenger (string Mess,string ALOWER)
        {
            //MessageBox.Show(Mess,ALOWER);
        }
        private void Loading(object sender, EventArgs e)
        {

            //MessageBoxResult result = MessageBox.Show("Are you Ready Auto", MessageBoxButtons.YesNo, MessageBoxOptions.ServiceNotification);
            int INTTimerInter = Convert.ToInt32(TimerInterval.Text);
            //Minute convert
            int Timerxabc = INTTimerInter * 60000;
            timer1.Interval = Timerxabc;
            timer1.Start();
            MinutesTime = INTTimerInter;
            timer2.Start();
            Thread.Sleep(1000);
            button1.Visible = false;
            ButtonStop.Visible = true;
            ONOFFHehe = true;
        }
        int MinutesTime = 10;
        int SecondTime = 0;
        bool ONOFFHehe;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string LinkFileOpen = "Ink\\IS.txt";
            int CounterSum = CouterLine(LinkFileOpen);
            int ACK = CounterSum - 1;
            progressBar1.Maximum = ACK;
            backgroundWorker1.RunWorkerAsync();
        }

        private void TimerInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(MinutesTime > 0)
            {
                if (SecondTime > 0)
                {
                    SecondTime--;
                }
                else
                {
                    if (MinutesTime >0)
                    {
                        MinutesTime--;
                        SecondTime = 59;
                    }
                    else
                    {
                        timer2.Stop();
                        return;
                    }
                }
                timerdown.Text = "( "+MinutesTime+" : "+SecondTime+")";
            }
        }
        private void ManualClick(object sender, EventArgs e)
        {
            if(ONOFFHehe == true)
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Is_Loading");
                    return;
                }
                else
                {
                    string LinkFileOpen = "Ink\\IS.txt";
                    int CounterSum = CouterLine(LinkFileOpen);
                    int ACK = CounterSum - 1;
                    progressBar1.Maximum = ACK;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Auto_Mode -> DontTouch");
            }
            
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            CopyFile axcs = new CopyFile();
            axcs.CopyfileXA();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        public void ReportProgress(int K)
        {
            backgroundWorker1.ReportProgress(K);
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateLog();
        }
        private static int CouterLine(string FilePatch)
        {
            int counter = 0;
            using (StreamReader stream = new StreamReader(FilePatch))
            {
                while (stream.ReadLine() != null)
                {
                    counter++;
                }
            }
            return counter;
        }
        
        public void UpdateLog()
        {
            
        }
        private void Clear_Log()
        {
            //AddLogupdate.RemoveRange(0,1);
            
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Thread.Sleep(1000);
            ButtonStop.Visible = false;
            button1.Visible = true;
            labelresult.Text = "No Active ";
            ONOFFHehe = false;
        }
    }
}
