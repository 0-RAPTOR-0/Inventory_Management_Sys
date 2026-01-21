namespace Inventory_Management_Sys
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_Btn = new System.Windows.Forms.Button();
            this.Customers_Btn = new System.Windows.Forms.Button();
            this.Addproduct_Btn = new System.Windows.Forms.Button();
            this.Addcategories_Btn = new System.Windows.Forms.Button();
            this.Addusers_Btn = new System.Windows.Forms.Button();
            this.Dashboard_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.admin_Add_Users2 = new Inventory_Management_Sys.User_Control_Forms.Admin_Add_Users();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "l_M_ Sys | Admin\'s Portal";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(1238, 8);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(67, 31);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.Logout_Btn);
            this.panel2.Controls.Add(this.Customers_Btn);
            this.panel2.Controls.Add(this.Addproduct_Btn);
            this.panel2.Controls.Add(this.Addcategories_Btn);
            this.panel2.Controls.Add(this.Addusers_Btn);
            this.panel2.Controls.Add(this.Dashboard_Btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 895);
            this.panel2.TabIndex = 1;
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.BackColor = System.Drawing.Color.Black;
            this.Logout_Btn.FlatAppearance.BorderSize = 0;
            this.Logout_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Logout_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Btn.ForeColor = System.Drawing.Color.White;
            this.Logout_Btn.Location = new System.Drawing.Point(35, 781);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Size = new System.Drawing.Size(231, 49);
            this.Logout_Btn.TabIndex = 8;
            this.Logout_Btn.Text = "LogOut";
            this.Logout_Btn.UseVisualStyleBackColor = false;
            this.Logout_Btn.Click += new System.EventHandler(this.Logout_Btn_Click);
            // 
            // Customers_Btn
            // 
            this.Customers_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Customers_Btn.FlatAppearance.BorderSize = 0;
            this.Customers_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Customers_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Customers_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_Btn.ForeColor = System.Drawing.Color.Black;
            this.Customers_Btn.Location = new System.Drawing.Point(35, 491);
            this.Customers_Btn.Name = "Customers_Btn";
            this.Customers_Btn.Size = new System.Drawing.Size(231, 49);
            this.Customers_Btn.TabIndex = 7;
            this.Customers_Btn.Text = "Customers";
            this.Customers_Btn.UseVisualStyleBackColor = false;
            // 
            // Addproduct_Btn
            // 
            this.Addproduct_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Addproduct_Btn.FlatAppearance.BorderSize = 0;
            this.Addproduct_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Addproduct_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addproduct_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addproduct_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addproduct_Btn.ForeColor = System.Drawing.Color.Black;
            this.Addproduct_Btn.Location = new System.Drawing.Point(35, 420);
            this.Addproduct_Btn.Name = "Addproduct_Btn";
            this.Addproduct_Btn.Size = new System.Drawing.Size(231, 49);
            this.Addproduct_Btn.TabIndex = 6;
            this.Addproduct_Btn.Text = "Add Products";
            this.Addproduct_Btn.UseVisualStyleBackColor = false;
            // 
            // Addcategories_Btn
            // 
            this.Addcategories_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Addcategories_Btn.FlatAppearance.BorderSize = 0;
            this.Addcategories_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Addcategories_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addcategories_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addcategories_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addcategories_Btn.ForeColor = System.Drawing.Color.Black;
            this.Addcategories_Btn.Location = new System.Drawing.Point(35, 348);
            this.Addcategories_Btn.Name = "Addcategories_Btn";
            this.Addcategories_Btn.Size = new System.Drawing.Size(231, 49);
            this.Addcategories_Btn.TabIndex = 5;
            this.Addcategories_Btn.Text = "Add Categories";
            this.Addcategories_Btn.UseVisualStyleBackColor = false;
            // 
            // Addusers_Btn
            // 
            this.Addusers_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Addusers_Btn.FlatAppearance.BorderSize = 0;
            this.Addusers_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Addusers_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addusers_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addusers_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addusers_Btn.ForeColor = System.Drawing.Color.Black;
            this.Addusers_Btn.Location = new System.Drawing.Point(35, 275);
            this.Addusers_Btn.Name = "Addusers_Btn";
            this.Addusers_Btn.Size = new System.Drawing.Size(231, 49);
            this.Addusers_Btn.TabIndex = 4;
            this.Addusers_Btn.Text = "Add Users";
            this.Addusers_Btn.UseVisualStyleBackColor = false;
            // 
            // Dashboard_Btn
            // 
            this.Dashboard_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard_Btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Dashboard_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Dashboard_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Btn.ForeColor = System.Drawing.Color.Black;
            this.Dashboard_Btn.Location = new System.Drawing.Point(35, 204);
            this.Dashboard_Btn.Name = "Dashboard_Btn";
            this.Dashboard_Btn.Size = new System.Drawing.Size(231, 49);
            this.Dashboard_Btn.TabIndex = 2;
            this.Dashboard_Btn.Text = "Dashboard";
            this.Dashboard_Btn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.admin_Add_Users2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(307, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1010, 895);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // admin_Add_Users2
            // 
            this.admin_Add_Users2.Location = new System.Drawing.Point(3, 3);
            this.admin_Add_Users2.Name = "admin_Add_Users2";
            this.admin_Add_Users2.Size = new System.Drawing.Size(1007, 892);
            this.admin_Add_Users2.TabIndex = 0;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 945);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addproduct_Btn;
        private System.Windows.Forms.Button Addcategories_Btn;
        private System.Windows.Forms.Button Addusers_Btn;
        private System.Windows.Forms.Button Dashboard_Btn;
        private System.Windows.Forms.Button Customers_Btn;
        private System.Windows.Forms.Button Logout_Btn;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private User_Control_Forms.Admin_Add_Users admin_Add_Users1;
        private User_Control_Forms.Admin_Add_Users admin_Add_Users2;
    }
}