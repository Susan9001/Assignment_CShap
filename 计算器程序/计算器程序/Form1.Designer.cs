using System.Windows.Forms;

namespace 计算器程序
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

        private TextBox textBox1;
        private CircleButton btn_ac;
        private CircleButton btn_bef;
        private CircleButton btn_percent;
        private CircleButton btn_div;
        private CircleButton btn_mul;
        private CircleButton btn_9;
        private CircleButton btn_8;
        private CircleButton btn_7;
        private CircleButton btn_sub;
        private CircleButton btn_6;
        private CircleButton btn_5;
        private CircleButton btn_4;
        private CircleButton btn_add;
        private CircleButton btn_3;
        private CircleButton btn_2;
        private CircleButton btn_1;
        private CircleButton btn_equ;
        private CircleButton btn_dot;
        private CircleButton btn_0;
    }
}

