using System;
using System.Windows.Forms;

namespace M4_Final_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            newpreviousRounds1.Hide();
            newRound1.Hide();
        }

        private void Btn_NewRound_Click(object sender, EventArgs e)
        {
            newRound1.BringToFront();
            newRound1.Show();
            newpreviousRounds1.Hide();
        }

        private void Btn_PastRounds_Click(object sender, EventArgs e)
        {
            newpreviousRounds1.BringToFront();
            newpreviousRounds1.Show();
            newRound1.Hide();
        }

        private void Btn_ExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ShowHomeScreen_Click(object sender, EventArgs e)
        {
            newpreviousRounds1.Hide();
            newRound1.Hide();
        }
    }
}
