using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace 期刊管理系统
{
    public partial class DJournalInfo : Form
    {
        public DJournalInfo(Hashtable infoTable, string connStr)
        {
            InitializeComponent();

            // combobox--catalogg
            ArrayList arrCat = new ArrayList();
            string catStr = "SELECT catalog_name FROM Catalogg;";
            OdbcDataAdapter da = new OdbcDataAdapter(catStr, connStr);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
                arrCat.Add(dr[0].ToString().Trim());
            cmbox_cat.DataSource = arrCat; 
            // combobox--typee
            ArrayList arrTypee = new ArrayList();
            string typeeStr = "SELECT typee_name FROM Catalogg;";
            OdbcDataAdapter da1 = new OdbcDataAdapter(typeeStr, connStr);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
            foreach (DataRow dr in dt.Rows)
                arrTypee.Add(dr[0].ToString().Trim());
            cmbox_type.DataSource = arrTypee;

            this.tbox_id.Text = Convert.ToString(infoTable["id"]);
            this.tbox_name.Text = Convert.ToString(infoTable["name"]);
            this.tbox_publish_date.Text = Convert.ToString(infoTable["publish_date"]);
            this.cmbox_cat.Text = Convert.ToString(infoTable["catalog_name"]);
            this.cmbox_type.Text = Convert.ToString(infoTable["typee_name"]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
