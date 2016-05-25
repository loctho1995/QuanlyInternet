namespace QuanLyInternet
{
    partial class Form1
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
            if(disposing && (components != null))
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
            this.monoFlat_Button7 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button6 = new MonoFlat.MonoFlat_Button();
            this.lbPercentUnpaid = new Ambiance.Ambiance_Label();
            this.lbPercentPaid = new Ambiance.Ambiance_Label();
            this.btPercentPaid = new MonoFlat.MonoFlat_Button();
            this.btPercentUnpaid = new MonoFlat.MonoFlat_Button();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.chartPayment = new TaskManager.ChartControl();
            this.lbPercentWaiting = new Ambiance.Ambiance_Label();
            this.lbPercentUsing = new Ambiance.Ambiance_Label();
            this.lbPercentAbandoning = new Ambiance.Ambiance_Label();
            this.btPercentAbandoning = new MonoFlat.MonoFlat_Button();
            this.btPercentUsing = new MonoFlat.MonoFlat_Button();
            this.btPercentWaiting = new MonoFlat.MonoFlat_Button();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.chartCustomerStatus = new TaskManager.ChartControl();
            this.monoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button3 = new MonoFlat.MonoFlat_Button();
            this.SuspendLayout();
            // 
            // monoFlat_Button7
            // 
            this.monoFlat_Button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monoFlat_Button7.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button7.BorderInactiveColor = System.Drawing.Color.Empty;
            this.monoFlat_Button7.BorderPressedColor = System.Drawing.Color.Empty;
            this.monoFlat_Button7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button7.Image = null;
            this.monoFlat_Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button7.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.monoFlat_Button7.Location = new System.Drawing.Point(674, 12);
            this.monoFlat_Button7.Name = "monoFlat_Button7";
            this.monoFlat_Button7.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monoFlat_Button7.Size = new System.Drawing.Size(217, 147);
            this.monoFlat_Button7.TabIndex = 19;
            this.monoFlat_Button7.Text = "Quản lý gói cước";
            this.monoFlat_Button7.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button7.Click += new System.EventHandler(this.monoFlat_Button7_Click);
            // 
            // monoFlat_Button6
            // 
            this.monoFlat_Button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monoFlat_Button6.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button6.BorderInactiveColor = System.Drawing.Color.Empty;
            this.monoFlat_Button6.BorderPressedColor = System.Drawing.Color.Empty;
            this.monoFlat_Button6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button6.Image = null;
            this.monoFlat_Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button6.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.monoFlat_Button6.Location = new System.Drawing.Point(447, 12);
            this.monoFlat_Button6.Name = "monoFlat_Button6";
            this.monoFlat_Button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monoFlat_Button6.Size = new System.Drawing.Size(217, 147);
            this.monoFlat_Button6.TabIndex = 18;
            this.monoFlat_Button6.Text = "Báo cáo";
            this.monoFlat_Button6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbPercentUnpaid
            // 
            this.lbPercentUnpaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercentUnpaid.AutoSize = true;
            this.lbPercentUnpaid.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentUnpaid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPercentUnpaid.ForeColor = System.Drawing.Color.Black;
            this.lbPercentUnpaid.Location = new System.Drawing.Point(750, 323);
            this.lbPercentUnpaid.Name = "lbPercentUnpaid";
            this.lbPercentUnpaid.Size = new System.Drawing.Size(118, 20);
            this.lbPercentUnpaid.TabIndex = 16;
            this.lbPercentUnpaid.Text = "Chưa thanh toán";
            // 
            // lbPercentPaid
            // 
            this.lbPercentPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercentPaid.AutoSize = true;
            this.lbPercentPaid.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentPaid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPercentPaid.ForeColor = System.Drawing.Color.Black;
            this.lbPercentPaid.Location = new System.Drawing.Point(750, 267);
            this.lbPercentPaid.Name = "lbPercentPaid";
            this.lbPercentPaid.Size = new System.Drawing.Size(103, 20);
            this.lbPercentPaid.TabIndex = 15;
            this.lbPercentPaid.Text = "Đã thanh toán";
            // 
            // btPercentPaid
            // 
            this.btPercentPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPercentPaid.BackColor = System.Drawing.Color.Transparent;
            this.btPercentPaid.BorderInactiveColor = System.Drawing.Color.Empty;
            this.btPercentPaid.BorderPressedColor = System.Drawing.Color.Empty;
            this.btPercentPaid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPercentPaid.Image = null;
            this.btPercentPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPercentPaid.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPercentPaid.Location = new System.Drawing.Point(706, 260);
            this.btPercentPaid.Name = "btPercentPaid";
            this.btPercentPaid.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btPercentPaid.Size = new System.Drawing.Size(35, 35);
            this.btPercentPaid.TabIndex = 14;
            this.btPercentPaid.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btPercentUnpaid
            // 
            this.btPercentUnpaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPercentUnpaid.BackColor = System.Drawing.Color.Transparent;
            this.btPercentUnpaid.BorderInactiveColor = System.Drawing.Color.Empty;
            this.btPercentUnpaid.BorderPressedColor = System.Drawing.Color.Empty;
            this.btPercentUnpaid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPercentUnpaid.Image = null;
            this.btPercentUnpaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPercentUnpaid.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPercentUnpaid.Location = new System.Drawing.Point(706, 317);
            this.btPercentUnpaid.Name = "btPercentUnpaid";
            this.btPercentUnpaid.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btPercentUnpaid.Size = new System.Drawing.Size(35, 35);
            this.btPercentUnpaid.TabIndex = 12;
            this.btPercentUnpaid.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label5.ForeColor = System.Drawing.Color.Black;
            this.ambiance_Label5.Location = new System.Drawing.Point(598, 210);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(231, 30);
            this.ambiance_Label5.TabIndex = 11;
            this.ambiance_Label5.Text = "Tình trạng thanh toán";
            // 
            // chartPayment
            // 
            this.chartPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPayment.BackColor = System.Drawing.Color.Transparent;
            this.chartPayment.ColorAbandoning = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.chartPayment.ColorUsing = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.chartPayment.ColorWaiting = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.chartPayment.Location = new System.Drawing.Point(526, 260);
            this.chartPayment.Name = "chartPayment";
            this.chartPayment.PercentageInAbandoning = 0;
            this.chartPayment.PercentageUsing = 24;
            this.chartPayment.PercentageWaiting = 76;
            this.chartPayment.Size = new System.Drawing.Size(150, 150);
            this.chartPayment.TabIndex = 10;
            // 
            // lbPercentWaiting
            // 
            this.lbPercentWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPercentWaiting.AutoSize = true;
            this.lbPercentWaiting.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentWaiting.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPercentWaiting.ForeColor = System.Drawing.Color.Black;
            this.lbPercentWaiting.Location = new System.Drawing.Point(239, 390);
            this.lbPercentWaiting.Name = "lbPercentWaiting";
            this.lbPercentWaiting.Size = new System.Drawing.Size(71, 20);
            this.lbPercentWaiting.TabIndex = 9;
            this.lbPercentWaiting.Text = "Đang đợi";
            // 
            // lbPercentUsing
            // 
            this.lbPercentUsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPercentUsing.AutoSize = true;
            this.lbPercentUsing.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentUsing.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPercentUsing.ForeColor = System.Drawing.Color.Black;
            this.lbPercentUsing.Location = new System.Drawing.Point(239, 331);
            this.lbPercentUsing.Name = "lbPercentUsing";
            this.lbPercentUsing.Size = new System.Drawing.Size(102, 20);
            this.lbPercentUsing.TabIndex = 8;
            this.lbPercentUsing.Text = "Đang sử dụng";
            // 
            // lbPercentAbandoning
            // 
            this.lbPercentAbandoning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPercentAbandoning.AutoSize = true;
            this.lbPercentAbandoning.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentAbandoning.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPercentAbandoning.ForeColor = System.Drawing.Color.Black;
            this.lbPercentAbandoning.Location = new System.Drawing.Point(239, 275);
            this.lbPercentAbandoning.Name = "lbPercentAbandoning";
            this.lbPercentAbandoning.Size = new System.Drawing.Size(53, 20);
            this.lbPercentAbandoning.TabIndex = 7;
            this.lbPercentAbandoning.Text = "Bị treo";
            // 
            // btPercentAbandoning
            // 
            this.btPercentAbandoning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPercentAbandoning.BackColor = System.Drawing.Color.Transparent;
            this.btPercentAbandoning.BorderInactiveColor = System.Drawing.Color.Empty;
            this.btPercentAbandoning.BorderPressedColor = System.Drawing.Color.Empty;
            this.btPercentAbandoning.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPercentAbandoning.Image = null;
            this.btPercentAbandoning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPercentAbandoning.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPercentAbandoning.Location = new System.Drawing.Point(195, 268);
            this.btPercentAbandoning.Name = "btPercentAbandoning";
            this.btPercentAbandoning.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btPercentAbandoning.Size = new System.Drawing.Size(35, 35);
            this.btPercentAbandoning.TabIndex = 6;
            this.btPercentAbandoning.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btPercentUsing
            // 
            this.btPercentUsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPercentUsing.BackColor = System.Drawing.Color.Transparent;
            this.btPercentUsing.BorderInactiveColor = System.Drawing.Color.Empty;
            this.btPercentUsing.BorderPressedColor = System.Drawing.Color.Empty;
            this.btPercentUsing.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPercentUsing.Image = null;
            this.btPercentUsing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPercentUsing.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPercentUsing.Location = new System.Drawing.Point(195, 383);
            this.btPercentUsing.Name = "btPercentUsing";
            this.btPercentUsing.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btPercentUsing.Size = new System.Drawing.Size(35, 35);
            this.btPercentUsing.TabIndex = 5;
            this.btPercentUsing.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btPercentWaiting
            // 
            this.btPercentWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPercentWaiting.BackColor = System.Drawing.Color.Transparent;
            this.btPercentWaiting.BorderInactiveColor = System.Drawing.Color.Empty;
            this.btPercentWaiting.BorderPressedColor = System.Drawing.Color.Empty;
            this.btPercentWaiting.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPercentWaiting.Image = null;
            this.btPercentWaiting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPercentWaiting.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPercentWaiting.Location = new System.Drawing.Point(195, 325);
            this.btPercentWaiting.Name = "btPercentWaiting";
            this.btPercentWaiting.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btPercentWaiting.Size = new System.Drawing.Size(35, 35);
            this.btPercentWaiting.TabIndex = 4;
            this.btPercentWaiting.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label1.ForeColor = System.Drawing.Color.Black;
            this.ambiance_Label1.Location = new System.Drawing.Point(84, 218);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(233, 30);
            this.ambiance_Label1.TabIndex = 3;
            this.ambiance_Label1.Text = "Trạng thái khách hàng";
            // 
            // chartCustomerStatus
            // 
            this.chartCustomerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chartCustomerStatus.BackColor = System.Drawing.Color.Transparent;
            this.chartCustomerStatus.ColorAbandoning = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.chartCustomerStatus.ColorUsing = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.chartCustomerStatus.ColorWaiting = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.chartCustomerStatus.Location = new System.Drawing.Point(12, 268);
            this.chartCustomerStatus.Name = "chartCustomerStatus";
            this.chartCustomerStatus.PercentageInAbandoning = 33;
            this.chartCustomerStatus.PercentageUsing = 34;
            this.chartCustomerStatus.PercentageWaiting = 33;
            this.chartCustomerStatus.Size = new System.Drawing.Size(150, 150);
            this.chartCustomerStatus.TabIndex = 2;
            // 
            // monoFlat_Button2
            // 
            this.monoFlat_Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button2.BorderInactiveColor = System.Drawing.Color.Empty;
            this.monoFlat_Button2.BorderPressedColor = System.Drawing.Color.Empty;
            this.monoFlat_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button2.Image = null;
            this.monoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.monoFlat_Button2.Location = new System.Drawing.Point(263, 12);
            this.monoFlat_Button2.Name = "monoFlat_Button2";
            this.monoFlat_Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monoFlat_Button2.Size = new System.Drawing.Size(178, 73);
            this.monoFlat_Button2.TabIndex = 1;
            this.monoFlat_Button2.Text = "Hồ sơ khách hàng";
            this.monoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.BorderInactiveColor = System.Drawing.Color.Empty;
            this.monoFlat_Button1.BorderPressedColor = System.Drawing.Color.Empty;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.monoFlat_Button1.Location = new System.Drawing.Point(25, 12);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monoFlat_Button1.Size = new System.Drawing.Size(232, 73);
            this.monoFlat_Button1.TabIndex = 0;
            this.monoFlat_Button1.Text = "Đăng kí mới";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Button3
            // 
            this.monoFlat_Button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monoFlat_Button3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button3.BorderInactiveColor = System.Drawing.Color.Empty;
            this.monoFlat_Button3.BorderPressedColor = System.Drawing.Color.Empty;
            this.monoFlat_Button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button3.Image = null;
            this.monoFlat_Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button3.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.monoFlat_Button3.Location = new System.Drawing.Point(25, 91);
            this.monoFlat_Button3.Name = "monoFlat_Button3";
            this.monoFlat_Button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monoFlat_Button3.Size = new System.Drawing.Size(416, 73);
            this.monoFlat_Button3.TabIndex = 20;
            this.monoFlat_Button3.Text = "Chương trình khuyến mãi";
            this.monoFlat_Button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button3.Click += new System.EventHandler(this.monoFlat_Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 498);
            this.Controls.Add(this.monoFlat_Button3);
            this.Controls.Add(this.monoFlat_Button7);
            this.Controls.Add(this.monoFlat_Button6);
            this.Controls.Add(this.lbPercentUnpaid);
            this.Controls.Add(this.lbPercentPaid);
            this.Controls.Add(this.btPercentPaid);
            this.Controls.Add(this.btPercentUnpaid);
            this.Controls.Add(this.ambiance_Label5);
            this.Controls.Add(this.chartPayment);
            this.Controls.Add(this.lbPercentWaiting);
            this.Controls.Add(this.lbPercentUsing);
            this.Controls.Add(this.lbPercentAbandoning);
            this.Controls.Add(this.btPercentAbandoning);
            this.Controls.Add(this.btPercentUsing);
            this.Controls.Add(this.btPercentWaiting);
            this.Controls.Add(this.ambiance_Label1);
            this.Controls.Add(this.chartCustomerStatus);
            this.Controls.Add(this.monoFlat_Button2);
            this.Controls.Add(this.monoFlat_Button1);
            this.Name = "Form1";
            this.Text = "Quản lý đăng kí Internet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_Button monoFlat_Button2;
        private TaskManager.ChartControl chartCustomerStatus;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private MonoFlat.MonoFlat_Button btPercentWaiting;
        private MonoFlat.MonoFlat_Button btPercentUsing;
        private MonoFlat.MonoFlat_Button btPercentAbandoning;
        private Ambiance.Ambiance_Label lbPercentAbandoning;
        private Ambiance.Ambiance_Label lbPercentUsing;
        private Ambiance.Ambiance_Label lbPercentWaiting;
        private Ambiance.Ambiance_Label lbPercentUnpaid;
        private Ambiance.Ambiance_Label lbPercentPaid;
        private MonoFlat.MonoFlat_Button btPercentPaid;
        private MonoFlat.MonoFlat_Button btPercentUnpaid;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private TaskManager.ChartControl chartPayment;
        private MonoFlat.MonoFlat_Button monoFlat_Button6;
        private MonoFlat.MonoFlat_Button monoFlat_Button7;
        private MonoFlat.MonoFlat_Button monoFlat_Button3;

    }
}

