namespace M4_Final_Project
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.btn_ShowHomeScreen = new System.Windows.Forms.Button();
            this.btn_ExitApp = new System.Windows.Forms.Button();
            this.lbl_Navigation = new System.Windows.Forms.Label();
            this.btn_NewRound = new System.Windows.Forms.Button();
            this.btn_PastRounds = new System.Windows.Forms.Button();
            this.pnl_MainScreen = new System.Windows.Forms.Panel();
            this.newpreviousRounds1 = new M4_Final_Project.PreviousRounds();
            this.newRound1 = new M4_Final_Project.NewRound();
            this.lbl_NecessaryItems = new System.Windows.Forms.Label();
            this.lbl_WelcomeMessageCont = new System.Windows.Forms.Label();
            this.lbl_WelcomeMessage = new System.Windows.Forms.Label();
            this.pnl_Navigation.SuspendLayout();
            this.pnl_MainScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Navigation
            // 
            this.pnl_Navigation.BackColor = System.Drawing.Color.Snow;
            this.pnl_Navigation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Navigation.BackgroundImage")));
            this.pnl_Navigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Navigation.Controls.Add(this.btn_ShowHomeScreen);
            this.pnl_Navigation.Controls.Add(this.btn_ExitApp);
            this.pnl_Navigation.Controls.Add(this.lbl_Navigation);
            this.pnl_Navigation.Controls.Add(this.btn_NewRound);
            this.pnl_Navigation.Controls.Add(this.btn_PastRounds);
            this.pnl_Navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Navigation.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation.Name = "pnl_Navigation";
            this.pnl_Navigation.Size = new System.Drawing.Size(291, 894);
            this.pnl_Navigation.TabIndex = 0;
            // 
            // btn_ShowHomeScreen
            // 
            this.btn_ShowHomeScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ShowHomeScreen.Location = new System.Drawing.Point(45, 364);
            this.btn_ShowHomeScreen.Name = "btn_ShowHomeScreen";
            this.btn_ShowHomeScreen.Size = new System.Drawing.Size(121, 86);
            this.btn_ShowHomeScreen.TabIndex = 4;
            this.btn_ShowHomeScreen.Text = "Home Screen";
            this.btn_ShowHomeScreen.UseVisualStyleBackColor = false;
            this.btn_ShowHomeScreen.Click += new System.EventHandler(this.Btn_ShowHomeScreen_Click);
            // 
            // btn_ExitApp
            // 
            this.btn_ExitApp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ExitApp.Location = new System.Drawing.Point(45, 483);
            this.btn_ExitApp.Name = "btn_ExitApp";
            this.btn_ExitApp.Size = new System.Drawing.Size(121, 86);
            this.btn_ExitApp.TabIndex = 3;
            this.btn_ExitApp.Text = "Exit App";
            this.btn_ExitApp.UseVisualStyleBackColor = false;
            this.btn_ExitApp.Click += new System.EventHandler(this.Btn_ExitApp_Click);
            // 
            // lbl_Navigation
            // 
            this.lbl_Navigation.AutoSize = true;
            this.lbl_Navigation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Navigation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Navigation.Location = new System.Drawing.Point(12, 62);
            this.lbl_Navigation.Name = "lbl_Navigation";
            this.lbl_Navigation.Size = new System.Drawing.Size(179, 37);
            this.lbl_Navigation.TabIndex = 2;
            this.lbl_Navigation.Text = "Navigation";
            // 
            // btn_NewRound
            // 
            this.btn_NewRound.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NewRound.Location = new System.Drawing.Point(45, 125);
            this.btn_NewRound.Name = "btn_NewRound";
            this.btn_NewRound.Size = new System.Drawing.Size(121, 86);
            this.btn_NewRound.TabIndex = 0;
            this.btn_NewRound.Text = "Enter New Round";
            this.btn_NewRound.UseVisualStyleBackColor = false;
            this.btn_NewRound.Click += new System.EventHandler(this.Btn_NewRound_Click);
            // 
            // btn_PastRounds
            // 
            this.btn_PastRounds.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_PastRounds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PastRounds.Location = new System.Drawing.Point(45, 240);
            this.btn_PastRounds.Name = "btn_PastRounds";
            this.btn_PastRounds.Size = new System.Drawing.Size(121, 86);
            this.btn_PastRounds.TabIndex = 1;
            this.btn_PastRounds.Text = "View Previous Rounds";
            this.btn_PastRounds.UseVisualStyleBackColor = false;
            this.btn_PastRounds.Click += new System.EventHandler(this.Btn_PastRounds_Click);
            // 
            // pnl_MainScreen
            // 
            this.pnl_MainScreen.BackColor = System.Drawing.Color.White;
            this.pnl_MainScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_MainScreen.BackgroundImage")));
            this.pnl_MainScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_MainScreen.Controls.Add(this.newpreviousRounds1);
            this.pnl_MainScreen.Controls.Add(this.newRound1);
            this.pnl_MainScreen.Controls.Add(this.lbl_NecessaryItems);
            this.pnl_MainScreen.Controls.Add(this.lbl_WelcomeMessageCont);
            this.pnl_MainScreen.Controls.Add(this.lbl_WelcomeMessage);
            this.pnl_MainScreen.Location = new System.Drawing.Point(189, 0);
            this.pnl_MainScreen.Name = "pnl_MainScreen";
            this.pnl_MainScreen.Size = new System.Drawing.Size(1074, 897);
            this.pnl_MainScreen.TabIndex = 1;
            // 
            // newpreviousRounds1
            // 
            this.newpreviousRounds1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newpreviousRounds1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newpreviousRounds1.BackgroundImage")));
            this.newpreviousRounds1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newpreviousRounds1.Location = new System.Drawing.Point(-17, 3);
            this.newpreviousRounds1.Name = "newpreviousRounds1";
            this.newpreviousRounds1.Size = new System.Drawing.Size(1074, 894);
            this.newpreviousRounds1.TabIndex = 1;
            // 
            // newRound1
            // 
            this.newRound1.BackColor = System.Drawing.Color.White;
            this.newRound1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newRound1.BackgroundImage")));
            this.newRound1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newRound1.Location = new System.Drawing.Point(0, 0);
            this.newRound1.Name = "newRound1";
            this.newRound1.Size = new System.Drawing.Size(1074, 897);
            this.newRound1.TabIndex = 0;
            // 
            // lbl_NecessaryItems
            // 
            this.lbl_NecessaryItems.AutoSize = true;
            this.lbl_NecessaryItems.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NecessaryItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NecessaryItems.Location = new System.Drawing.Point(170, 225);
            this.lbl_NecessaryItems.Name = "lbl_NecessaryItems";
            this.lbl_NecessaryItems.Size = new System.Drawing.Size(677, 150);
            this.lbl_NecessaryItems.TabIndex = 7;
            this.lbl_NecessaryItems.Text = resources.GetString("lbl_NecessaryItems.Text");
            // 
            // lbl_WelcomeMessageCont
            // 
            this.lbl_WelcomeMessageCont.AutoSize = true;
            this.lbl_WelcomeMessageCont.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WelcomeMessageCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeMessageCont.Location = new System.Drawing.Point(170, 153);
            this.lbl_WelcomeMessageCont.Name = "lbl_WelcomeMessageCont";
            this.lbl_WelcomeMessageCont.Size = new System.Drawing.Size(622, 26);
            this.lbl_WelcomeMessageCont.TabIndex = 6;
            this.lbl_WelcomeMessageCont.Text = "The easiest way to determine your handicap and make golf fair!";
            // 
            // lbl_WelcomeMessage
            // 
            this.lbl_WelcomeMessage.AutoSize = true;
            this.lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeMessage.Location = new System.Drawing.Point(266, 62);
            this.lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
            this.lbl_WelcomeMessage.Size = new System.Drawing.Size(424, 37);
            this.lbl_WelcomeMessage.TabIndex = 5;
            this.lbl_WelcomeMessage.Text = "Welcome To The Handicapp";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 894);
            this.Controls.Add(this.pnl_MainScreen);
            this.Controls.Add(this.pnl_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "The Handicapp";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnl_Navigation.ResumeLayout(false);
            this.pnl_Navigation.PerformLayout();
            this.pnl_MainScreen.ResumeLayout(false);
            this.pnl_MainScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.Button btn_NewRound;
        private System.Windows.Forms.Button btn_PastRounds;
        private System.Windows.Forms.Panel pnl_MainScreen;
        private System.Windows.Forms.Button btn_ExitApp;
        private System.Windows.Forms.Label lbl_Navigation;
        private System.Windows.Forms.Button btn_ShowHomeScreen;
        private NewRound newRound1;
        private PreviousRounds newpreviousRounds1;
        private System.Windows.Forms.Label lbl_NecessaryItems;
        private System.Windows.Forms.Label lbl_WelcomeMessageCont;
        private System.Windows.Forms.Label lbl_WelcomeMessage;
    }
}