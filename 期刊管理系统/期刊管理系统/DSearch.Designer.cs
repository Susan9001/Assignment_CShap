namespace 期刊管理系统
{
    partial class DSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSearch));
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_publisher = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_publisher = new System.Windows.Forms.TextBox();
            this.tbox_type = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_yes
            // 
            this.btn_yes.Image = ((System.Drawing.Image)(resources.GetObject("btn_yes.Image")));
            this.btn_yes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yes.Location = new System.Drawing.Point(275, 245);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(129, 37);
            this.btn_yes.TabIndex = 10;
            this.btn_yes.Text = "   确认";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(443, 245);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(122, 37);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "   取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(51, 40);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(116, 18);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "按期刊名搜索";
            this.label_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(51, 102);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(98, 18);
            this.label_type.TabIndex = 12;
            this.label_type.Text = "按类型搜索";
            // 
            // label_publisher
            // 
            this.label_publisher.AutoSize = true;
            this.label_publisher.Location = new System.Drawing.Point(51, 177);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(98, 18);
            this.label_publisher.TabIndex = 13;
            this.label_publisher.Text = "按出版社搜";
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(211, 40);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(354, 28);
            this.tbox_name.TabIndex = 14;
            // 
            // tbox_publisher
            // 
            this.tbox_publisher.Location = new System.Drawing.Point(211, 167);
            this.tbox_publisher.Name = "tbox_publisher";
            this.tbox_publisher.Size = new System.Drawing.Size(354, 28);
            this.tbox_publisher.TabIndex = 15;
            // 
            // tbox_type
            // 
            this.tbox_type.Location = new System.Drawing.Point(211, 99);
            this.tbox_type.Name = "tbox_type";
            this.tbox_type.Size = new System.Drawing.Size(354, 28);
            this.tbox_type.TabIndex = 16;
            // 
            // DSearch
            // 
            this.AcceptButton = this.btn_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(599, 324);
            this.Controls.Add(this.tbox_type);
            this.Controls.Add(this.tbox_publisher);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label_publisher);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DSearch";
            this.Text = "搜索期刊";
            this.Load += new System.EventHandler(this.DSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_publisher;
        private System.Windows.Forms.TextBox tbox_type;
    }
}