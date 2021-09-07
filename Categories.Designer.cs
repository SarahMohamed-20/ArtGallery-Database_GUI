namespace DatabaseProj
{
    partial class Categories
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.categoriesDataSet = new DatabaseProj.CategoriesDataSet();
            this.abstractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abstractTableAdapter = new DatabaseProj.CategoriesDataSetTableAdapters.abstractTableAdapter();
            this.tableAdapterManager = new DatabaseProj.CategoriesDataSetTableAdapters.TableAdapterManager();
            this.abstractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.abstractBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.abstractDataGridView = new System.Windows.Forms.DataGridView();
            this.expressionismBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expressionismTableAdapter = new DatabaseProj.CategoriesDataSetTableAdapters.expressionismTableAdapter();
            this.expressionismDataGridView = new System.Windows.Forms.DataGridView();
            this.modernismBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modernismTableAdapter = new DatabaseProj.CategoriesDataSetTableAdapters.modernismTableAdapter();
            this.modernismDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingNavigator)).BeginInit();
            this.abstractBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abstractDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(93, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Abstract";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(483, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modernism";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(854, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Expressionism";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // categoriesDataSet
            // 
            this.categoriesDataSet.DataSetName = "CategoriesDataSet";
            this.categoriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abstractBindingSource
            // 
            this.abstractBindingSource.DataMember = "abstract";
            this.abstractBindingSource.DataSource = this.categoriesDataSet;
            // 
            // abstractTableAdapter
            // 
            this.abstractTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.abstractTableAdapter = this.abstractTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.expressionismTableAdapter = this.expressionismTableAdapter;
            this.tableAdapterManager.modernismTableAdapter = this.modernismTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseProj.CategoriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // abstractBindingNavigator
            // 
            this.abstractBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.abstractBindingNavigator.BindingSource = this.abstractBindingSource;
            this.abstractBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.abstractBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.abstractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.abstractBindingNavigatorSaveItem});
            this.abstractBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.abstractBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.abstractBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.abstractBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.abstractBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.abstractBindingNavigator.Name = "abstractBindingNavigator";
            this.abstractBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.abstractBindingNavigator.Size = new System.Drawing.Size(1087, 25);
            this.abstractBindingNavigator.TabIndex = 4;
            this.abstractBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // abstractBindingNavigatorSaveItem
            // 
            this.abstractBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abstractBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("abstractBindingNavigatorSaveItem.Image")));
            this.abstractBindingNavigatorSaveItem.Name = "abstractBindingNavigatorSaveItem";
            this.abstractBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.abstractBindingNavigatorSaveItem.Text = "Save Data";
            this.abstractBindingNavigatorSaveItem.Click += new System.EventHandler(this.abstractBindingNavigatorSaveItem_Click);
            // 
            // abstractDataGridView
            // 
            this.abstractDataGridView.AllowUserToAddRows = false;
            this.abstractDataGridView.AllowUserToDeleteRows = false;
            this.abstractDataGridView.AutoGenerateColumns = false;
            this.abstractDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.abstractDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.abstractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abstractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.abstractDataGridView.DataSource = this.abstractBindingSource;
            this.abstractDataGridView.Location = new System.Drawing.Point(57, 113);
            this.abstractDataGridView.Name = "abstractDataGridView";
            this.abstractDataGridView.ReadOnly = true;
            this.abstractDataGridView.Size = new System.Drawing.Size(265, 278);
            this.abstractDataGridView.TabIndex = 4;
            // 
            // expressionismBindingSource
            // 
            this.expressionismBindingSource.DataMember = "expressionism";
            this.expressionismBindingSource.DataSource = this.categoriesDataSet;
            // 
            // expressionismTableAdapter
            // 
            this.expressionismTableAdapter.ClearBeforeFill = true;
            // 
            // expressionismDataGridView
            // 
            this.expressionismDataGridView.AllowUserToAddRows = false;
            this.expressionismDataGridView.AllowUserToDeleteRows = false;
            this.expressionismDataGridView.AutoGenerateColumns = false;
            this.expressionismDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.expressionismDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expressionismDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expressionismDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.expressionismDataGridView.DataSource = this.expressionismBindingSource;
            this.expressionismDataGridView.Location = new System.Drawing.Point(804, 113);
            this.expressionismDataGridView.Name = "expressionismDataGridView";
            this.expressionismDataGridView.ReadOnly = true;
            this.expressionismDataGridView.Size = new System.Drawing.Size(259, 278);
            this.expressionismDataGridView.TabIndex = 5;
            // 
            // modernismBindingSource
            // 
            this.modernismBindingSource.DataMember = "modernism";
            this.modernismBindingSource.DataSource = this.categoriesDataSet;
            // 
            // modernismTableAdapter
            // 
            this.modernismTableAdapter.ClearBeforeFill = true;
            // 
            // modernismDataGridView
            // 
            this.modernismDataGridView.AllowUserToAddRows = false;
            this.modernismDataGridView.AllowUserToDeleteRows = false;
            this.modernismDataGridView.AutoGenerateColumns = false;
            this.modernismDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.modernismDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modernismDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modernismDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.modernismDataGridView.DataSource = this.modernismBindingSource;
            this.modernismDataGridView.Location = new System.Drawing.Point(328, 113);
            this.modernismDataGridView.Name = "modernismDataGridView";
            this.modernismDataGridView.ReadOnly = true;
            this.modernismDataGridView.Size = new System.Drawing.Size(454, 278);
            this.modernismDataGridView.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(908, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Back To Options";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn8.HeaderText = "Title";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "form_Lines";
            this.dataGridViewTextBoxColumn5.HeaderText = "Form_Lines";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "form_colours";
            this.dataGridViewTextBoxColumn6.HeaderText = "Form_Colours";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "form_shapes";
            this.dataGridViewTextBoxColumn7.HeaderText = "Form_Shapes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "distortionType";
            this.dataGridViewTextBoxColumn4.HeaderText = "Distortion_Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "texture";
            this.dataGridViewTextBoxColumn2.HeaderText = "Texture";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 459);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.modernismDataGridView);
            this.Controls.Add(this.expressionismDataGridView);
            this.Controls.Add(this.abstractDataGridView);
            this.Controls.Add(this.abstractBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingNavigator)).EndInit();
            this.abstractBindingNavigator.ResumeLayout(false);
            this.abstractBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abstractDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private CategoriesDataSet categoriesDataSet;
        private System.Windows.Forms.BindingSource abstractBindingSource;
        private CategoriesDataSetTableAdapters.abstractTableAdapter abstractTableAdapter;
        private CategoriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator abstractBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton abstractBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView abstractDataGridView;
        private CategoriesDataSetTableAdapters.expressionismTableAdapter expressionismTableAdapter;
        private System.Windows.Forms.BindingSource expressionismBindingSource;
        private CategoriesDataSetTableAdapters.modernismTableAdapter modernismTableAdapter;
        private System.Windows.Forms.DataGridView expressionismDataGridView;
        private System.Windows.Forms.BindingSource modernismBindingSource;
        private System.Windows.Forms.DataGridView modernismDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button4;
    }
}