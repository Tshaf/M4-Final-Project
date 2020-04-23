using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace M4_Final_Project
{
    public partial class NewRound : UserControl
    {
        public NewRound()
        {
            InitializeComponent();
        }

        private void Btn_EnterScore_Click(object sender, EventArgs e)
        {
            if (mskdBox_CourseRating.Text == "" || mskdbox_Score.Text == "" || mskdBox_Slope.Text == "")
            {
                MessageBox.Show("You must enter a value for score, course rating, and slope before you can continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Your new round has been entered");
                double standardSlope = 113;
                double score = Convert.ToDouble(mskdbox_Score.Text);
                double courseRating = Convert.ToDouble(mskdBox_CourseRating.Text);
                double courseSlope = Convert.ToDouble(mskdBox_Slope.Text);
                double courseRatingScore = score - courseRating;
                double slopeScore = standardSlope / courseSlope;
                double handicap = courseRatingScore * slopeScore;
                lbl_ShowHandicap.Text = handicap.ToString("N0");

                string dataPath = @"Handicap.txt";
                string handicapString = handicap.ToString("N0");
                File.AppendAllText(dataPath, handicapString + "\n");
            }
          
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            mskdbox_Score.Text = "";
            mskdBox_CourseRating.Text = "";
            mskdBox_Slope.Text = "";
            lbl_ShowHandicap.Text = "";
        }
    }
}
