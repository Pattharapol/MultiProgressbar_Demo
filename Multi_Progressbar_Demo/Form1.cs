using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Progressbar_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoWork1()
        {
            int work = 20000;
            for (int i = 1; i < work; i++)
            {
                int percent = (i*100) / work;
                backgroundWorker1.ReportProgress(percent);
            }
        }

        private void DoWork2()
        {int work = 50000;
            for (int i = 1; i < work; i++)
            {
                int percent = (i * 100) / work;
                backgroundWorker2.ReportProgress(percent);
            }
        }

        private void DoWork3()
        {
            int work = 90000;
            for (int i = 1; i < work; i++)
            {
                int percent = (i * 100) / work;
                backgroundWorker3.ReportProgress(percent);
            }
        }

        private void DoWork4()
        {
            int work = 150000;
            for (int i = 1; i < work; i++)
            {
                int percent = (i * 100) / work;
                backgroundWorker4.ReportProgress(percent);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWork1();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = (e.ProgressPercentage+1).ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWork2();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            label2.Text = (e.ProgressPercentage+1).ToString() + "%";
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWork3();
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar3.Value = e.ProgressPercentage;
            label3.Text = (e.ProgressPercentage+1).ToString() + "%";
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWork4();
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar4.Value = e.ProgressPercentage;
            label4.Text = (e.ProgressPercentage+1).ToString() + "%";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate { backgroundWorker1.RunWorkerAsync(); }));
            this.BeginInvoke(new MethodInvoker(delegate { backgroundWorker2.RunWorkerAsync(); }));
            this.BeginInvoke(new MethodInvoker(delegate { backgroundWorker3.RunWorkerAsync(); }));
            this.BeginInvoke(new MethodInvoker(delegate { backgroundWorker4.RunWorkerAsync(); }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
    }
}
