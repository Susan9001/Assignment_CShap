namespace 期刊管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_chbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.journalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journalnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newpublishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalManagementDataSet = new 期刊管理系统.JournalManagementDataSet();
            this.v_JournalTableAdapter = new 期刊管理系统.JournalManagementDataSetTableAdapters.V_JournalTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_info = new System.Windows.Forms.ToolStripButton();
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.btn_del = new System.Windows.Forms.ToolStripButton();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vJournalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalManagementDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_chbox,
            this.journalidDataGridViewTextBoxColumn,
            this.journalnameDataGridViewTextBoxColumn,
            this.typeenameDataGridViewTextBoxColumn,
            this.publishernameDataGridViewTextBoxColumn,
            this.newpublishdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vJournalBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(948, 630);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_chbox
            // 
            this.col_chbox.HeaderText = "选择";
            this.col_chbox.Name = "col_chbox";
            this.col_chbox.Width = 45;
            // 
            // journalidDataGridViewTextBoxColumn
            // 
            this.journalidDataGridViewTextBoxColumn.DataPropertyName = "journal_id";
            this.journalidDataGridViewTextBoxColumn.HeaderText = "期刊号";
            this.journalidDataGridViewTextBoxColumn.Name = "journalidDataGridViewTextBoxColumn";
            this.journalidDataGridViewTextBoxColumn.ToolTipText = "期刊号";
            this.journalidDataGridViewTextBoxColumn.Width = 91;
            // 
            // journalnameDataGridViewTextBoxColumn
            // 
            this.journalnameDataGridViewTextBoxColumn.DataPropertyName = "journal_name";
            this.journalnameDataGridViewTextBoxColumn.HeaderText = "期刊名";
            this.journalnameDataGridViewTextBoxColumn.Name = "journalnameDataGridViewTextBoxColumn";
            this.journalnameDataGridViewTextBoxColumn.ToolTipText = "期刊名";
            this.journalnameDataGridViewTextBoxColumn.Width = 91;
            // 
            // typeenameDataGridViewTextBoxColumn
            // 
            this.typeenameDataGridViewTextBoxColumn.DataPropertyName = "typee_name";
            this.typeenameDataGridViewTextBoxColumn.HeaderText = "期刊类型名";
            this.typeenameDataGridViewTextBoxColumn.Name = "typeenameDataGridViewTextBoxColumn";
            this.typeenameDataGridViewTextBoxColumn.ToolTipText = "期刊类型名";
            this.typeenameDataGridViewTextBoxColumn.Width = 107;
            // 
            // publishernameDataGridViewTextBoxColumn
            // 
            this.publishernameDataGridViewTextBoxColumn.DataPropertyName = "publisher_name";
            this.publishernameDataGridViewTextBoxColumn.HeaderText = "出版社名";
            this.publishernameDataGridViewTextBoxColumn.Name = "publishernameDataGridViewTextBoxColumn";
            this.publishernameDataGridViewTextBoxColumn.ToolTipText = "出版社名";
            this.publishernameDataGridViewTextBoxColumn.Width = 91;
            // 
            // newpublishdateDataGridViewTextBoxColumn
            // 
            this.newpublishdateDataGridViewTextBoxColumn.DataPropertyName = "new_publish_date";
            this.newpublishdateDataGridViewTextBoxColumn.HeaderText = "最新出版日期";
            this.newpublishdateDataGridViewTextBoxColumn.Name = "newpublishdateDataGridViewTextBoxColumn";
            this.newpublishdateDataGridViewTextBoxColumn.ToolTipText = "最新出版日期";
            this.newpublishdateDataGridViewTextBoxColumn.Width = 107;
            // 
            // vJournalBindingSource
            // 
            this.vJournalBindingSource.DataMember = "V_Journal";
            this.vJournalBindingSource.DataSource = this.journalManagementDataSet;
            // 
            // journalManagementDataSet
            // 
            this.journalManagementDataSet.DataSetName = "JournalManagementDataSet";
            this.journalManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_JournalTableAdapter
            // 
            this.v_JournalTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_info,
            this.btn_add,
            this.btn_del,
            this.btn_search,
            this.btn_refresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_info
            // 
            this.btn_info.Image = ((System.Drawing.Image)(resources.GetObject("btn_info.Image")));
            this.btn_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(110, 28);
            this.btn_info.Text = "期刊详情";
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 28);
            this.btn_add.Text = "增加期刊";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(110, 28);
            this.btn_del.Text = "删除期刊";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(110, 28);
            this.btn_refresh.Text = "重置页面";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 28);
            this.btn_search.Text = "搜索期刊";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 630);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "期刊管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vJournalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalManagementDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private JournalManagementDataSet journalManagementDataSet;
        private System.Windows.Forms.BindingSource vJournalBindingSource;
        private JournalManagementDataSetTableAdapters.V_JournalTableAdapter v_JournalTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_info;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripButton btn_del;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_chbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn journalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn journalnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newpublishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btn_search;
    }
}

