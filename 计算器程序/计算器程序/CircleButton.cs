using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace 计算器程序
{

    [DesignTimeVisible(true)]
    public partial class CircleButton : Button
    {
        // bg灰：#A6A6A6， 橙色 #FF9501
        public CircleButton()
        {
            InitializeComponent();
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // 抗锯齿
            pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            pevent.Graphics.FillEllipse(new SolidBrush(this.BackColor), 0, 0, this.Width * 4/5 , this.Width*4/5);
            // 对齐
            StringFormat formatHorizontal = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            formatHorizontal.LineAlignment = StringAlignment.Center;
            formatHorizontal.Alignment = StringAlignment.Center;
            pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new PointF(this.Width*3/10, this.Width*3/10), formatHorizontal);
        }
    }

}
