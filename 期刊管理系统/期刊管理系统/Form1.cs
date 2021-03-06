﻿using System;
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

        // 改
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
                        updateGridView();
                    }
                }
            }
        }

        private void updateGridView()
        {
            // TODO: 这行代码将数据加载到表“journalManagementDataSet.V_Journal”中。您可以根据需要移动或删除它。
            this.dataGridView1.DataSource = this.vJournalBindingSource;
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

        // 增
        private void btn_add_Click(object sender, EventArgs e)
        {
            int currIndex = dataGridView1.CurrentRow.Index; // 当前行
            int journalId = Convert.ToInt32(dataGridView1.Rows[currIndex].Cells[1].Value);

            Hashtable infoTable = new Hashtable();
            OdbcDataReader reader;
            using (OdbcConnection conn = new OdbcConnection(connStr))
            {
                conn.Open();
                string sqlStr;
                // 先给一个journal_id以防重复
                sqlStr = "SELECT MAX(journal_id)\n" +
                    "FROM Journal\n";
                reader = new OdbcCommand(sqlStr, conn).ExecuteReader(); 
                reader.Read();
                infoTable["id"] = Convert.ToInt32(reader[0]) + 1;

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
                    // 2. 揷数据
                    sqlStr = "INSERT INTO Journal (journal_id, journal_name, new_publish_date, editor_id, typee_id)\n" +
                        string.Format("VALUES ('{0}', '{1}', '{2}', {3}, '{4}');",
                        infoTable["id"], infoTable["name"], infoTable["publish_date"], 3, typeeid);
                    noQuery(sqlStr);
                    updateGridView();
                    }
            }
        }

        // 删
        private void btn_del_Click(object sender, EventArgs e)
        {
            int currIndex = dataGridView1.CurrentRow.Index; // 当前行

            Hashtable infoTable = new Hashtable();
            using (OdbcConnection conn = new OdbcConnection(connStr))
            {
                conn.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cboxCell = (DataGridViewCheckBoxCell)
                        this.dataGridView1.Rows[i].Cells["col_chbox"];
                    if (Convert.ToBoolean(cboxCell.Value) || i == currIndex)
                    {
                        int journalId = Convert.ToInt32(dataGridView1.Rows[i].
                            Cells[1].Value);
                        string sqlStr = string.Format("DELETE  FROM Journal\n" +
                            "WHERE journal_id = {0};", journalId);
                        noQuery(sqlStr);
                    }
                }
            }
            updateGridView();
        }

        // 查
        private void btn_search_Click(object sender, EventArgs e)
        {
            DSearch dSearch = new DSearch();
            if (dSearch.ShowDialog() == DialogResult.OK)
            {
                string[] journalNameList = dSearch.getJournalNames();
                string[] typeesList = dSearch.getTypees();
                string[] publisherList = dSearch.getPublishers();
                string sqlStr = "SELECT *\n" +
                    "FROM V_Journal\n" +
                    "WHERE journal_id != -1\n";

                // 先typee
                if (typeesList.Length > 0 && typeesList[0].Length > 0)
                {
                    string typeeStr = "AND (";
                    typeeStr += (string.Format("typee_name LIKE '%{0}%'\n", typeesList[0]));
                    for (int i = 1; i < typeesList.Length; i++)
                        typeeStr += (string.Format("OR typee_name LIKE '%{0}%'\n", typeesList[i]));
                    typeeStr += ")";
                    sqlStr += typeeStr;
                }

                // 中journal
                if (journalNameList.Length > 0 && journalNameList[0].Length > 0)
                {
                    string journalStr = "AND (";
                    journalStr += (string.Format("journal_name LIKE '%{0}%'\n", journalNameList[0]));
                    for (int i = 1; i < journalNameList.Length; i++)
                        journalStr += (string.Format("OR journal_name LIKE '%{0}%'\n", journalNameList[i]));
                    journalStr += ")";
                    sqlStr += journalStr;
                }

                // 后publisher
                if (publisherList.Length > 0&& publisherList[0].Length > 0)
                {
                    string publisherStr = "AND (";
                    publisherStr += (string.Format("publisher_name LIKE '%{0}%'\n", publisherList[0]));
                    for (int i = 1; i < publisherList.Length; i++)
                        publisherStr += (string.Format("OR publisher_name LIKE '%{0}%'\n", publisherList[i]));
                    publisherStr += ")";
                    sqlStr += publisherStr;
                }

                if (typeesList.Length <= 0 && journalNameList.Length <= 0
                    && publisherList.Length <= 0)
                    sqlStr += "AND journal_id = -1";
                sqlStr += ";";

                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sqlStr, connStr);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateGridView();
        }
    }
}
