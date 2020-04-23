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
    public partial class PreviousRounds : UserControl
    {
        public PreviousRounds()
        {
            InitializeComponent();

        }

        private void Btn_ShowPreviousRounds_Click(object sender, EventArgs e)
        {
            string dataPath = @"Handicap.txt";
            string[] previousHandicaps = File.ReadAllLines(dataPath);
            int count = 1;
            Array.Reverse(previousHandicaps);
            Array.Sort(previousHandicaps);

            foreach (string handicap in previousHandicaps)
            {
                txtBox_HandicapPrevious.Text = txtBox_HandicapPrevious.Text + count++ + ":" + " " + handicap + Environment.NewLine;
                if (count > 20) break;
            }

        }

        private void Btn_AggHandicap_Click(object sender, EventArgs e)
        {
            string dataPath = @"Handicap.txt";
            string[] aggHandicap = File.ReadAllLines(dataPath);
            Array.Reverse(aggHandicap);
            Array.Sort(aggHandicap);
            Array.Resize(ref aggHandicap, 10);
            double score1 = Convert.ToDouble(aggHandicap[0]);
            double score2 = Convert.ToDouble(aggHandicap[1]);
            double score3 = Convert.ToDouble(aggHandicap[2]);
            double score4 = Convert.ToDouble(aggHandicap[3]);
            double score5 = Convert.ToDouble(aggHandicap[4]);
            double score6 = Convert.ToDouble(aggHandicap[5]);
            double score7 = Convert.ToDouble(aggHandicap[6]);
            double score8 = Convert.ToDouble(aggHandicap[7]);
            double score9 = Convert.ToDouble(aggHandicap[8]);
            double score10 = Convert.ToDouble(aggHandicap[9]);
            double addedScore = score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8 + score9 + score10;
            double totalHandicap = (addedScore / 10) * .96;
            lbl_AggregateHandicap.Text = totalHandicap.ToString("N0");
            
        }
    }
}

