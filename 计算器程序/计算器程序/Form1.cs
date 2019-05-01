using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器程序
{
    public partial class Form1 : Form
    {
        private string[] inputs;
        private bool newOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_percent = new 计算器程序.CircleButton();
            this.btn_bef = new 计算器程序.CircleButton();
            this.btn_ac = new 计算器程序.CircleButton();
            this.btn_div = new 计算器程序.CircleButton();
            this.btn_mul = new 计算器程序.CircleButton();
            this.btn_9 = new 计算器程序.CircleButton();
            this.btn_8 = new 计算器程序.CircleButton();
            this.btn_7 = new 计算器程序.CircleButton();
            this.btn_sub = new 计算器程序.CircleButton();
            this.btn_6 = new 计算器程序.CircleButton();
            this.btn_5 = new 计算器程序.CircleButton();
            this.btn_4 = new 计算器程序.CircleButton();
            this.btn_add = new 计算器程序.CircleButton();
            this.btn_3 = new 计算器程序.CircleButton();
            this.btn_2 = new 计算器程序.CircleButton();
            this.btn_1 = new 计算器程序.CircleButton();
            this.btn_equ = new 计算器程序.CircleButton();
            this.btn_dot = new 计算器程序.CircleButton();
            this.btn_0 = new 计算器程序.CircleButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 55);
            this.textBox1.TabIndex = 0;
            // 
            // btn_percent
            // 
            this.btn_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_percent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_percent.Location = new System.Drawing.Point(195, 121);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(77, 63);
            this.btn_percent.TabIndex = 3;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = false;
            this.btn_percent.Click += new System.EventHandler(this.btnOptr_click);
            // 
            // btn_bef
            // 
            this.btn_bef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_bef.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_bef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_bef.Location = new System.Drawing.Point(103, 121);
            this.btn_bef.Name = "btn_bef";
            this.btn_bef.Size = new System.Drawing.Size(82, 63);
            this.btn_bef.TabIndex = 2;
            this.btn_bef.Text = "+/-";
            this.btn_bef.UseVisualStyleBackColor = false;
            // 
            // btn_ac
            // 
            this.btn_ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_ac.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_ac.Location = new System.Drawing.Point(12, 121);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(79, 63);
            this.btn_ac.TabIndex = 1;
            this.btn_ac.Text = "AC";
            this.btn_ac.UseVisualStyleBackColor = false;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btn_div.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_div.Location = new System.Drawing.Point(286, 121);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(79, 63);
            this.btn_div.TabIndex = 4;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btnOptr_click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btn_mul.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_mul.Location = new System.Drawing.Point(285, 201);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(80, 63);
            this.btn_mul.TabIndex = 8;
            this.btn_mul.Text = "×";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btnOptr_click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_9.Location = new System.Drawing.Point(195, 201);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(77, 63);
            this.btn_9.TabIndex = 7;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_8.Location = new System.Drawing.Point(102, 201);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(82, 63);
            this.btn_8.TabIndex = 6;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_7.Location = new System.Drawing.Point(12, 201);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(79, 63);
            this.btn_7.TabIndex = 5;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btn_sub.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_sub.Location = new System.Drawing.Point(285, 277);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(80, 61);
            this.btn_sub.TabIndex = 12;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btnOptr_click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_6.Location = new System.Drawing.Point(195, 277);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(77, 61);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_5.Location = new System.Drawing.Point(102, 277);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(82, 61);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_4.Location = new System.Drawing.Point(11, 277);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(79, 61);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btn_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_add.Location = new System.Drawing.Point(285, 355);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 67);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btnOptr_click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_3.Location = new System.Drawing.Point(195, 355);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(77, 67);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_2.Location = new System.Drawing.Point(102, 355);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(82, 67);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_1.Location = new System.Drawing.Point(11, 355);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(79, 67);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn_equ
            // 
            this.btn_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btn_equ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_equ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_equ.Location = new System.Drawing.Point(286, 438);
            this.btn_equ.Name = "btn_equ";
            this.btn_equ.Size = new System.Drawing.Size(79, 63);
            this.btn_equ.TabIndex = 18;
            this.btn_equ.Text = "=";
            this.btn_equ.UseVisualStyleBackColor = false;
            this.btn_equ.Click += new System.EventHandler(this.btnOptr_click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_dot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_dot.Location = new System.Drawing.Point(196, 438);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(76, 63);
            this.btn_dot.TabIndex = 17;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_0.Location = new System.Drawing.Point(12, 434);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(79, 67);
            this.btn_0.TabIndex = 19;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(389, 555);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_equ);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_bef);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnNum_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void equ_clicked(object sender, EventArgs e)
        {

        }

        string Procede(string c1, string c2)
        { // c1-栈顶; c2-输入
            switch (c1)
            {
                case "+":
                case "-":
                    switch (c2)
                    {
                        case "+": case "-": case "#":
                            return ">";
                        case "*": case "/":
                            return "<";
                    }
                    break;
                case "*":
                case "/":
                    switch (c2)
                    {
                        case "+": case "-": case "#":case "*": case "/":
                            return ">";
                    }
                    break;
                case "#":
                    switch (c2)
                    {
                        case "+":case "-":case "*":case "/":
                            return "<";
                        case "#":
                            return "=";
                    }
                    break;
            }
            // ERROR
            return "!";
        }

        string EvaluateExpression()
        {
            Stack<string> OPTR = new Stack<string>(); // Operator
            Stack<string> OPND = new Stack<string>(); // Num
            int i = 0; // 当前指向inputs的string
            string currStr;
            string a, b, temp;

            OPTR.Push("#");
            //getchar();
            currStr = inputs[i];
            while (currStr != "#" || OPTR.Peek() != "#")
            {
                if (isNum(currStr))
                {
                    OPND.Push(currStr);
                    i++;
                }
                else
                {
                    switch (Procede(OPTR.Peek(), (currStr)))
                    {
                        case "<": //输入的优先级更高
                            OPTR.Push(currStr);
                            i++;
                            break;
                        case "=": //消括号
                            OPTR.Pop();
                            i++;
                            break;
                        case ">": //栈头的优先级更高
                            b = OPND.Pop();
                            a = OPND.Pop();
                            temp = OPTR.Pop();
                            OPND.Push(Operate(a, temp, b));
                            break;
                    }
                    //printf("符号Top = %c\n", GetTop(OPTR));
                } //else
                currStr = inputs[i];
            } //while

            return OPND.Pop();
        }

        private bool isNum(string str)
        {
            try
            {
                Convert.ToDouble(str);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        private string Operate(string a, string optr, string b)
        {
            optr = optr.Trim();
            double aa = Convert.ToDouble(a);
            double bb = Convert.ToDouble(b);
            switch(optr)
            {
                case "+": return (aa + bb).ToString();
                case "-": return (aa - bb).ToString();
                case "*": return (aa * bb).ToString();
                case "/": return (aa / bb).ToString();

            }
            return "ERROR"; // ERROR
        }

        private string Operate(string a, string optr)
        {
            optr = optr.Trim();
            try
            {
                double aa = Convert.ToDouble(a);
                switch (optr)
                {
                    case "%": return (aa / 100).ToString();
                    default: return "ERROR";
                }
            }
            catch (Exception e)
            {
                return "ERROR";
            }
        }

        private void btnOptr_click(object sender, EventArgs e)
        {
            string optr = ((Button)sender).Text;
            if (optr == "%")
            {
                textBox1.Text = Operate(textBox1.Text, optr);
            }
            intoInputs(this.textBox1.Text); // 放入缓存

            string result = this.textBox1.Text;
            switch(optr)
            {
                case "%": break;
                case "÷": intoInputs("/"); break;
                case "×": intoInputs("*"); break;
                case "＋": intoInputs("+"); break;
                case "－": intoInputs("-"); break;
                case "=":
                    intoInputs("#");
                    result = EvaluateExpression();
                    inputs = new string[] { result }; // 清空
                    break;
                default: intoInputs(optr); break;
            }
            this.textBox1.Text = result;
            newOperation = true;
        }

        private void intoInputs(string str)
        {
            try
            {
                List<string> lstr = inputs.ToList();
                lstr.Add(str);
                inputs = lstr.ToArray();
            }
            catch(System.Exception ex)
            {
                inputs = new string[] { str };
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (!hasDot()) this.textBox1.Text += ".";

        }
        
        private bool hasDot()
        {
            return (this.textBox1.Text.Contains("."));
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (newOperation)
            {
                this.textBox1.Text = ((Button)sender).Text;
                this.newOperation = false;
            }
            else
                this.textBox1.Text += ((Button)sender).Text;
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Array.Clear(inputs, 0, inputs.Length);
        }

    }
}

