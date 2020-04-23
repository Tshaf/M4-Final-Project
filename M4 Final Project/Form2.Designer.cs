namespace M4_Final_Project
{
    partial class btn_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_Create));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_NewUserName = new System.Windows.Forms.TextBox();
            this.txtBox_NewUserPass = new System.Windows.Forms.TextBox();
            this.Btn_CreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtBox_NewUserName
            // 
            this.txtBox_NewUserName.Location = new System.Drawing.Point(146, 388);
            this.txtBox_NewUserName.Name = "txtBox_NewUserName";
            this.txtBox_NewUserName.Size = new System.Drawing.Size(232, 26);
            this.txtBox_NewUserName.TabIndex = 3;
            // 
            // txtBox_NewUserPass
            // 
            this.txtBox_NewUserPass.Location = new System.Drawing.Point(146, 449);
            this.txtBox_NewUserPass.Name = "txtBox_NewUserPass";
            this.txtBox_NewUserPass.Size = new System.Drawing.Size(232, 26);
            this.txtBox_NewUserPass.TabIndex = 4;
            this.txtBox_NewUserPass.UseSystemPasswordChar = true;
            // 
            // Btn_CreateUser
            // 
            this.Btn_CreateUser.Location = new System.Drawing.Point(155, 522);
            this.Btn_CreateUser.Name = "Btn_CreateUser";
            this.Btn_CreateUser.Size = new System.Drawing.Size(212, 64);
            this.Btn_CreateUser.TabIndex = 5;
            this.Btn_CreateUser.Text = "Create";
            this.Btn_CreateUser.UseVisualStyleBackColor = true;
            this.Btn_CreateUser.Click += new System.EventHandler(this.Btn_CreateUser_Click);
            // 
            // btn_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(513, 759);
            this.Controls.Add(this.Btn_CreateUser);
            this.Controls.Add(this.txtBox_NewUserPass);
            this.Controls.Add(this.txtBox_NewUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btn_Create";
            this.Text = "The Handicapp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_NewUserName;
        private System.Windows.Forms.TextBox txtBox_NewUserPass;
        private System.Windows.Forms.Button Btn_CreateUser;
    }
}