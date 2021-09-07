
namespace DatabaseProj
{
    partial class Admin
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.AdminAdd = new System.Windows.Forms.Button();
            this.AdminUpdate = new System.Windows.Forms.Button();
            this.AdminDelete = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ComboBox();
            this.list2 = new System.Windows.Forms.ComboBox();
            this.list3 = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWelcome.Location = new System.Drawing.Point(99, 21);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(366, 53);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to Admin";
            // 
            // AdminAdd
            // 
            this.AdminAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AdminAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAdd.Location = new System.Drawing.Point(137, 115);
            this.AdminAdd.Margin = new System.Windows.Forms.Padding(2);
            this.AdminAdd.Name = "AdminAdd";
            this.AdminAdd.Size = new System.Drawing.Size(116, 41);
            this.AdminAdd.TabIndex = 1;
            this.AdminAdd.Text = "ADD";
            this.AdminAdd.UseVisualStyleBackColor = false;
            this.AdminAdd.Click += new System.EventHandler(this.AdminAdd_Click);
            // 
            // AdminUpdate
            // 
            this.AdminUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AdminUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUpdate.Location = new System.Drawing.Point(137, 175);
            this.AdminUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.AdminUpdate.Name = "AdminUpdate";
            this.AdminUpdate.Size = new System.Drawing.Size(116, 41);
            this.AdminUpdate.TabIndex = 2;
            this.AdminUpdate.Text = "UPDATE";
            this.AdminUpdate.UseVisualStyleBackColor = false;
            this.AdminUpdate.Click += new System.EventHandler(this.AdminUpdate_Click);
            // 
            // AdminDelete
            // 
            this.AdminDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDelete.Location = new System.Drawing.Point(137, 237);
            this.AdminDelete.Margin = new System.Windows.Forms.Padding(2);
            this.AdminDelete.Name = "AdminDelete";
            this.AdminDelete.Size = new System.Drawing.Size(116, 41);
            this.AdminDelete.TabIndex = 3;
            this.AdminDelete.Text = "DELETE";
            this.AdminDelete.UseVisualStyleBackColor = false;
            this.AdminDelete.Click += new System.EventHandler(this.AdminDelete_Click);
            // 
            // list1
            // 
            this.list1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1.FormattingEnabled = true;
            this.list1.Items.AddRange(new object[] {
            "Employee",
            "Artist"});
            this.list1.Location = new System.Drawing.Point(290, 120);
            this.list1.Margin = new System.Windows.Forms.Padding(2);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(175, 28);
            this.list1.TabIndex = 4;
            // 
            // list2
            // 
            this.list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list2.FormattingEnabled = true;
            this.list2.Items.AddRange(new object[] {
            "Employee",
            "Artist"});
            this.list2.Location = new System.Drawing.Point(290, 184);
            this.list2.Margin = new System.Windows.Forms.Padding(2);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(175, 28);
            this.list2.TabIndex = 5;
            // 
            // list3
            // 
            this.list3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list3.FormattingEnabled = true;
            this.list3.Items.AddRange(new object[] {
            "Employee",
            "Artist"});
            this.list3.Location = new System.Drawing.Point(290, 244);
            this.list3.Margin = new System.Windows.Forms.Padding(2);
            this.list3.Name = "list3";
            this.list3.Size = new System.Drawing.Size(175, 28);
            this.list3.TabIndex = 6;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(450, 354);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(116, 41);
            this.back.TabIndex = 7;
            this.back.Text = "Return";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Employees",
            "Artists",
            "Specific Artist Artwork"});
            this.comboBox1.Location = new System.Drawing.Point(290, 304);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "DISPLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.list3);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.AdminDelete);
            this.Controls.Add(this.AdminUpdate);
            this.Controls.Add(this.AdminAdd);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Welcome Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button AdminAdd;
        private System.Windows.Forms.Button AdminUpdate;
        private System.Windows.Forms.Button AdminDelete;
        private System.Windows.Forms.ComboBox list1;
        private System.Windows.Forms.ComboBox list2;
        private System.Windows.Forms.ComboBox list3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

