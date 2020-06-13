namespace Commix.Forms
{
    partial class Detail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadownloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataultimosalvataggioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datauploadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datadownloadDataGridViewTextBoxColumn,
            this.dataultimosalvataggioDataGridViewTextBoxColumn,
            this.datauploadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // datadownloadDataGridViewTextBoxColumn
            // 
            this.datadownloadDataGridViewTextBoxColumn.DataPropertyName = "data_download";
            this.datadownloadDataGridViewTextBoxColumn.HeaderText = "data_download";
            this.datadownloadDataGridViewTextBoxColumn.Name = "datadownloadDataGridViewTextBoxColumn";
            // 
            // dataultimosalvataggioDataGridViewTextBoxColumn
            // 
            this.dataultimosalvataggioDataGridViewTextBoxColumn.DataPropertyName = "data_ultimo_salvataggio";
            this.dataultimosalvataggioDataGridViewTextBoxColumn.HeaderText = "data_ultimo_salvataggio";
            this.dataultimosalvataggioDataGridViewTextBoxColumn.Name = "dataultimosalvataggioDataGridViewTextBoxColumn";
            // 
            // datauploadDataGridViewTextBoxColumn
            // 
            this.datauploadDataGridViewTextBoxColumn.DataPropertyName = "data_upload";
            this.datauploadDataGridViewTextBoxColumn.HeaderText = "data_upload";
            this.datauploadDataGridViewTextBoxColumn.Name = "datauploadDataGridViewTextBoxColumn";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(Commix.Databases.Report);
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Detail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadownloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataultimosalvataggioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datauploadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportBindingSource;
    }
}