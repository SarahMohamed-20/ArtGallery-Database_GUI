
namespace DatabaseProj
{
    partial class intro
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
            this.label1 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Button();
            this.EmpBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE ACCESSING PERSON";
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.Info;
            this.Admin.Location = new System.Drawing.Point(199, 109);
            this.Admin.Margin = new System.Windows.Forms.Padding(2);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(195, 42);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // EmpBtn
            // 
            this.EmpBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.EmpBtn.Location = new System.Drawing.Point(199, 190);
            this.EmpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EmpBtn.Name = "EmpBtn";
            this.EmpBtn.Size = new System.Drawing.Size(195, 42);
            this.EmpBtn.TabIndex = 4;
            this.EmpBtn.Text = "Employee";
            this.EmpBtn.UseVisualStyleBackColor = false;
            this.EmpBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(199, 269);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Customer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EmpBtn);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "intro";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button EmpBtn;
        private System.Windows.Forms.Button button4;
    }
}