using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exampelProject
{
    public partial class Login : Form
    {
        #region init
        string uname = "dominik";
        string password = "passwort";

        public Login()
        {
            InitializeComponent();
            tBPassword.PasswordChar = '*';
            tBPassword.MaxLength = 10;
        }
        #endregion

        #region functions
        public bool compare()
        {
            if (tBUsername.Text == uname && tBPassword.Text == password)
            {
                return true;
            }
            else { return false; }
        }

        public void showPassword()
        {
            if (cBShowPW.Checked == true)
            {
                lblPWVisable.Text = tBPassword.Text;
            }
            else
            {
                lblPWVisable.Text = "";
            }
        }

        public void enableButton()
        {
            if(tBPassword.Text != "" && tBUsername.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
        #endregion

        #region events
        private void button1_Click(object sender, EventArgs e)
        {
            if (compare())
            {
                MessageBox.Show("login successfully!");
            }
            else
            {
                MessageBox.Show("login failed!");
            }
        }

        private void usernameChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void passwordChanged(object sender, EventArgs e)
        {
            enableButton();
            showPassword();
        }

        private void checkChanged(object sender, EventArgs e)
        {
            showPassword();
        }
        #endregion
    }
}
