namespace Inventory_Management_Sys
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Register_Label = new System.Windows.Forms.Label();
            this.Login_Username = new System.Windows.Forms.TextBox();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Login_ShowPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(829, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(67, 31);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Login_ShowPass);
            this.panel1.Controls.Add(this.Login_Btn);
            this.panel1.Controls.Add(this.Login_Password);
            this.panel1.Controls.Add(this.Login_Username);
            this.panel1.Controls.Add(this.Register_Label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(240, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 606);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(212, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "lNVENTORY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login_Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(109, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(109, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(42, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Have no account ? >";
            // 
            // Register_Label
            // 
            this.Register_Label.AutoSize = true;
            this.Register_Label.BackColor = System.Drawing.Color.Transparent;
            this.Register_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Label.ForeColor = System.Drawing.Color.Cyan;
            this.Register_Label.Location = new System.Drawing.Point(221, 521);
            this.Register_Label.Name = "Register_Label";
            this.Register_Label.Size = new System.Drawing.Size(139, 25);
            this.Register_Label.TabIndex = 6;
            this.Register_Label.Text = "Register here.";
            this.Register_Label.Click += new System.EventHandler(this.Register_Label_Click);
            // 
            // Login_Username
            // 
            this.Login_Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Username.Location = new System.Drawing.Point(113, 175);
            this.Login_Username.Name = "Login_Username";
            this.Login_Username.Size = new System.Drawing.Size(184, 30);
            this.Login_Username.TabIndex = 2;
            // 
            // Login_Password
            // 
            this.Login_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Password.Location = new System.Drawing.Point(113, 253);
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.PasswordChar = '*';
            this.Login_Password.Size = new System.Drawing.Size(184, 30);
            this.Login_Password.TabIndex = 7;
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.Black;
            this.Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Login_Btn.Location = new System.Drawing.Point(112, 361);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(184, 57);
            this.Login_Btn.TabIndex = 8;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = false;
            // 
            // Login_ShowPass
            // 
            this.Login_ShowPass.AutoSize = true;
            this.Login_ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.Login_ShowPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_ShowPass.ForeColor = System.Drawing.Color.White;
            this.Login_ShowPass.Location = new System.Drawing.Point(189, 308);
            this.Login_ShowPass.Name = "Login_ShowPass";
            this.Login_ShowPass.Size = new System.Drawing.Size(169, 29);
            this.Login_ShowPass.TabIndex = 2;
            this.Login_ShowPass.Text = "show Password";
            this.Login_ShowPass.UseVisualStyleBackColor = false;
            this.Login_ShowPass.CheckedChanged += new System.EventHandler(this.Login_ShowPass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 831);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Close);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Register_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.TextBox Login_Username;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.CheckBox Login_ShowPass;
    }
}

