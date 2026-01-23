namespace Inventory_Management_Sys.User_Control_Forms
{
    partial class Admin_Add_Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Add_Users));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_User_Data_Grid_V = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Adduser_Clear_Btn = new System.Windows.Forms.Button();
            this.Adduser_Remove_Btn = new System.Windows.Forms.Button();
            this.Adduser_Update_Btn = new System.Windows.Forms.Button();
            this.Adduser_Add_Btn = new System.Windows.Forms.Button();
            this.Adduser_Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adduser_Role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adduser_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Adduser_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_User_Data_Grid_V)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Add_User_Data_Grid_V);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(448, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 760);
            this.panel2.TabIndex = 3;
            // 
            // Add_User_Data_Grid_V
            // 
            this.Add_User_Data_Grid_V.AllowUserToAddRows = false;
            this.Add_User_Data_Grid_V.AllowUserToDeleteRows = false;
            this.Add_User_Data_Grid_V.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Add_User_Data_Grid_V.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Add_User_Data_Grid_V.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Add_User_Data_Grid_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Add_User_Data_Grid_V.Location = new System.Drawing.Point(3, 58);
            this.Add_User_Data_Grid_V.Name = "Add_User_Data_Grid_V";
            this.Add_User_Data_Grid_V.ReadOnly = true;
            this.Add_User_Data_Grid_V.RowHeadersVisible = false;
            this.Add_User_Data_Grid_V.RowHeadersWidth = 51;
            this.Add_User_Data_Grid_V.RowTemplate.Height = 24;
            this.Add_User_Data_Grid_V.Size = new System.Drawing.Size(760, 697);
            this.Add_User_Data_Grid_V.TabIndex = 15;
            this.Add_User_Data_Grid_V.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Add_User_Data_Grid_V_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "All User\'s Data";
            // 
            // Adduser_Clear_Btn
            // 
            this.Adduser_Clear_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Adduser_Clear_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Adduser_Clear_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Adduser_Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adduser_Clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Clear_Btn.ForeColor = System.Drawing.Color.White;
            this.Adduser_Clear_Btn.Location = new System.Drawing.Point(194, 547);
            this.Adduser_Clear_Btn.Name = "Adduser_Clear_Btn";
            this.Adduser_Clear_Btn.Size = new System.Drawing.Size(107, 55);
            this.Adduser_Clear_Btn.TabIndex = 13;
            this.Adduser_Clear_Btn.Text = "Clear";
            this.Adduser_Clear_Btn.UseVisualStyleBackColor = false;
            this.Adduser_Clear_Btn.Click += new System.EventHandler(this.Adduser_Clear_Btn_Click);
            // 
            // Adduser_Remove_Btn
            // 
            this.Adduser_Remove_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Adduser_Remove_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Adduser_Remove_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Adduser_Remove_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adduser_Remove_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Remove_Btn.ForeColor = System.Drawing.Color.White;
            this.Adduser_Remove_Btn.Location = new System.Drawing.Point(31, 547);
            this.Adduser_Remove_Btn.Name = "Adduser_Remove_Btn";
            this.Adduser_Remove_Btn.Size = new System.Drawing.Size(107, 55);
            this.Adduser_Remove_Btn.TabIndex = 12;
            this.Adduser_Remove_Btn.Text = "Remove";
            this.Adduser_Remove_Btn.UseVisualStyleBackColor = false;
            this.Adduser_Remove_Btn.Click += new System.EventHandler(this.Adduser_Remove_Btn_Click);
            // 
            // Adduser_Update_Btn
            // 
            this.Adduser_Update_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Adduser_Update_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Adduser_Update_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Adduser_Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adduser_Update_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Update_Btn.ForeColor = System.Drawing.Color.White;
            this.Adduser_Update_Btn.Location = new System.Drawing.Point(194, 448);
            this.Adduser_Update_Btn.Name = "Adduser_Update_Btn";
            this.Adduser_Update_Btn.Size = new System.Drawing.Size(107, 55);
            this.Adduser_Update_Btn.TabIndex = 11;
            this.Adduser_Update_Btn.Text = "Update";
            this.Adduser_Update_Btn.UseVisualStyleBackColor = false;
            this.Adduser_Update_Btn.Click += new System.EventHandler(this.Adduser_Update_Btn_Click);
            // 
            // Adduser_Add_Btn
            // 
            this.Adduser_Add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Adduser_Add_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Adduser_Add_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Adduser_Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adduser_Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Add_Btn.ForeColor = System.Drawing.Color.White;
            this.Adduser_Add_Btn.Location = new System.Drawing.Point(31, 448);
            this.Adduser_Add_Btn.Name = "Adduser_Add_Btn";
            this.Adduser_Add_Btn.Size = new System.Drawing.Size(107, 55);
            this.Adduser_Add_Btn.TabIndex = 10;
            this.Adduser_Add_Btn.Text = "Add";
            this.Adduser_Add_Btn.UseVisualStyleBackColor = false;
            this.Adduser_Add_Btn.Click += new System.EventHandler(this.Adduser_Add_Btn_Click);
            // 
            // Adduser_Status
            // 
            this.Adduser_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Status.FormattingEnabled = true;
            this.Adduser_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.Adduser_Status.Location = new System.Drawing.Point(31, 352);
            this.Adduser_Status.Name = "Adduser_Status";
            this.Adduser_Status.Size = new System.Drawing.Size(270, 33);
            this.Adduser_Status.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // Adduser_Role
            // 
            this.Adduser_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Role.FormattingEnabled = true;
            this.Adduser_Role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.Adduser_Role.Location = new System.Drawing.Point(32, 264);
            this.Adduser_Role.Name = "Adduser_Role";
            this.Adduser_Role.Size = new System.Drawing.Size(270, 33);
            this.Adduser_Role.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // Adduser_Password
            // 
            this.Adduser_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Password.Location = new System.Drawing.Point(31, 183);
            this.Adduser_Password.Name = "Adduser_Password";
            this.Adduser_Password.Size = new System.Drawing.Size(271, 30);
            this.Adduser_Password.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Adduser_Username
            // 
            this.Adduser_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser_Username.Location = new System.Drawing.Point(30, 103);
            this.Adduser_Username.Name = "Adduser_Username";
            this.Adduser_Username.Size = new System.Drawing.Size(271, 30);
            this.Adduser_Username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Adduser_Clear_Btn);
            this.panel1.Controls.Add(this.Adduser_Remove_Btn);
            this.panel1.Controls.Add(this.Adduser_Update_Btn);
            this.panel1.Controls.Add(this.Adduser_Add_Btn);
            this.panel1.Controls.Add(this.Adduser_Status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Adduser_Role);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Adduser_Password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Adduser_Username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(69, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 697);
            this.panel1.TabIndex = 2;
            // 
            // Admin_Add_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Add_Users";
            this.Size = new System.Drawing.Size(1287, 879);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_User_Data_Grid_V)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Add_User_Data_Grid_V;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Adduser_Clear_Btn;
        private System.Windows.Forms.Button Adduser_Remove_Btn;
        private System.Windows.Forms.Button Adduser_Update_Btn;
        private System.Windows.Forms.Button Adduser_Add_Btn;
        private System.Windows.Forms.ComboBox Adduser_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Adduser_Role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adduser_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Adduser_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
