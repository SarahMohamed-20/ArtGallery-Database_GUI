namespace DatabaseProj
{
    partial class Categ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categ));
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
            this.artworkDataSet = new DatabaseProj.artworkDataSet();
            this.artWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artWorkTableAdapter = new DatabaseProj.artworkDataSetTableAdapters.ArtWorkTableAdapter();
            this.tableAdapterManager1 = new DatabaseProj.artworkDataSetTableAdapters.TableAdapterManager();
            this.modernismDataGridView = new System.Windows.Forms.DataGridView();
            this.artWorkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mod = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abstract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingNavigator)).BeginInit();
            this.abstractBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abstractDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artworkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.abstractBindingNavigator.Size = new System.Drawing.Size(581, 25);
            this.abstractBindingNavigator.TabIndex = 0;
            this.abstractBindingNavigator.Text = "bindingNavigator1";
            this.abstractBindingNavigator.RefreshItems += new System.EventHandler(this.abstractBindingNavigator_RefreshItems);
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
            this.abstractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abstractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abstract,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.abstractDataGridView.DataSource = this.abstractBindingSource;
            this.abstractDataGridView.Location = new System.Drawing.Point(25, 141);
            this.abstractDataGridView.Name = "abstractDataGridView";
            this.abstractDataGridView.ReadOnly = true;
            this.abstractDataGridView.Size = new System.Drawing.Size(544, 82);
            this.abstractDataGridView.TabIndex = 1;
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
            this.expressionismDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expressionismDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.expressionismDataGridView.DataSource = this.expressionismBindingSource;
            this.expressionismDataGridView.Location = new System.Drawing.Point(25, 242);
            this.expressionismDataGridView.Name = "expressionismDataGridView";
            this.expressionismDataGridView.ReadOnly = true;
            this.expressionismDataGridView.Size = new System.Drawing.Size(544, 92);
            this.expressionismDataGridView.TabIndex = 2;
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
            // artworkDataSet
            // 
            this.artworkDataSet.DataSetName = "artworkDataSet";
            this.artworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artWorkBindingSource
            // 
            this.artWorkBindingSource.DataMember = "ArtWork";
            this.artWorkBindingSource.DataSource = this.artworkDataSet;
            // 
            // artWorkTableAdapter
            // 
            this.artWorkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ArtWorkTableAdapter = this.artWorkTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = DatabaseProj.artworkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // modernismDataGridView
            // 
            this.modernismDataGridView.AllowUserToAddRows = false;
            this.modernismDataGridView.AllowUserToDeleteRows = false;
            this.modernismDataGridView.AutoGenerateColumns = false;
            this.modernismDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.modernismDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modernismDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mod,
            this.title,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.modernismDataGridView.DataSource = this.modernismBindingSource;
            this.modernismDataGridView.Location = new System.Drawing.Point(25, 39);
            this.modernismDataGridView.Name = "modernismDataGridView";
            this.modernismDataGridView.ReadOnly = true;
            this.modernismDataGridView.Size = new System.Drawing.Size(544, 96);
            this.modernismDataGridView.TabIndex = 3;
            // 
            // artWorkBindingSource1
            // 
            this.artWorkBindingSource1.DataMember = "ArtWork";
            this.artWorkBindingSource1.DataSource = this.artworkDataSet;
            // 
            // mod
            // 
            this.mod.HeaderText = "Modernism";
            this.mod.Name = "mod";
            this.mod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "form_lines";
            this.dataGridViewTextBoxColumn5.HeaderText = "Form_Lines";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "form_colours";
            this.dataGridViewTextBoxColumn6.HeaderText = "Form_Colours";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "form_shapes";
            this.dataGridViewTextBoxColumn7.HeaderText = "Form_Shapes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Type
            // 
            this.Type.HeaderText = "Expressionism";
            this.Type.Name = "Type";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "distortionType";
            this.dataGridViewTextBoxColumn4.HeaderText = "Distortion_Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Abstract
            // 
            this.Abstract.HeaderText = "Abstract";
            this.Abstract.Name = "Abstract";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "texture";
            this.dataGridViewTextBoxColumn3.HeaderText = "Texture";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Categ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 342);
            this.Controls.Add(this.modernismDataGridView);
            this.Controls.Add(this.expressionismDataGridView);
            this.Controls.Add(this.abstractDataGridView);
            this.Controls.Add(this.abstractBindingNavigator);
            this.Name = "Categ";
            this.Text = "Categ";
            this.Load += new System.EventHandler(this.Categ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractBindingNavigator)).EndInit();
            this.abstractBindingNavigator.ResumeLayout(false);
            this.abstractBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abstractDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionismDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artworkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernismDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private artworkDataSet artworkDataSet;
        private System.Windows.Forms.BindingSource artWorkBindingSource;
        private artworkDataSetTableAdapters.ArtWorkTableAdapter artWorkTableAdapter;
        private artworkDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView modernismDataGridView;
        private System.Windows.Forms.BindingSource artWorkBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abstract;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}