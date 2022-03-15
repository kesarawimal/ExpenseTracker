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
    public partial class RegisterView : Form
    {
        public UserData userData { get; set; }

        public RegisterView()
        {
            InitializeComponent();
        }

        private void UserRegistration(object sender, EventArgs e)
        {
            if (this.userData == null)
            {
                this.userData = new UserData();
            }
            this.userData.username = this.txtUsername.Text;
            this.userData.email = this.txtEmail.Text;
            this.userData.password = this.txtPassword.Text;

            //input validation

            UserProfile userProfile = new UserProfile();
            Boolean results = userProfile.RegisterUser(this.userData);

            if (results == true)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Dispose();
            }
        }

        private void RegisterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }
    }
}
