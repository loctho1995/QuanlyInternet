using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class ChartControl:UserControl
    {
        public ChartControl()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
            this.BackColor = Color.Transparent;

            PercentageWaiting = 33;
            PercentageInAbandoning = 33;
            PercentageUsing = 33;

            ColorWaiting = Color.FromArgb(255, Color.FromArgb(0x2ECC71));
            ColorUsing = Color.FromArgb(255, Color.FromArgb(0xE9D460));
            ColorAbandoning = Color.FromArgb(255, Color.FromArgb(0xF64747));

            RefreshDataAndPaint();
        }

        public int PercentageWaiting
        { get; set; }

        public int PercentageUsing
        { get; set; }

        public int PercentageInAbandoning
        { get; set; }

        public Color ColorWaiting
        { get; set; }

        public Color ColorUsing
        { get; set; }

        public Color ColorAbandoning
        { get; set; }

        int degreeWaiting, degreeUsing, degreeAbandoning;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if(degreeWaiting != 0)
            {
                e.Graphics.FillPie(new SolidBrush(ColorWaiting), this.ClientRectangle, -90, degreeWaiting);
            }

            if(degreeUsing != 0)
            {
                e.Graphics.FillPie(new SolidBrush(ColorUsing), this.ClientRectangle, degreeWaiting - 90, degreeUsing);
            }

            if(degreeAbandoning != 0)
            {
                e.Graphics.FillPie(new SolidBrush(ColorAbandoning), this.ClientRectangle, degreeUsing + degreeWaiting - 90, degreeAbandoning);
            }

            base.OnPaint(e);
        }

        public void RefreshDataAndPaint()
        {
            if(PercentageWaiting == 0 || PercentageUsing == 0 || PercentageInAbandoning == 0)
            {
                if(PercentageInAbandoning == 0)
                {
                    degreeAbandoning = 0;
                    degreeUsing = GetDegreeByPercent(PercentageUsing);
                    degreeWaiting = 360 - degreeUsing;
                }
                else if(PercentageUsing == 0)
                {
                    degreeUsing = 0;
                    degreeWaiting = GetDegreeByPercent(PercentageWaiting);
                    degreeAbandoning = 360 - degreeWaiting;
                }
                else
                {
                    degreeWaiting = 0;
                    degreeAbandoning = GetDegreeByPercent(PercentageInAbandoning);
                    degreeUsing = 100 - degreeAbandoning;
                }
            }
            else
            {
                degreeWaiting = GetDegreeByPercent(PercentageWaiting);
                degreeUsing = GetDegreeByPercent(PercentageUsing);
                degreeAbandoning = 360 - degreeWaiting - degreeUsing;
            }
            
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            if(this.ClientRectangle.Width > this.ClientRectangle.Height)
            {
                this.Width = this.Height;
            }
            else
            {
                this.Height = this.Width;
            }

            base.OnResize(e);
        }

        int GetDegreeByPercent(int percent)
        {
            return (int)(3.6 * percent);
        }
    }
}
