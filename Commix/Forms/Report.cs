using Commix.Services;
using System;
using System.Data;
using System.Windows.Forms;
using static Commix.LocalDatabase.LocalTestDatabaseDataSet;

namespace Commix.Forms
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataRow[] dataRows = LocalRepository.ReadBy(this.textBoxFilter.Text);
            this.labelResult.Text = ((LocalTestTableRow)dataRows[0]).Title;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            LocalRepository.Save(int.Parse(this.idTextBox.Text), this.userIdTextBox.Text, this.titleTextBox.Text, this.completedCheckBox.Checked);
        }

        private void localTestTableBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.localTestTableBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.localTestDatabaseDataSet1);

        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'localTestDatabaseDataSet1.LocalTestTable'. È possibile spostarla o rimuoverla se necessario.
            this.localTestTableTableAdapter1.Fill(this.localTestDatabaseDataSet1.LocalTestTable);

        }
    }
}
