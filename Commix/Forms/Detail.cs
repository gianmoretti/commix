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
    }
}
