namespace M4_Final_Project
{
    partial class PreviousRounds
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviousRounds));
            this.llb_PreviousRounds = new System.Windows.Forms.Label();
            this.txtBox_HandicapPrevious = new System.Windows.Forms.TextBox();
            this.btn_ShowPreviousRounds = new System.Windows.Forms.Button();
            this.btn_AggHandicap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_AggregateHandicap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llb_PreviousRounds
            // 
            this.llb_PreviousRounds.AutoSize = true;
            this.llb_PreviousRounds.BackColor = System.Drawing.Color.Transparent;
            this.llb_PreviousRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_PreviousRounds.Location = new System.Drawing.Point(351, 68);
            this.llb_PreviousRounds.Name = "llb_PreviousRounds";
            this.llb_PreviousRounds.Size = new System.Drawing.Size(406, 55);
            this.llb_PreviousRounds.TabIndex = 0;
            this.llb_PreviousRounds.Text = "Previous Rounds";
            // 
            // txtBox_HandicapPrevious
            // 
            this.txtBox_HandicapPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_HandicapPrevious.Location = new System.Drawing.Point(43, 241);
            this.txtBox_HandicapPrevious.Multiline = true;
            this.txtBox_HandicapPrevious.Name = "txtBox_HandicapPrevious";
            this.txtBox_HandicapPrevious.ReadOnly = true;
            this.txtBox_HandicapPrevious.Size = new System.Drawing.Size(285, 480);
            this.txtBox_HandicapPrevious.TabIndex = 3;
            // 
            // btn_ShowPreviousRounds
            // 
            this.btn_ShowPreviousRounds.Location = new System.Drawing.Point(100, 150);
            this.btn_ShowPreviousRounds.Name = "btn_ShowPreviousRounds";
            this.btn_ShowPreviousRounds.Size = new System.Drawing.Size(154, 68);
            this.btn_ShowPreviousRounds.TabIndex = 4;
            this.btn_ShowPreviousRounds.Text = "Show Previous Rounds";
            this.btn_ShowPreviousRounds.UseVisualStyleBackColor = true;
            this.btn_ShowPreviousRounds.Click += new System.EventHandler(this.Btn_ShowPreviousRounds_Click);
            // 
            // btn_AggHandicap
            // 
            this.btn_AggHandicap.Location = new System.Drawing.Point(398, 407);
            this.btn_AggHandicap.Name = "btn_AggHandicap";
            this.btn_AggHandicap.Size = new System.Drawing.Size(167, 77);
            this.btn_AggHandicap.TabIndex = 6;
            this.btn_AggHandicap.Text = "Calcute Aggregate Handicap";
            this.btn_AggHandicap.UseVisualStyleBackColor = true;
            this.btn_AggHandicap.Click += new System.EventHandler(this.Btn_AggHandicap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(589, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 2);
            this.panel1.TabIndex = 7;
            // 
            // lbl_AggregateHandicap
            // 
            this.lbl_AggregateHandicap.AutoSize = true;
            this.lbl_AggregateHandicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AggregateHandicap.Location = new System.Drawing.Point(587, 446);
            this.lbl_AggregateHandicap.Name = "lbl_AggregateHandicap";
            this.lbl_AggregateHandicap.Size = new System.Drawing.Size(0, 38);
            this.lbl_AggregateHandicap.TabIndex = 8;
            // 
            // PreviousRounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_AggregateHandicap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AggHandicap);
            this.Controls.Add(this.btn_ShowPreviousRounds);
            this.Controls.Add(this.txtBox_HandicapPrevious);
            this.Controls.Add(this.llb_PreviousRounds);
            this.Name = "PreviousRounds";
            this.Size = new System.Drawing.Size(1134, 860);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llb_PreviousRounds;
        private System.Windows.Forms.TextBox txtBox_HandicapPrevious;
        private System.Windows.Forms.Button btn_ShowPreviousRounds;
        private System.Windows.Forms.Button btn_AggHandicap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_AggregateHandicap;
    }
}
