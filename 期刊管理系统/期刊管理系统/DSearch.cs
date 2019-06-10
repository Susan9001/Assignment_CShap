using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期刊管理系统
{
    public partial class DSearch : Form
    {
        public DSearch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DSearch_Load(object sender, EventArgs e)
        {

        }

        public string getJournalNames()
        {
            return this.tbox_name.Text;
        }

        public string getTypees()
        {
            return this.tbox_name.Text;
        }

        public string getPublishers()
        {
            return this.tbox_publisher.Text;
        }
    }
}
