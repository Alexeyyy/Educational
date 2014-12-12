using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HelpForSergey
{
    public partial class Form1 : Form
    {
        public Timer timer = new Timer();
        public bool isStopped = true;
        public int passedSeconds = 0;
        public int interval = 5;
        public string initialLblText = String.Empty;
        public string eventLblbText = String.Empty;

        public Form1()
        {
            InitializeComponent();
            initialLblText = "Текст до " + interval + " секунд";
            eventLblbText = "Текст после " + interval + " секунд";
            timer.Tick += timer_Tick;
            timer.Interval = 1000;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (passedSeconds >= interval)
                lbl_Text.Text = eventLblbText;
            lbl_LabelTimer.Text = passedSeconds.ToString();
            passedSeconds += (timer.Interval / 1000);
        }

        private void btn_LaunchTimer_Click(object sender, EventArgs e)
        {
            if (isStopped)
            {
                timer.Start();
                passedSeconds = 0;
                lbl_Text.Text = initialLblText;
                btn_LaunchTimer.Text = "Стоп и сброс";
                isStopped = false;
            }
            else 
            {
                timer.Stop();
                isStopped = true;
                lbl_LabelTimer.Text = "Таймер";
                btn_LaunchTimer.Text = "Сброшен";
            }
        }
    }
}
