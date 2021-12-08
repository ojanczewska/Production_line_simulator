using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Production_line_simulator
{
    
    public partial class Form1 : Form
    {

        private static Image[] lista { get; set; } = new Image[15];
        private Double temperature = 0;
        private Double usage;
        private Dane fansParams = new Dane();
        private Random rand = new Random();
        public static Form1 form1 = new Form1();
        private int czas_awarii;
        private bool awariaFan = false;
        private bool awariaTemp = false;
        private bool awariaLine0 = false;
        private bool awariaLine1 = false;
        private string awaria = "";
        private int indeks = 0;
        

        public Form1()
        {
            InitializeComponent();
            InitializeImage();
            InitializeLabels();
            informacja();
            form1 = this;


        }
        private void InitializeImage()
        {
            lista[0] = Image.FromFile("frame_00.gif");
            lista[1] = Image.FromFile("frame_02.gif");
            lista[2] = Image.FromFile("frame_04.gif");
            lista[3] = Image.FromFile("frame_06.gif");
            lista[4] = Image.FromFile("frame_08.gif");
            lista[5] = Image.FromFile("frame_10.gif");
            lista[6] = Image.FromFile("frame_12.gif");
            lista[7] = Image.FromFile("frame_14.gif");
            lista[8] = Image.FromFile("frame_16.gif");
            lista[9] = Image.FromFile("frame_18.gif");
            lista[10] = Image.FromFile("frame_20.gif");
            lista[11] = Image.FromFile("frame_22.gif");
            lista[12] = Image.FromFile("frame_24.gif");
            lista[13] = Image.FromFile("frame_26.gif");
            lista[14] = Image.FromFile("frame_28.gif");
        }

        private void InitializeLabels()
        {
            fan1_button.Text = "WŁĄCZ";
            fan2_button.Text = "WŁĄCZ";
            fan3_button.Text = "WŁĄCZ";
            hScrollBar1.Maximum = 109;
            hScrollBar1.Minimum = 0;
            hScrollBar1.Value = 45;
            fansParams.line_speed = hScrollBar1.Value;
            predkosc_label.Text = Convert.ToString(fansParams.line_speed);
            pictureBox1.Image = lista[0];
            CPU_temp();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CPU_temp()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");

            foreach (ManagementObject obj in searcher.Get())
            {
                temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                temperature = (temperature - 2732) / 10.0; // Convert the value to celsius degrees
            }
        }
        private void CPU_use()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");

            foreach (ManagementObject obj in searcher.Get())
            {
                usage = Convert.ToDouble(obj["PercentProcessorTime"].ToString());
            }
        }

        private void fanWorkd()  
        {
            if (fansParams.fan1_on)
            {
                temperature = temperature - 1;
            }
            if (fansParams.fan2_on)
            {
                temperature = temperature - 3;
            }
            if (fansParams.fan3_on)
            {
                temperature = temperature - 5;
            }
        }

        private void LineWork() 
        {
            if (fansParams.line_speed == 0) temperature -= 1;
            if (fansParams.line_speed > 0 && fansParams.line_speed <= 20) temperature += 1;
            if (fansParams.line_speed > 20 && fansParams.line_speed <= 40) temperature += 2;
            if (fansParams.line_speed > 40 && fansParams.line_speed <= 60) temperature += 3;
            if (fansParams.line_speed > 60 && fansParams.line_speed <= 80) temperature += 4;
            if (fansParams.line_speed > 80 && fansParams.line_speed <= 100) temperature += 5;

        }


        private void powiadomienia() 
        {
            if (temperature < 5) awaria += "Temperatura jest za niska. Zwiększ prędkość lini produkcyjnej, bądź wyłącz wentylator!!!\r\n";
            if (temperature >= 90)
            {
                if (awariaTemp) awaria += "!!! NASTAPIL NAGLY WZROST TEMPERATURY !!!\r\n ";
                awaria += "Temperatura jest za wysoka. Zmniejsz prędkosć lini produkcyjnej, bądź włącz wentylator!!\r\n ";
            }
            if (awariaLine0) awaria += "!!! AWARIA LINI PRODUKCYJNEJ !!!\r\nNastapiło nagłe zatrzymanie, szybko zwiększ prędkosć lini!\r\n";
            if (awariaLine1) awaria += "!!! AWARIA LINI PRODUKCYJNEJ !!!\r\nNastapiło nagłe przyspiesznie, szybko zmniejsz prędkosć lini!\r\n";

            awaria_label.Text = awaria;
        }

        private void informacja()
        {
            string info = "";

            info += "Temperatura procesora: " + temperature + "°C\r\n";
            info += "\r\nStopień wykorzystania procesora: " + usage + "%\r\n\n";
            if(fansParams.fan1_on) info += "\r\nPrędkośc wentylatora 1 : 3000 rpm\r\n\n";
            else info += "\r\nPrędkośc wentylatora 1 : 0 rpm\r\n";
            if (fansParams.fan2_on) info += "\r\nPrędkośc wentylatora 2 : 3500 rpm\r\n\n";
            else info += "\r\nPrędkośc wentylatora 2 : 0 rpm\r\n";
            if (fansParams.fan3_on) info += "\r\nPrędkośc wentylatora 3 : 4000 rpm\r\n\n";
            else info += "\r\nPrędkośc wentylatora 3 : 0 rpm\r\n";
            info_textBox.Text = info;

        }

        private void emergencyChech()
        {
            if (temperature < 90)  awariaFan = false;

            if (fansParams.line_speed > 0) awariaLine0 = false;

            if (fansParams.line_speed < 90) awariaLine1 = false;
            
        }
        private void timer1_Tick(object sender, EventArgs e)  // timer ogolny 
        {

            emergencyChech();
            //zmnijezenie temp w zaleznosci od wentylatorow
            fanWorkd();
            //zwiekszenie temp w zaleznosci od predkosci lini
            LineWork();
            // stopnie wykorzyatsnia procesora
            CPU_use();
            //wypisaie  awarii
            awaria = "";
            czasAwarii();
            powiadomienia();
            //wypisanie danych
            informacja();

        }

        private void fan1_button_Click(object sender, EventArgs e)
        {

            if (fansParams.fan1_on)
            {
                fan1_button.Text = "WŁĄCZ";
                fansParams.fan1_on = false;
                fan1_pictureBox.Visible = false;
            }
            else
            {
                fan1_button.Text = "WYŁĄCZ";
                fansParams.fan1_on = true;
                fan1_pictureBox.Visible = true;

            }
        }

        private void fan2_button_Click(object sender, EventArgs e)
        {
            if (fansParams.fan2_on)
            {
                fan2_button.Text = "WŁĄCZ";
                fansParams.fan2_on = false;
                fan2_pictureBox.Visible = false;
            }
            else
            {
                fan2_button.Text = "WYŁĄCZ";
                fansParams.fan2_on = true;
                fansParams.activeFans += 1;
                fan2_pictureBox.Visible = true;
            }
        }

        private void fan3_button_Click(object sender, EventArgs e)
        {
            if (fansParams.fan3_on)
            {
                fan3_button.Text = "WŁĄCZ";
                fansParams.fan3_on = false;
                fan3_pictureBox.Visible = false;

            }
            else
            {
                fan3_button.Text = "WYŁĄCZ";
                fansParams.fan3_on = true;
                fan3_pictureBox.Visible = true;
            }

        }

        private void czasAwarii() 
        {
            czas_awarii += 1;

            if (fan1_button.Enabled == false) awaria += "!!! AWARIA WENTYLATORA 1 !!!\r\n Wykorzystaj inne wentylatory, aby zapobiec przegrzaniu.";
            if (fan2_button.Enabled == false) awaria += "!!! AWARIA WENTYLATORA 2 !!!\r\n Wykorzystaj inne wentylatory, aby zapobiec przegrzaniu.";
            if (fan3_button.Enabled == false) awaria += "!!! AWARIA WENTYLATORA 3 !!!\r\n Wykorzystaj inne wentylatory, aby zapobiec przegrzaniu.";

            if (czas_awarii == 20)
            {
                awariaFan = false;

                if (fan1_button.Enabled == false) fan1_button.Enabled = true;
                if (fan2_button.Enabled == false) fan2_button.Enabled = true;
                if (fan3_button.Enabled == false) fan3_button.Enabled = true;

            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            fansParams.line_speed = hScrollBar1.Value;
            predkosc_label.Text = Convert.ToString(fansParams.line_speed);

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (fansParams.line_speed == 0)
            {
                pictureBox1.Image = lista[indeks];
            }
            else
            {
                timer4.Interval = 1000/fansParams.line_speed ;
                indeks++;
                pictureBox1.Image = lista[indeks];
                if (indeks == 14) indeks = 0;
            }
           

        }

        private void timer2_Tick(object sender, EventArgs e) 
        {
            timer2.Stop();
            Aktywnosc activity = new Aktywnosc();
            activity.ShowDialog();
        }

       

        private void timer3_Tick(object sender, EventArgs e)
        {
            int awaria = rand.Next(6);

            switch (awaria)
            {
                case 0:
                    temperature = 100; 
                    awariaTemp = true;
                    break;
                case 1:
                    fansParams.line_speed = hScrollBar1.Value = 0;
                    predkosc_label.Text = Convert.ToString(fansParams.line_speed);
                    awariaLine0 = true;
                    break;
                case 2:
                    fansParams.line_speed = hScrollBar1.Value = 90;
                    predkosc_label.Text = Convert.ToString(fansParams.line_speed);
                    awariaLine1 = true;
                    break;
                case 3:
                    if (fansParams.fan1_on)
                    {
                        fan1_button.PerformClick();
                        fan1_button.Enabled = false;
                        czas_awarii = 0;
                        awariaFan = true;
                    }
                    break;
                case 4:
                    if (fansParams.fan2_on)
                    {
                        fan2_button.PerformClick();
                        fan2_button.Enabled = false;
                        czas_awarii = 0;
                        awariaFan = true;
                    }
                    break;
                case 5:
                    if (fansParams.fan3_on)
                    {
                        fan3_button.PerformClick();
                        fan3_button.Enabled = false;
                        czas_awarii = 0;
                        awariaFan = true;
                    }
                    break;
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

       
    }
}
