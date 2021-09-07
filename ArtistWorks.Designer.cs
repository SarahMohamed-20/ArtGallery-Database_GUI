namespace DatabaseProj
{
    partial class ArtistWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistWorks));
            System.Windows.Forms.Label artistNameLabel;
            System.Windows.Forms.Label styleOfArtLabel;
            this.artistArtworksDataSet = new DatabaseProj.artistArtworksDataSet();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistTableAdapter = new DatabaseProj.artistArtworksDataSetTableAdapters.ArtistTableAdapter();
            this.tableAdapterManager = new DatabaseProj.artistArtworksDataSetTableAdapters.TableAdapterManager();
            this.artistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.artistBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.artWorkTableAdapter = new DatabaseProj.artistArtworksDataSetTableAdapters.ArtWorkTableAdapter();
            this.artWorkDataGridView = new System.Windows.Forms.DataGridView();
            this.artistNameTextBox = new System.Windows.Forms.TextBox();
            this.styleOfArtTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            artistNameLabel = new System.Windows.Forms.Label();
            styleOfArtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artistArtworksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingNavigator)).BeginInit();
            this.artistBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // artistArtworksDataSet
            // 
            this.artistArtworksDataSet.DataSetName = "artistArtworksDataSet";
            this.artistArtworksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataMember = "Artist";
            this.artistBindingSource.DataSource = this.artistArtworksDataSet;
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtistTableAdapter = this.artistTableAdapter;
            this.tableAdapterManager.ArtWorkTableAdapter = this.artWorkTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DatabaseProj.artistArtworksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // artistBindingNavigator
            // 
            this.artistBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.artistBindingNavigator.BindingSource = this.artistBindingSource;
            this.artistBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.artistBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.artistBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.artistBindingNavigatorSaveItem});
            this.artistBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.artistBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.artistBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.artistBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.artistBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.artistBindingNavigator.Name = "artistBindingNavigator";
            this.artistBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.artistBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.artistBindingNavigator.Size = new System.Drawing.Size(669, 25);
            this.artistBindingNavigator.TabIndex = 0;
            this.artistBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(81, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // artistBindingNavigatorSaveItem
            // 
            this.artistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.artistBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("artistBindingNavigatorSaveItem.Image")));
            this.artistBindingNavigatorSaveItem.Name = "artistBindingNavigatorSaveItem";
            this.artistBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.artistBindingNavigatorSaveItem.Text = "Save Data";
            this.artistBindingNavigatorSaveItem.Click += new System.EventHandler(this.artistBindingNavigatorSaveItem_Click);
            // 
            // artWorkTableAdapter
            // 
            this.artWorkTableAdapter.ClearBeforeFill = true;
            // 
            // artWorkDataGridView
            // 
            this.artWorkDataGridView.AutoGenerateColumns = false;
            this.artWorkDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.artWorkDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artWorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artWorkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.artWorkDataGridView.DataSource = this.artWorkBindingSource;
            this.artWorkDataGridView.GridColor = System.Drawing.SystemColors.Menu;
            this.artWorkDataGridView.Location = new System.Drawing.Point(100, 180);
            this.artWorkDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.artWorkDataGridView.Name = "artWorkDataGridView";
            this.artWorkDataGridView.Size = new System.Drawing.Size(446, 266);
            this.artWorkDataGridView.TabIndex = 8;
            // 
            // artistNameLabel
            // 
            artistNameLabel.AutoSize = true;
            artistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            artistNameLabel.Location = new System.Drawing.Point(172, 74);
            artistNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            artistNameLabel.Name = "artistNameLabel";
            artistNameLabel.Size = new System.Drawing.Size(101, 18);
            artistNameLabel.TabIndex = 8;
            artistNameLabel.Text = "Artist Name:";
            // 
            // artistNameTextBox
            // 
            this.artistNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artistBindingSource, "artistName", true));
            this.artistNameTextBox.Location = new System.Drawing.Point(313, 71);
            this.artistNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.artistNameTextBox.Name = "artistNameTextBox";
            this.artistNameTextBox.Size = new System.Drawing.Size(164, 24);
            this.artistNameTextBox.TabIndex = 9;
            // 
            // styleOfArtLabel
            // 
            styleOfArtLabel.AutoSize = true;
            styleOfArtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleOfArtLabel.Location = new System.Drawing.Point(172, 117);
            styleOfArtLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            styleOfArtLabel.Name = "styleOfArtLabel";
            styleOfArtLabel.Size = new System.Drawing.Size(99, 18);
            styleOfArtLabel.TabIndex = 14;
            styleOfArtLabel.Text = "Style Of Art:";
            // 
            // styleOfArtTextBox
            // 
            this.styleOfArtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artistBindingSource, "styleOfArt", true));
            this.styleOfArtTextBox.Location = new System.Drawing.Point(313, 114);
            this.styleOfArtTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.styleOfArtTextBox.Name = "styleOfArtTextBox";
            this.styleOfArtTextBox.Size = new System.Drawing.Size(164, 24);
            this.styleOfArtTextBox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "YearItWasMade";
            this.dataGridViewTextBoxColumn2.HeaderText = "YearItWasMade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // artWorkBindingSource
            // 
            this.artWorkBindingSource.DataMember = "FK__ArtWork__artistt__21B6055D";
            this.artWorkBindingSource.DataSource = this.artistBindingSource;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(526, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ArtistWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(artistNameLabel);
            this.Controls.Add(this.artistNameTextBox);
            this.Controls.Add(styleOfArtLabel);
            this.Controls.Add(this.styleOfArtTextBox);
            this.Controls.Add(this.artWorkDataGridView);
            this.Controls.Add(this.artistBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ArtistWorks";
            this.Text = "ArtistWorks";
            this.Load += new System.EventHandler(this.ArtistWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artistArtworksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingNavigator)).EndInit();
            this.artistBindingNavigator.ResumeLayout(false);
            this.artistBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artWorkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private artistArtworksDataSet artistArtworksDataSet;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private artistArtworksDataSetTableAdapters.ArtistTableAdapter artistTableAdapter;
        private artistArtworksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator artistBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton artistBindingNavigatorSaveItem;
        private artistArtworksDataSetTableAdapters.ArtWorkTableAdapter artWorkTableAdapter;
        private System.Windows.Forms.BindingSource artWorkBindingSource;
        private System.Windows.Forms.DataGridView artWorkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox artistNameTextBox;
        private System.Windows.Forms.TextBox styleOfArtTextBox;
        private System.Windows.Forms.Button button2;
    }
}