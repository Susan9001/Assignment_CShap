namespace 期刊管理系统
{
    partial class DJournalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DJournalInfo));
            this.label_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.tbox_publish_date = new System.Windows.Forms.TextBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.cmbox_cat = new System.Windows.Forms.ComboBox();
            this.cmbox_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(35, 100);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 18);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "编号";
            this.label_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "编目";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "出版日期";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(343, 148);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(44, 18);
            this.label_type.TabIndex = 5;
            this.label_type.Text = "类别";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(343, 100);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 18);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "名称";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(445, 274);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(122, 37);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "   取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Image = ((System.Drawing.Image)(resources.GetObject("btn_yes.Image")));
            this.btn_yes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yes.Location = new System.Drawing.Point(277, 274);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(129, 37);
            this.btn_yes.TabIndex = 8;
            this.btn_yes.Text = "   确认";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_info.Location = new System.Drawing.Point(226, 36);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(128, 28);
            this.label_info.TabIndex = 9;
            this.label_info.Text = "期刊详情";
            this.label_info.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbox_id
            // 
            this.tbox_id.Location = new System.Drawing.Point(137, 100);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.ReadOnly = true;
            this.tbox_id.Size = new System.Drawing.Size(144, 28);
            this.tbox_id.TabIndex = 10;
            // 
            // tbox_publish_date
            // 
            this.tbox_publish_date.Location = new System.Drawing.Point(137, 199);
            this.tbox_publish_date.Name = "tbox_publish_date";
            this.tbox_publish_date.Size = new System.Drawing.Size(275, 28);
            this.tbox_publish_date.TabIndex = 11;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(425, 97);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(142, 28);
            this.tbox_name.TabIndex = 12;
            // 
            // cmbox_cat
            // 
            this.cmbox_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_cat.FormattingEnabled = true;
            this.cmbox_cat.Location = new System.Drawing.Point(137, 148);
            this.cmbox_cat.Name = "cmbox_cat";
            this.cmbox_cat.Size = new System.Drawing.Size(144, 26);
            this.cmbox_cat.TabIndex = 13;
            this.cmbox_cat.SelectedIndexChanged += new System.EventHandler(this.cmbox_cat_SelectedIndexChanged);
            // 
            // cmbox_type
            // 
            this.cmbox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_type.FormattingEnabled = true;
            this.cmbox_type.Location = new System.Drawing.Point(425, 145);
            this.cmbox_type.Name = "cmbox_type";
            this.cmbox_type.Size = new System.Drawing.Size(142, 26);
            this.cmbox_type.TabIndex = 14;
            // 
            // DJournalInfo
            // 
            this.AcceptButton = this.btn_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(614, 341);
            this.Controls.Add(this.cmbox_type);
            this.Controls.Add(this.cmbox_cat);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.tbox_publish_date);
            this.Controls.Add(this.tbox_id);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DJournalInfo";
            this.Text = "期刊详情";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Label label_info;
        protected System.Windows.Forms.TextBox tbox_id;
        protected System.Windows.Forms.TextBox tbox_publish_date;
        protected System.Windows.Forms.TextBox tbox_name;
        protected System.Windows.Forms.ComboBox cmbox_cat;
        protected System.Windows.Forms.ComboBox cmbox_type;
    }
}