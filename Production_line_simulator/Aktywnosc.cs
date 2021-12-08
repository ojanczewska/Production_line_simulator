using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Production_line_simulator
{
    public partial class Aktywnosc : Form
    {

        private int time_counter = 0;
        private SoundPlayer alarm;
        public Aktywnosc()
        {
            InitializeComponent();
            InitializeLabel();
            InitializeSound();
        }

        private void InitializeLabel()
        {
            label1.Text = "Sprawdzenie aktywności - wciśnij OK";
        }

        private void InitializeSound()
        {
            alarm = new SoundPlayer("alarmSound.wav");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            alarm.PlayLooping();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarm.Stop();
            timer1.Stop();
            timer2.Stop();
            Form1.form1.timer2.Start();

            this.Close();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            alarm.Stop();
            timer1.Stop();
            timer2.Stop();
            this.Dispose();
            this.Close();
            Form1.form1.Dispose();
            Form1.form1.Close();
            Log.login.Show();
            Log.login.login_textBox.Text = "";
            Log.login.password_textBox.Text = "";

        }

        private void Aktywnosc_Load(object sender, EventArgs e)
        {

        }
    }
}
