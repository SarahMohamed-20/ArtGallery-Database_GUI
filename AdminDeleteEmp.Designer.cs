
namespace DatabaseProj
{
    partial class AdminDeleteEmp
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.selectbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deletetxtF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 229);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(678, 149);
            this.dataGridView3.TabIndex = 88;
            // 
            // selectbtn
            // 
            this.selectbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.selectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbtn.Location = new System.Drawing.Point(305, 171);
            this.selectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(136, 31);
            this.selectbtn.TabIndex = 87;
            this.selectbtn.Text = "Select";
            this.selectbtn.UseVisualStyleBackColor = false;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 35);
            this.label2.TabIndex = 86;
            this.label2.Text = "Enter the Employee\'s ID you wish to delete";
            // 
            // deletetxtF
            // 
            this.deletetxtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletetxtF.Location = new System.Drawing.Point(45, 176);
            this.deletetxtF.Margin = new System.Windows.Forms.Padding(2);
            this.deletetxtF.Name = "deletetxtF";
            this.deletetxtF.Size = new System.Drawing.Size(153, 26);
            this.deletetxtF.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(196, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 53);
            this.label1.TabIndex = 84;
            this.label1.Text = "Delete Empoloye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Are you sure you want to delete thie Employee?";
            // 
            // yesbtn
            // 
            this.yesbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.yesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbtn.Location = new System.Drawing.Point(148, 440);
            this.yesbtn.Margin = new System.Windows.Forms.Padding(2);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(136, 37);
            this.yesbtn.TabIndex = 90;
            this.yesbtn.Text = "Yes";
            this.yesbtn.UseVisualStyleBackColor = false;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // nobtn
            // 
            this.nobtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobtn.Location = new System.Drawing.Point(402, 440);
            this.nobtn.Margin = new System.Windows.Forms.Padding(2);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(136, 37);
            this.nobtn.TabIndex = 91;
            this.nobtn.Text = "No , Go Back";
            this.nobtn.UseVisualStyleBackColor = false;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // AdminDeleteEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 509);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletetxtF);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDeleteEmp";
            this.Text = "Delete Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deletetxtF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button nobtn;
    }
}