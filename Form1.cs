using System;
using System.Drawing;
using System.Windows.Forms;

namespace Oscillator
{
    public partial class Form1 : Form
    {
        public bool State = false;
        public float a = 0, b = 0;
        

        public Form1()
        {
            InitializeComponent();
            BackgroundThread.RunWorkerAsync();
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            State = !State;
            if (State) StartStop.Text = "Стоп";
            else StartStop.Text = "Пуск";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            g.DrawLine(pen, 160, 10, 160, 310);
            g.DrawLine(pen, 10, 160, 310, 160);
        }

        private void BackgroundThread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (State)
            {
                Graphics g = e.Graphics;
                SolidBrush brush = new SolidBrush(Color.Black);
                Pen pen = new Pen(brush);
                g.DrawEllipse(pen, (float)(160 + 150 * Math.Cos(a)), (float)(160 - 150 * Math.Sin(b)), 5, 5);
                a += 0.01F; b += 0.02F;
            }
        }
    }
}
