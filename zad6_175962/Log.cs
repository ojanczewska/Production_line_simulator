using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6_175962
{
    public partial class Log : Form
    {

        public static Log login = new Log();
        public Log()
        {
            InitializeComponent();
            login = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogindbEntities context = new LogindbEntities();
            if (login_textBox.Text != string.Empty || password_textBox.Text != string.Empty)
            {
                var user = context.AdminLogins.Where(a => a.UserName.Equals(login_textBox.Text)).FirstOrDefault();
                if(user != null)
                {
                    if (user.Password.Equals(password_textBox.Text))
                    {
                        this.Hide();
                        Form1 form = new Form1();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Podany login i/lub hasło są nieprawidłowe.");
                    }
                }
                else
                {
                    MessageBox.Show("Podany login i/lub hasło są nieprawidłowe.");
                }
            }
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }
    }
}
