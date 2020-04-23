using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// **************************************************
//
// Title: The Handicapp
// Description: Application that takes input from the
// user and determines their golf handicap             
// Application Type: Winform
// Author: Shaffran, Tyler
// Dated Created: 4/8/2020
// Last Modified: 4/23/2020
//
// **************************************************


namespace M4_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string dataPath = @"User.txt";
            string[] loginInfoAr;
            (string userName, string password) loginTuple;
            List<(string userName, string password)> registeredUser = new List<(string userName, string password)>();
            loginInfoAr = File.ReadAllLines(dataPath);
            foreach (string loginText in loginInfoAr)
            {
                loginInfoAr = loginText.Split(',');
                loginTuple.userName = loginInfoAr[0];
                loginTuple.password = loginInfoAr[1];
                registeredUser.Add(loginTuple);
            }
            bool validUser = true;
            foreach ((string userName, string password)loginInfo in registeredUser)
            {
                if ((loginInfo.userName == txtBox_Username.Text) && (loginInfo.password == txtBox_Password.Text))
                {
                    validUser = true;
                    break;
                }

                else if ((loginInfo.userName != txtBox_Username.Text) && (loginInfo.password != txtBox_Password.Text))
                {
                    validUser = false;
                }
                
            }
            if (validUser == true)
            {
                this.Hide();
                Form3 x = new Form3();
                x.Show();
            }
            if (validUser != true)
            {
                MessageBox.Show("Username or password incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Btn_NewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            btn_Create x = new btn_Create();
            x.Show();
        }
    }
}
