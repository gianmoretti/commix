namespace Commix.Forms
{
    partial class Report
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label completedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.buttonRicerca = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelRicerca = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.localTestDatabaseDataSet1 = new Commix.LocalDatabase.LocalTestDatabaseDataSet();
            this.localTestTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.localTestTableTableAdapter1 = new Commix.LocalDatabase.LocalTestDatabaseDataSetTableAdapters.LocalTestTableTableAdapter();
            this.tableAdapterManager1 = new Commix.LocalDatabase.LocalTestDatabaseDataSetTableAdapters.TableAdapterManager();
            this.localTestTableBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.localTestTableBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.localTestTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            completedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localTestDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localTestTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localTestTableBindingSource1BindingNavigator)).BeginInit();
            this.localTestTableBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localTestTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(17, 56);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(17, 82);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(44, 13);
            userIdLabel.TabIndex = 8;
            userIdLabel.Text = "User Id:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(17, 108);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Title:";
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Location = new System.Drawing.Point(17, 136);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new System.Drawing.Size(60, 13);
            completedLabel.TabIndex = 12;
            completedLabel.Text = "Completed:";
            // 
            // buttonRicerca
            // 
            this.buttonRicerca.Location = new System.Drawing.Point(303, 87);
            this.buttonRicerca.Name = "buttonRicerca";
            this.buttonRicerca.Size = new System.Drawing.Size(75, 23);
            this.buttonRicerca.TabIndex = 0;
            this.buttonRicerca.Text = "Ricerca";
            this.buttonRicerca.UseVisualStyleBackColor = true;
            this.buttonRicerca.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(312, 135);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "empty";
            // 
            // labelRicerca
            // 
            this.labelRicerca.AutoSize = true;
            this.labelRicerca.Location = new System.Drawing.Point(253, 56);
            this.labelRicerca.Name = "labelRicerca";
            this.labelRicerca.Size = new System.Drawing.Size(44, 13);
            this.labelRicerca.TabIndex = 3;
            this.labelRicerca.Text = "Ricerca";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(83, 53);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 7;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(83, 79);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(104, 20);
            this.userIdTextBox.TabIndex = 9;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(83, 105);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(104, 20);
            this.titleTextBox.TabIndex = 11;
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.Location = new System.Drawing.Point(83, 131);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.completedCheckBox.TabIndex = 13;
            this.completedCheckBox.Text = "checkBox1";
            this.completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(20, 170);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(303, 48);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 15;
            // 
            // localTestDatabaseDataSet1
            // 
            this.localTestDatabaseDataSet1.DataSetName = "LocalTestDatabaseDataSet";
            this.localTestDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localTestTableBindingSource1
            // 
            this.localTestTableBindingSource1.DataMember = "LocalTestTable";
            this.localTestTableBindingSource1.DataSource = this.localTestDatabaseDataSet1;
            // 
            // localTestTableTableAdapter1
            // 
            this.localTestTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LocalTestTableTableAdapter = this.localTestTableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Commix.LocalDatabase.LocalTestDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // localTestTableBindingSource1BindingNavigator
            // 
            this.localTestTableBindingSource1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.localTestTableBindingSource1BindingNavigator.BindingSource = this.localTestTableBindingSource1;
            this.localTestTableBindingSource1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.localTestTableBindingSource1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.localTestTableBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.localTestTableBindingSource1BindingNavigatorSaveItem});
            this.localTestTableBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.localTestTableBindingSource1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.localTestTableBindingSource1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.localTestTableBindingSource1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.localTestTableBindingSource1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.localTestTableBindingSource1BindingNavigator.Name = "localTestTableBindingSource1BindingNavigator";
            this.localTestTableBindingSource1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.localTestTableBindingSource1BindingNavigator.Size = new System.Drawing.Size(850, 25);
            this.localTestTableBindingSource1BindingNavigator.TabIndex = 16;
            this.localTestTableBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 15);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
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
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
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
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // localTestTableBindingSource1BindingNavigatorSaveItem
            // 
            this.localTestTableBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.localTestTableBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("localTestTableBindingSource1BindingNavigatorSaveItem.Image")));
            this.localTestTableBindingSource1BindingNavigatorSaveItem.Name = "localTestTableBindingSource1BindingNavigatorSaveItem";
            this.localTestTableBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.localTestTableBindingSource1BindingNavigatorSaveItem.Text = "Salva dati";
            this.localTestTableBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.localTestTableBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // localTestTableDataGridView
            // 
            this.localTestTableDataGridView.AutoGenerateColumns = false;
            this.localTestTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localTestTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.localTestTableDataGridView.DataSource = this.localTestTableBindingSource1;
            this.localTestTableDataGridView.Location = new System.Drawing.Point(530, 58);
            this.localTestTableDataGridView.Name = "localTestTableDataGridView";
            this.localTestTableDataGridView.Size = new System.Drawing.Size(300, 220);
            this.localTestTableDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Completed";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Completed";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.localTestTableDataGridView);
            this.Controls.Add(this.localTestTableBindingSource1BindingNavigator);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(completedLabel);
            this.Controls.Add(this.completedCheckBox);
            this.Controls.Add(this.labelRicerca);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRicerca);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localTestDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localTestTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localTestTableBindingSource1BindingNavigator)).EndInit();
            this.localTestTableBindingSource1BindingNavigator.ResumeLayout(false);
            this.localTestTableBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localTestTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRicerca;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRicerca;
        private LocalDatabase.LocalTestDatabaseDataSet localTestDatabaseDataSet;
        private System.Windows.Forms.BindingSource localTestTableBindingSource;
        private LocalDatabase.LocalTestDatabaseDataSetTableAdapters.LocalTestTableTableAdapter localTestTableTableAdapter;
        private LocalDatabase.LocalTestDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFilter;
        private LocalDatabase.LocalTestDatabaseDataSet localTestDatabaseDataSet1;
        private System.Windows.Forms.BindingSource localTestTableBindingSource1;
        private LocalDatabase.LocalTestDatabaseDataSetTableAdapters.LocalTestTableTableAdapter localTestTableTableAdapter1;
        private LocalDatabase.LocalTestDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator localTestTableBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton localTestTableBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView localTestTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}