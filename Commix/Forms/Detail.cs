using Commix.Databases;
using Commix.Models;
using Commix.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Commix.Forms
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            List<Databases.Report> list = LocalRepository.ReadAllReports();
            var bindingList = new BindingList<Databases.Report>(list);
            var source = new BindingSource(bindingList, null);
            this.dataGridView1.DataSource = source;
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count == 1)
            {
                TestModel tm = LocalRepository.ReadContentById(((Databases.Report)this.dataGridView1.SelectedRows[0].DataBoundItem).Id);
                this.idTextBox.Text = tm.Id.ToString();
                this.userIdTextBox.Text = tm.UserId;
                this.titleTextBox.Text = tm.Title;
                this.completedCheckBox.Checked = tm.Completed;
            }

        } 

    }
}
