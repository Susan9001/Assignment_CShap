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
            this.circleButton3 = new 计算器程序.CircleButton();
            this.circleButton4 = new 计算器程序.CircleButton();
            this.circleButton5 = new 计算器程序.CircleButton();
            this.circleButton6 = new 计算器程序.CircleButton();
            this.circleButton7 = new 计算器程序.CircleButton();
            this.circleButton8 = new 计算器程序.CircleButton();
            this.circleButton9 = new 计算器程序.CircleButton();
            this.circleButton10 = new 计算器程序.CircleButton();
            this.circleButton11 = new 计算器程序.CircleButton();
            this.circleButton12 = new 计算器程序.CircleButton();
            this.circleButton13 = new 计算器程序.CircleButton();
            this.circleButton14 = new 计算器程序.CircleButton();
            this.circleButton15 = new 计算器程序.CircleButton();
            this.btn_equ = new 计算器程序.CircleButton();
            this.circleButton17 = new 计算器程序.CircleButton();
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
            // 
            // circleButton3
            // 
            this.circleButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.circleButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton3.Location = new System.Drawing.Point(286, 121);
            this.circleButton3.Name = "circleButton3";
            this.circleButton3.Size = new System.Drawing.Size(79, 63);
            this.circleButton3.TabIndex = 4;
            this.circleButton3.Text = "÷";
            this.circleButton3.UseVisualStyleBackColor = false;
            // 
            // circleButton4
            // 
            this.circleButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.circleButton4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton4.Location = new System.Drawing.Point(285, 201);
            this.circleButton4.Name = "circleButton4";
            this.circleButton4.Size = new System.Drawing.Size(80, 63);
            this.circleButton4.TabIndex = 8;
            this.circleButton4.Text = "×";
            this.circleButton4.UseVisualStyleBackColor = false;
            // 
            // circleButton5
            // 
            this.circleButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton5.Location = new System.Drawing.Point(195, 201);
            this.circleButton5.Name = "circleButton5";
            this.circleButton5.Size = new System.Drawing.Size(77, 63);
            this.circleButton5.TabIndex = 7;
            this.circleButton5.Text = "9";
            this.circleButton5.UseVisualStyleBackColor = false;
            // 
            // circleButton6
            // 
            this.circleButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton6.Location = new System.Drawing.Point(102, 201);
            this.circleButton6.Name = "circleButton6";
            this.circleButton6.Size = new System.Drawing.Size(82, 63);
            this.circleButton6.TabIndex = 6;
            this.circleButton6.Text = "8";
            this.circleButton6.UseVisualStyleBackColor = false;
            // 
            // circleButton7
            // 
            this.circleButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton7.Location = new System.Drawing.Point(12, 201);
            this.circleButton7.Name = "circleButton7";
            this.circleButton7.Size = new System.Drawing.Size(79, 63);
            this.circleButton7.TabIndex = 5;
            this.circleButton7.Text = "7";
            this.circleButton7.UseVisualStyleBackColor = false;
            // 
            // circleButton8
            // 
            this.circleButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.circleButton8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton8.Location = new System.Drawing.Point(285, 277);
            this.circleButton8.Name = "circleButton8";
            this.circleButton8.Size = new System.Drawing.Size(80, 61);
            this.circleButton8.TabIndex = 12;
            this.circleButton8.Text = "－";
            this.circleButton8.UseVisualStyleBackColor = false;
            // 
            // circleButton9
            // 
            this.circleButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton9.Location = new System.Drawing.Point(195, 277);
            this.circleButton9.Name = "circleButton9";
            this.circleButton9.Size = new System.Drawing.Size(77, 61);
            this.circleButton9.TabIndex = 11;
            this.circleButton9.Text = "6";
            this.circleButton9.UseVisualStyleBackColor = false;
            // 
            // circleButton10
            // 
            this.circleButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton10.Location = new System.Drawing.Point(102, 277);
            this.circleButton10.Name = "circleButton10";
            this.circleButton10.Size = new System.Drawing.Size(82, 61);
            this.circleButton10.TabIndex = 10;
            this.circleButton10.Text = "5";
            this.circleButton10.UseVisualStyleBackColor = false;
            // 
            // circleButton11
            // 
            this.circleButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton11.Location = new System.Drawing.Point(11, 277);
            this.circleButton11.Name = "circleButton11";
            this.circleButton11.Size = new System.Drawing.Size(79, 61);
            this.circleButton11.TabIndex = 9;
            this.circleButton11.Text = "4";
            this.circleButton11.UseVisualStyleBackColor = false;
            // 
            // circleButton12
            // 
            this.circleButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.circleButton12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton12.Location = new System.Drawing.Point(285, 355);
            this.circleButton12.Name = "circleButton12";
            this.circleButton12.Size = new System.Drawing.Size(80, 67);
            this.circleButton12.TabIndex = 16;
            this.circleButton12.Text = "＋";
            this.circleButton12.UseVisualStyleBackColor = false;
            // 
            // circleButton13
            // 
            this.circleButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton13.Location = new System.Drawing.Point(195, 355);
            this.circleButton13.Name = "circleButton13";
            this.circleButton13.Size = new System.Drawing.Size(77, 67);
            this.circleButton13.TabIndex = 15;
            this.circleButton13.Text = "3";
            this.circleButton13.UseVisualStyleBackColor = false;
            // 
            // circleButton14
            // 
            this.circleButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton14.Location = new System.Drawing.Point(102, 355);
            this.circleButton14.Name = "circleButton14";
            this.circleButton14.Size = new System.Drawing.Size(82, 67);
            this.circleButton14.TabIndex = 14;
            this.circleButton14.Text = "2";
            this.circleButton14.UseVisualStyleBackColor = false;
            // 
            // circleButton15
            // 
            this.circleButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton15.Location = new System.Drawing.Point(11, 355);
            this.circleButton15.Name = "circleButton15";
            this.circleButton15.Size = new System.Drawing.Size(79, 67);
            this.circleButton15.TabIndex = 13;
            this.circleButton15.Text = "1";
            this.circleButton15.UseVisualStyleBackColor = false;
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
            this.btn_equ.Click += new System.EventHandler(this.equ_clicked);
            // 
            // circleButton17
            // 
            this.circleButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circleButton17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleButton17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.circleButton17.Location = new System.Drawing.Point(196, 438);
            this.circleButton17.Name = "circleButton17";
            this.circleButton17.Size = new System.Drawing.Size(76, 63);
            this.circleButton17.TabIndex = 17;
            this.circleButton17.Text = ".";
            this.circleButton17.UseVisualStyleBackColor = false;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btn_0.Location = new System.Drawing.Point(12, 434);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(79, 67);
            this.btn_0.TabIndex = 19;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(389, 555);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_equ);
            this.Controls.Add(this.circleButton17);
            this.Controls.Add(this.circleButton12);
            this.Controls.Add(this.circleButton13);
            this.Controls.Add(this.circleButton14);
            this.Controls.Add(this.circleButton15);
            this.Controls.Add(this.circleButton8);
            this.Controls.Add(this.circleButton9);
            this.Controls.Add(this.circleButton10);
            this.Controls.Add(this.circleButton11);
            this.Controls.Add(this.circleButton4);
            this.Controls.Add(this.circleButton5);
            this.Controls.Add(this.circleButton6);
            this.Controls.Add(this.circleButton7);
            this.Controls.Add(this.circleButton3);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_bef);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void equ_clicked(object sender, EventArgs e)
        {

        }

        char Procede(char c1, char c2)
        { // c1-栈顶; c2-输入
            switch (c1)
            {
                case '+':
                case '-':
                    switch (c2)
                    {
                        case '+':
                        case '-':
                        case '#':
                            return '>';
                        case '*':
                        case '/':
                            return '<';
                    }
                    break;
                case '*':
                case '/':
                    switch (c2)
                    {
                        case '+':
                        case '-':
                        case '#':
                        case '*':
                        case '/':
                            return '>';
                    }
                    break;
                case '#':
                    switch (c2)
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                            return '<';
                        case '#':
                            return '=';
                    }
                    break;
            }
            // ERROR
            return '!';
        }

        int EvaluateExpression()
        {
            Stack<string> OPTR = new Stack<string>(); // Operator
            Stack<string> OPND = new Stack<string>(); // Num
            int i = 0; // 当前指向inputs的string
            string currStr;
            int elemC, a, b, temp = 0;

            OPTR.Push('#');
            //getchar();
            currStr = inputs[i];
            while (currStr != "#" || OPTR.Peek() != "#")
            {
                if (isNum(currStr))
                {
                    OPND.Push(currStr);
                    i++;
                    //getchar();
                }
                else
                {
                    switch (Procede(Convert.ToChar(OPTR.Peek()), Convert.ToChar(currStr)))
                    {
                        case '<': //输入的优先级更高
                            Push(OPTR, c);
                            c = getchar();
                            //getchar();
                            break;
                        case '=': //消括号
                            Pop(OPTR, temp);
                            c = getchar();
                            //getchar();
                            putchar(c);
                            break;
                        case '>': //栈头的优先级更高
                            Pop(OPND, b);
                            Pop(OPND, a);
                            Pop(OPTR, temp);
                            Push(OPND, Operate(a, (char)temp, b));
                            //printf("结果：%d\n", Operate(a, (char)temp, b));
                            break;
                    }
                    //printf("符号Top = %c\n", GetTop(OPTR));
                } //else
            } //while

            return GetTop(OPND);
        }
    }
