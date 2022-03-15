using ExpenseTracker.DataObjects;
using ExpenseTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class LoginView : Form
    {
        public UserData userData { get; set; }
        public LoginView()
        {
            InitializeComponent();
        }

        private void AuthenticateUser(object sender, EventArgs e)
        {

            if (this.userData == null)
            {
                this.userData = new UserData();
            }
            this.userData.username = this.txtUsername.Text;
            this.userData.password = this.txtPassword.Text;

            UserProfile userProfile = new UserProfile();
            Boolean results = userProfile.LoginUser(userData);

            if (results == true)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Dispose();
            } else
            {
                MessageBox.Show("Please enter valid credentials to proceed.");
            }
        }

        private void ShowRegister(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.ShowDialog();
            this.Dispose();
        }

        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
