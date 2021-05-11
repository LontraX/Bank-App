using BankAppSqlite.Data.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppSqlite.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            var email1 = Convert.ToString(LoginPageEmail.Text);
            var pass1 = Convert.ToString(LoginPagePassword);
            CustomerRepo customerRepo = new CustomerRepo();
            var true1 = customerRepo.FetchByEmail(email1);
            var true2 = customerRepo.FetchByPassword(pass1);
            if(true1 == true || true2 == true)
            {
                main.Show();
            }
            else
            {
                MessageBox.Show("Are you sure you have an account?");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginPageSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
