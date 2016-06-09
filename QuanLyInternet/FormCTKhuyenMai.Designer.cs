namespace QuanLyInternet
{
    partial class FormCTKhuyenMai
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
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambiance_TextBox1 = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.cbbGoiCuoc = new Ambiance.Ambiance_ComboBox();
            this.ambiance_Label6 = new Ambiance.Ambiance_Label();
            this.ambiance_TextBox2 = new Ambiance.Ambiance_TextBox();
            this.btOK = new Ambiance.Ambiance_Button_1();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            this.SuspendLayout();
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(12, 18);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(71, 20);
            this.ambiance_Label1.TabIndex = 0;
            this.ambiance_Label1.Text = "Nội dung";
            // 
            // ambiance_TextBox1
            // 
            this.ambiance_TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ambiance_TextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox1.Location = new System.Drawing.Point(140, 12);
            this.ambiance_TextBox1.MaxLength = 32767;
            this.ambiance_TextBox1.Multiline = false;
            this.ambiance_TextBox1.Name = "ambiance_TextBox1";
            this.ambiance_TextBox1.ReadOnly = false;
            this.ambiance_TextBox1.Size = new System.Drawing.Size(458, 28);
            this.ambiance_TextBox1.TabIndex = 1;
            this.ambiance_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ambiance_TextBox1.UseSystemPasswordChar = false;
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(12, 52);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(62, 20);
            this.ambiance_Label2.TabIndex = 2;
            this.ambiance_Label2.Text = "Từ ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(438, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(354, 52);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(72, 20);
            this.ambiance_Label3.TabIndex = 4;
            this.ambiance_Label3.Text = "Đến ngày";
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label5.Location = new System.Drawing.Point(354, 91);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(68, 20);
            this.ambiance_Label5.TabIndex = 8;
            this.ambiance_Label5.Text = "Gói cước";
            // 
            // cbbGoiCuoc
            // 
            this.cbbGoiCuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbbGoiCuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGoiCuoc.DropDownHeight = 100;
            this.cbbGoiCuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGoiCuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGoiCuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cbbGoiCuoc.FormattingEnabled = true;
            this.cbbGoiCuoc.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cbbGoiCuoc.IntegralHeight = false;
            this.cbbGoiCuoc.ItemHeight = 20;
            this.cbbGoiCuoc.Items.AddRange(new object[] {
            "1"});
            this.cbbGoiCuoc.Location = new System.Drawing.Point(438, 90);
            this.cbbGoiCuoc.Name = "cbbGoiCuoc";
            this.cbbGoiCuoc.Size = new System.Drawing.Size(160, 26);
            this.cbbGoiCuoc.StartIndex = 0;
            this.cbbGoiCuoc.TabIndex = 9;
            // 
            // ambiance_Label6
            // 
            this.ambiance_Label6.AutoSize = true;
            this.ambiance_Label6.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label6.Location = new System.Drawing.Point(12, 96);
            this.ambiance_Label6.Name = "ambiance_Label6";
            this.ambiance_Label6.Size = new System.Drawing.Size(108, 20);
            this.ambiance_Label6.TabIndex = 10;
            this.ambiance_Label6.Text = "Phí đăng kí KM";
            // 
            // ambiance_TextBox2
            // 
            this.ambiance_TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ambiance_TextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox2.Location = new System.Drawing.Point(141, 96);
            this.ambiance_TextBox2.MaxLength = 32767;
            this.ambiance_TextBox2.Multiline = false;
            this.ambiance_TextBox2.Name = "ambiance_TextBox2";
            this.ambiance_TextBox2.ReadOnly = false;
            this.ambiance_TextBox2.Size = new System.Drawing.Size(159, 28);
            this.ambiance_TextBox2.TabIndex = 11;
            this.ambiance_TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ambiance_TextBox2.UseSystemPasswordChar = false;
            this.ambiance_TextBox2.TextChanged += new System.EventHandler(this.ambiance_TextBox2_TextChanged);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Transparent;
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btOK.Image = null;
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOK.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btOK.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btOK.Location = new System.Drawing.Point(394, 172);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(91, 38);
            this.btOK.TabIndex = 40;
            this.btOK.Text = "Hoàn tất";
            this.btOK.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ambiance_Button_11.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ambiance_Button_11.Location = new System.Drawing.Point(510, 172);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(91, 38);
            this.ambiance_Button_11.TabIndex = 41;
            this.ambiance_Button_11.Text = "Thoát";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_11.Click += new System.EventHandler(this.ambiance_Button_11_Click);
            // 
            // FormCTKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 227);
            this.Controls.Add(this.ambiance_Button_11);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.ambiance_TextBox2);
            this.Controls.Add(this.ambiance_Label6);
            this.Controls.Add(this.cbbGoiCuoc);
            this.Controls.Add(this.ambiance_Label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ambiance_Label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ambiance_Label2);
            this.Controls.Add(this.ambiance_TextBox1);
            this.Controls.Add(this.ambiance_Label1);
            this.Name = "FormCTKhuyenMai";
            this.Text = "Chương trình khuyến mãi";
            this.Load += new System.EventHandler(this.FormCTKhuyenMai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_TextBox ambiance_TextBox1;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Ambiance.Ambiance_Label ambiance_Label3;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private Ambiance.Ambiance_ComboBox cbbGoiCuoc;
        private Ambiance.Ambiance_Label ambiance_Label6;
        private Ambiance.Ambiance_TextBox ambiance_TextBox2;
        private Ambiance.Ambiance_Button_1 btOK;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
    }
}