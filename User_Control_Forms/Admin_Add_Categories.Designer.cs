namespace Inventory_Management_Sys.User_Control_Forms
{
    partial class Admin_Add_Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Add_Categories));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_Category_Data_Grid_V = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Category_Clear_Btn = new System.Windows.Forms.Button();
            this.Add_Category_Remove_Btn = new System.Windows.Forms.Button();
            this.Add_Category_Update_Btn = new System.Windows.Forms.Button();
            this.Add_Category_Add_Btn = new System.Windows.Forms.Button();
            this.Add_Categories_category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Category_Data_Grid_V)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Add_Category_Data_Grid_V);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(460, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 760);
            this.panel2.TabIndex = 5;
            // 
            // Add_Category_Data_Grid_V
            // 
            this.Add_Category_Data_Grid_V.AllowUserToAddRows = false;
            this.Add_Category_Data_Grid_V.AllowUserToDeleteRows = false;
            this.Add_Category_Data_Grid_V.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Add_Category_Data_Grid_V.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Add_Category_Data_Grid_V.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Add_Category_Data_Grid_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Add_Category_Data_Grid_V.Location = new System.Drawing.Point(3, 58);
            this.Add_Category_Data_Grid_V.Name = "Add_Category_Data_Grid_V";
            this.Add_Category_Data_Grid_V.ReadOnly = true;
            this.Add_Category_Data_Grid_V.RowHeadersVisible = false;
            this.Add_Category_Data_Grid_V.RowHeadersWidth = 51;
            this.Add_Category_Data_Grid_V.RowTemplate.Height = 24;
            this.Add_Category_Data_Grid_V.Size = new System.Drawing.Size(581, 697);
            this.Add_Category_Data_Grid_V.TabIndex = 15;
            this.Add_Category_Data_Grid_V.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Add_Category_Data_Grid_V_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "All Categories";
            // 
            // Add_Category_Clear_Btn
            // 
            this.Add_Category_Clear_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Category_Clear_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Add_Category_Clear_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Add_Category_Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Category_Clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Category_Clear_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Category_Clear_Btn.Location = new System.Drawing.Point(201, 402);
            this.Add_Category_Clear_Btn.Name = "Add_Category_Clear_Btn";
            this.Add_Category_Clear_Btn.Size = new System.Drawing.Size(107, 55);
            this.Add_Category_Clear_Btn.TabIndex = 13;
            this.Add_Category_Clear_Btn.Text = "Clear";
            this.Add_Category_Clear_Btn.UseVisualStyleBackColor = false;
            this.Add_Category_Clear_Btn.Click += new System.EventHandler(this.Add_Category_Clear_Btn_Click);
            // 
            // Add_Category_Remove_Btn
            // 
            this.Add_Category_Remove_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Category_Remove_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Add_Category_Remove_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Add_Category_Remove_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Category_Remove_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Category_Remove_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Category_Remove_Btn.Location = new System.Drawing.Point(38, 402);
            this.Add_Category_Remove_Btn.Name = "Add_Category_Remove_Btn";
            this.Add_Category_Remove_Btn.Size = new System.Drawing.Size(107, 55);
            this.Add_Category_Remove_Btn.TabIndex = 12;
            this.Add_Category_Remove_Btn.Text = "Remove";
            this.Add_Category_Remove_Btn.UseVisualStyleBackColor = false;
            this.Add_Category_Remove_Btn.Click += new System.EventHandler(this.Add_Category_Remove_Btn_Click);
            // 
            // Add_Category_Update_Btn
            // 
            this.Add_Category_Update_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Category_Update_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Add_Category_Update_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Add_Category_Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Category_Update_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Category_Update_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Category_Update_Btn.Location = new System.Drawing.Point(201, 303);
            this.Add_Category_Update_Btn.Name = "Add_Category_Update_Btn";
            this.Add_Category_Update_Btn.Size = new System.Drawing.Size(107, 55);
            this.Add_Category_Update_Btn.TabIndex = 11;
            this.Add_Category_Update_Btn.Text = "Update";
            this.Add_Category_Update_Btn.UseVisualStyleBackColor = false;
            this.Add_Category_Update_Btn.Click += new System.EventHandler(this.Add_Category_Update_Btn_Click);
            // 
            // Add_Category_Add_Btn
            // 
            this.Add_Category_Add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Category_Add_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Add_Category_Add_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Add_Category_Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Category_Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Category_Add_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Category_Add_Btn.Location = new System.Drawing.Point(38, 303);
            this.Add_Category_Add_Btn.Name = "Add_Category_Add_Btn";
            this.Add_Category_Add_Btn.Size = new System.Drawing.Size(107, 55);
            this.Add_Category_Add_Btn.TabIndex = 10;
            this.Add_Category_Add_Btn.Text = "Add";
            this.Add_Category_Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Category_Add_Btn.Click += new System.EventHandler(this.Add_Category_Add_Btn_Click);
            // 
            // Add_Categories_category
            // 
            this.Add_Categories_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Categories_category.Location = new System.Drawing.Point(38, 201);
            this.Add_Categories_category.Name = "Add_Categories_category";
            this.Add_Categories_category.Size = new System.Drawing.Size(271, 30);
            this.Add_Categories_category.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Add_Category_Clear_Btn);
            this.panel1.Controls.Add(this.Add_Category_Remove_Btn);
            this.panel1.Controls.Add(this.Add_Category_Update_Btn);
            this.panel1.Controls.Add(this.Add_Category_Add_Btn);
            this.panel1.Controls.Add(this.Add_Categories_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(81, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 697);
            this.panel1.TabIndex = 4;
            // 
            // Admin_Add_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Add_Categories";
            this.Size = new System.Drawing.Size(1138, 856);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Category_Data_Grid_V)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Add_Category_Data_Grid_V;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_Category_Clear_Btn;
        private System.Windows.Forms.Button Add_Category_Remove_Btn;
        private System.Windows.Forms.Button Add_Category_Update_Btn;
        private System.Windows.Forms.Button Add_Category_Add_Btn;
        private System.Windows.Forms.TextBox Add_Categories_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
