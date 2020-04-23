using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M4_Final_Project
{
    public partial class btn_Create : Form
    {
        public btn_Create()
        {
            InitializeComponent();
        }

        private void Btn_CreateUser_Click(object sender, EventArgs e)
        {
            string dataPath = @"User.txt";
            string logInfo;
            logInfo = txtBox_NewUserName.Text.ToString() + "," + txtBox_NewUserPass.Text.ToString();
            MessageBox.Show("Username: " + txtBox_NewUserName.Text + "\n" + "Password: " + txtBox_NewUserPass.Text);
            File.AppendAllText(dataPath, logInfo + "\n");
            Form3 x = new Form3();
            this.Hide();
            x.Show();
            

        }
    }
}
