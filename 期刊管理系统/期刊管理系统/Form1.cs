using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace 期刊管理系统
{
    public partial class Form1 : Form
    {
        public string connStr;

        public Form1()
        {
            InitializeComponent();
            connStr = Properties.Settings.Default.JournalManagementConnectionString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            int currIndex = dataGridView1.CurrentRow.Index; // 当前行
            // 第0列是checkbox
            int journalId = Convert.ToInt32(dataGridView1.Rows[currIndex].Cells[1].Value);

            using (OdbcConnection conn = new OdbcConnection(connStr))
            {
                conn.Open();
                string sqlStr = "SELECT J.journal_id, J.journal_name, J.new_publish_date, C.catalog_name, T.typee_name\n"+
                    "FROM Journal AS J, Editor AS E, Typee AS T, Catalogg AS C\n"+
                    "WHERE journal_id = "+ journalId.ToString() + "\n" +
                    "AND J.editor_id = E.editor_id\n"+
                    "AND J.typee_id = T.typee_id\n"+
                    "AND T.catalog_id = C.catalog_id;";
                OdbcDataReader reader = new OdbcCommand(sqlStr, conn).ExecuteReader(); // 执行查询语句
                Hashtable infoTable = new Hashtable(); // 准备给对话框传参
                if (reader.Read())
                {
                    infoTable.Add("id", Convert.ToInt32(reader[0]));
                    infoTable.Add("name", Convert.ToString(reader[1]));
                    infoTable.Add("publish_date", Convert.ToDateTime(reader[2]));
                    infoTable.Add("catalog_name", Convert.ToString(reader[3]));
                    infoTable.Add("typee_name", Convert.ToString(reader[4]));
                    // 显示
                    DJournalInfo dJournal = new DJournalInfo(infoTable, connStr);
                    if (dJournal.ShowDialog() == DialogResult.OK)
                    {
                        infoTable = dJournal.getNewInfo();
                        // 更新数据，并刷新页面
                        // 1. 查询typee
                        sqlStr = "SELECT typee_id\n" +
                            "FROM Typee\n" +
                            "WHERE typee_name = \'" + infoTable["typee_name"] + "\';";
                        reader = new OdbcCommand(sqlStr, conn).ExecuteReader(); // 执行查询语句
                        reader.Read();
                        string typeeid = Convert.ToString(reader[0]);
                        // 2. 更新
                        sqlStr = "UPDATE Journal\n" +
                            "SET journal_name = \'" + infoTable["name"] + "\',\n" +
                            "new_publish_date = \'" + infoTable["publish_date"] + "\',\n" +
                            "typee_id = \'" + typeeid + "\'\n" +
                            "WHERE journal_id = " + journalId + ";" ;
                        noQuery(sqlStr);
                        // 刷新gridview
                        updateGridView();
                    }
                }
            }
        }

        private void updateGridView()
        {
            // TODO: 这行代码将数据加载到表“journalManagementDataSet.V_Journal”中。您可以根据需要移动或删除它。
            this.v_JournalTableAdapter.Fill(this.journalManagementDataSet.V_Journal);
        }

        public void noQuery(string sql)
        {
            OdbcConnection conn = new OdbcConnection(connStr);
            OdbcCommand cmd = new OdbcCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
