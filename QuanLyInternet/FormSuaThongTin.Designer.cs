namespace QuanLyInternet
{
    partial class FormSuaThongTin
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
            this.btCancle = new Ambiance.Ambiance_Button_1();
            this.ambiance_ComboBox1 = new Ambiance.Ambiance_ComboBox();
            this.ambiance_Label9 = new Ambiance.Ambiance_Label();
            this.tbDCThanhToan = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label7 = new Ambiance.Ambiance_Label();
            this.tbDCCaidat = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label6 = new Ambiance.Ambiance_Label();
            this.tbDCThuongTru = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.tbSoDienThoai = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label4 = new Ambiance.Ambiance_Label();
            this.tbNgheNghiep = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.tbSoCMND = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.tbHoVaTen = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.btOK = new Ambiance.Ambiance_Button_1();
            this.ambiance_Label10 = new Ambiance.Ambiance_Label();
            this.ambiance_TextBox1 = new Ambiance.Ambiance_TextBox();
            this.ambiance_TextBox2 = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label8 = new Ambiance.Ambiance_Label();
            this.ambiance_TextBox3 = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label11 = new Ambiance.Ambiance_Label();
            this.SuspendLayout();
            // 
            // btCancle
            // 
            this.btCancle.BackColor = System.Drawing.Color.Transparent;
            this.btCancle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btCancle.Image = null;
            this.btCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancle.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btCancle.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btCancle.Location = new System.Drawing.Point(645, 266);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(91, 38);
            this.btCancle.TabIndex = 37;
            this.btCancle.Text = "Hủy";
            this.btCancle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_ComboBox1
            // 
            this.ambiance_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ambiance_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ambiance_ComboBox1.DropDownHeight = 100;
            this.ambiance_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ambiance_ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ambiance_ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.ambiance_ComboBox1.FormattingEnabled = true;
            this.ambiance_ComboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.ambiance_ComboBox1.IntegralHeight = false;
            this.ambiance_ComboBox1.ItemHeight = 20;
            this.ambiance_ComboBox1.Items.AddRange(new object[] {
            "Đang đợi",
            "Đang sử dụng",
            "Bị treo"});
            this.ambiance_ComboBox1.Location = new System.Drawing.Point(515, 143);
            this.ambiance_ComboBox1.Name = "ambiance_ComboBox1";
            this.ambiance_ComboBox1.Size = new System.Drawing.Size(222, 26);
            this.ambiance_ComboBox1.StartIndex = 0;
            this.ambiance_ComboBox1.TabIndex = 36;
            // 
            // ambiance_Label9
            // 
            this.ambiance_Label9.AutoSize = true;
            this.ambiance_Label9.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label9.Location = new System.Drawing.Point(405, 143);
            this.ambiance_Label9.Name = "ambiance_Label9";
            this.ambiance_Label9.Size = new System.Drawing.Size(75, 20);
            this.ambiance_Label9.TabIndex = 35;
            this.ambiance_Label9.Text = "Trạng thái";
            // 
            // tbDCThanhToan
            // 
            this.tbDCThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.tbDCThanhToan.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbDCThanhToan.ForeColor = System.Drawing.Color.DimGray;
            this.tbDCThanhToan.Location = new System.Drawing.Point(128, 138);
            this.tbDCThanhToan.MaxLength = 32767;
            this.tbDCThanhToan.Multiline = false;
            this.tbDCThanhToan.Name = "tbDCThanhToan";
            this.tbDCThanhToan.ReadOnly = false;
            this.tbDCThanhToan.Size = new System.Drawing.Size(209, 28);
            this.tbDCThanhToan.TabIndex = 32;
            this.tbDCThanhToan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDCThanhToan.UseSystemPasswordChar = false;
            // 
            // ambiance_Label7
            // 
            this.ambiance_Label7.AutoSize = true;
            this.ambiance_Label7.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label7.Location = new System.Drawing.Point(405, 54);
            this.ambiance_Label7.Name = "ambiance_Label7";
            this.ambiance_Label7.Size = new System.Drawing.Size(97, 20);
            this.ambiance_Label7.TabIndex = 31;
            this.ambiance_Label7.Text = "Số điện thoại";
            // 
            // tbDCCaidat
            // 
            this.tbDCCaidat.BackColor = System.Drawing.Color.Transparent;
            this.tbDCCaidat.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbDCCaidat.ForeColor = System.Drawing.Color.DimGray;
            this.tbDCCaidat.Location = new System.Drawing.Point(515, 99);
            this.tbDCCaidat.MaxLength = 32767;
            this.tbDCCaidat.Multiline = false;
            this.tbDCCaidat.Name = "tbDCCaidat";
            this.tbDCCaidat.ReadOnly = false;
            this.tbDCCaidat.Size = new System.Drawing.Size(222, 28);
            this.tbDCCaidat.TabIndex = 30;
            this.tbDCCaidat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDCCaidat.UseSystemPasswordChar = false;
            // 
            // ambiance_Label6
            // 
            this.ambiance_Label6.AutoSize = true;
            this.ambiance_Label6.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label6.Location = new System.Drawing.Point(12, 143);
            this.ambiance_Label6.Name = "ambiance_Label6";
            this.ambiance_Label6.Size = new System.Drawing.Size(110, 20);
            this.ambiance_Label6.TabIndex = 29;
            this.ambiance_Label6.Text = "Đ/C thanh toán";
            // 
            // tbDCThuongTru
            // 
            this.tbDCThuongTru.BackColor = System.Drawing.Color.Transparent;
            this.tbDCThuongTru.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbDCThuongTru.ForeColor = System.Drawing.Color.DimGray;
            this.tbDCThuongTru.Location = new System.Drawing.Point(127, 95);
            this.tbDCThuongTru.MaxLength = 32767;
            this.tbDCThuongTru.Multiline = false;
            this.tbDCThuongTru.Name = "tbDCThuongTru";
            this.tbDCThuongTru.ReadOnly = false;
            this.tbDCThuongTru.Size = new System.Drawing.Size(210, 28);
            this.tbDCThuongTru.TabIndex = 28;
            this.tbDCThuongTru.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDCThuongTru.UseSystemPasswordChar = false;
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label5.Location = new System.Drawing.Point(405, 102);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(84, 20);
            this.ambiance_Label5.TabIndex = 27;
            this.ambiance_Label5.Text = "Đ/C cài đặt";
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.tbSoDienThoai.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSoDienThoai.ForeColor = System.Drawing.Color.DimGray;
            this.tbSoDienThoai.Location = new System.Drawing.Point(515, 50);
            this.tbSoDienThoai.MaxLength = 32767;
            this.tbSoDienThoai.Multiline = false;
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.ReadOnly = false;
            this.tbSoDienThoai.Size = new System.Drawing.Size(222, 28);
            this.tbSoDienThoai.TabIndex = 26;
            this.tbSoDienThoai.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSoDienThoai.UseSystemPasswordChar = false;
            // 
            // ambiance_Label4
            // 
            this.ambiance_Label4.AutoSize = true;
            this.ambiance_Label4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label4.Location = new System.Drawing.Point(12, 99);
            this.ambiance_Label4.Name = "ambiance_Label4";
            this.ambiance_Label4.Size = new System.Drawing.Size(109, 20);
            this.ambiance_Label4.TabIndex = 25;
            this.ambiance_Label4.Text = "Đ/C thường trú";
            // 
            // tbNgheNghiep
            // 
            this.tbNgheNghiep.BackColor = System.Drawing.Color.Transparent;
            this.tbNgheNghiep.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbNgheNghiep.ForeColor = System.Drawing.Color.DimGray;
            this.tbNgheNghiep.Location = new System.Drawing.Point(127, 50);
            this.tbNgheNghiep.MaxLength = 32767;
            this.tbNgheNghiep.Multiline = false;
            this.tbNgheNghiep.Name = "tbNgheNghiep";
            this.tbNgheNghiep.ReadOnly = false;
            this.tbNgheNghiep.Size = new System.Drawing.Size(210, 28);
            this.tbNgheNghiep.TabIndex = 24;
            this.tbNgheNghiep.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNgheNghiep.UseSystemPasswordChar = false;
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(12, 54);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(95, 20);
            this.ambiance_Label3.TabIndex = 23;
            this.ambiance_Label3.Text = "Nghề nghiệp";
            // 
            // tbSoCMND
            // 
            this.tbSoCMND.BackColor = System.Drawing.Color.Transparent;
            this.tbSoCMND.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSoCMND.ForeColor = System.Drawing.Color.DimGray;
            this.tbSoCMND.Location = new System.Drawing.Point(515, 5);
            this.tbSoCMND.MaxLength = 32767;
            this.tbSoCMND.Multiline = false;
            this.tbSoCMND.Name = "tbSoCMND";
            this.tbSoCMND.ReadOnly = false;
            this.tbSoCMND.Size = new System.Drawing.Size(222, 28);
            this.tbSoCMND.TabIndex = 22;
            this.tbSoCMND.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSoCMND.UseSystemPasswordChar = false;
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(405, 9);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(74, 20);
            this.ambiance_Label2.TabIndex = 21;
            this.ambiance_Label2.Text = "Số CMND";
            // 
            // tbHoVaTen
            // 
            this.tbHoVaTen.BackColor = System.Drawing.Color.Transparent;
            this.tbHoVaTen.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbHoVaTen.ForeColor = System.Drawing.Color.DimGray;
            this.tbHoVaTen.Location = new System.Drawing.Point(127, 5);
            this.tbHoVaTen.MaxLength = 32767;
            this.tbHoVaTen.Multiline = false;
            this.tbHoVaTen.Name = "tbHoVaTen";
            this.tbHoVaTen.ReadOnly = false;
            this.tbHoVaTen.Size = new System.Drawing.Size(210, 28);
            this.tbHoVaTen.TabIndex = 20;
            this.tbHoVaTen.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbHoVaTen.UseSystemPasswordChar = false;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(12, 9);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(73, 20);
            this.ambiance_Label1.TabIndex = 19;
            this.ambiance_Label1.Text = "Họ và tên";
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Transparent;
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btOK.Image = null;
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOK.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btOK.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btOK.Location = new System.Drawing.Point(534, 266);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(91, 38);
            this.btOK.TabIndex = 38;
            this.btOK.Text = "Hoàn tất";
            this.btOK.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Label10
            // 
            this.ambiance_Label10.AutoSize = true;
            this.ambiance_Label10.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label10.Location = new System.Drawing.Point(12, 184);
            this.ambiance_Label10.Name = "ambiance_Label10";
            this.ambiance_Label10.Size = new System.Drawing.Size(75, 20);
            this.ambiance_Label10.TabIndex = 39;
            this.ambiance_Label10.Text = "Username";
            // 
            // ambiance_TextBox1
            // 
            this.ambiance_TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ambiance_TextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox1.Location = new System.Drawing.Point(127, 178);
            this.ambiance_TextBox1.MaxLength = 32767;
            this.ambiance_TextBox1.Multiline = false;
            this.ambiance_TextBox1.Name = "ambiance_TextBox1";
            this.ambiance_TextBox1.ReadOnly = false;
            this.ambiance_TextBox1.Size = new System.Drawing.Size(210, 28);
            this.ambiance_TextBox1.TabIndex = 40;
            this.ambiance_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ambiance_TextBox1.UseSystemPasswordChar = false;
            // 
            // ambiance_TextBox2
            // 
            this.ambiance_TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ambiance_TextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox2.Location = new System.Drawing.Point(515, 181);
            this.ambiance_TextBox2.MaxLength = 32767;
            this.ambiance_TextBox2.Multiline = false;
            this.ambiance_TextBox2.Name = "ambiance_TextBox2";
            this.ambiance_TextBox2.ReadOnly = false;
            this.ambiance_TextBox2.Size = new System.Drawing.Size(222, 28);
            this.ambiance_TextBox2.TabIndex = 42;
            this.ambiance_TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ambiance_TextBox2.UseSystemPasswordChar = false;
            // 
            // ambiance_Label8
            // 
            this.ambiance_Label8.AutoSize = true;
            this.ambiance_Label8.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label8.Location = new System.Drawing.Point(405, 181);
            this.ambiance_Label8.Name = "ambiance_Label8";
            this.ambiance_Label8.Size = new System.Drawing.Size(72, 20);
            this.ambiance_Label8.TabIndex = 41;
            this.ambiance_Label8.Text = "password";
            // 
            // ambiance_TextBox3
            // 
            this.ambiance_TextBox3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ambiance_TextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox3.Location = new System.Drawing.Point(127, 219);
            this.ambiance_TextBox3.MaxLength = 32767;
            this.ambiance_TextBox3.Multiline = false;
            this.ambiance_TextBox3.Name = "ambiance_TextBox3";
            this.ambiance_TextBox3.ReadOnly = false;
            this.ambiance_TextBox3.Size = new System.Drawing.Size(210, 28);
            this.ambiance_TextBox3.TabIndex = 44;
            this.ambiance_TextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ambiance_TextBox3.UseSystemPasswordChar = false;
            // 
            // ambiance_Label11
            // 
            this.ambiance_Label11.AutoSize = true;
            this.ambiance_Label11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label11.Location = new System.Drawing.Point(12, 227);
            this.ambiance_Label11.Name = "ambiance_Label11";
            this.ambiance_Label11.Size = new System.Drawing.Size(46, 20);
            this.ambiance_Label11.TabIndex = 43;
            this.ambiance_Label11.Text = "Email";
            // 
            // FormSuaThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 312);
            this.Controls.Add(this.ambiance_TextBox3);
            this.Controls.Add(this.ambiance_Label11);
            this.Controls.Add(this.ambiance_TextBox2);
            this.Controls.Add(this.ambiance_Label8);
            this.Controls.Add(this.ambiance_TextBox1);
            this.Controls.Add(this.ambiance_Label10);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.ambiance_ComboBox1);
            this.Controls.Add(this.ambiance_Label9);
            this.Controls.Add(this.tbDCThanhToan);
            this.Controls.Add(this.ambiance_Label7);
            this.Controls.Add(this.tbDCCaidat);
            this.Controls.Add(this.ambiance_Label6);
            this.Controls.Add(this.tbDCThuongTru);
            this.Controls.Add(this.ambiance_Label5);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.ambiance_Label4);
            this.Controls.Add(this.tbNgheNghiep);
            this.Controls.Add(this.ambiance_Label3);
            this.Controls.Add(this.tbSoCMND);
            this.Controls.Add(this.ambiance_Label2);
            this.Controls.Add(this.tbHoVaTen);
            this.Controls.Add(this.ambiance_Label1);
            this.Name = "FormSuaThongTin";
            this.Text = "SuaThongTin";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_Button_1 btCancle;
        private Ambiance.Ambiance_ComboBox ambiance_ComboBox1;
        private Ambiance.Ambiance_Label ambiance_Label9;
        private Ambiance.Ambiance_TextBox tbDCThanhToan;
        private Ambiance.Ambiance_Label ambiance_Label7;
        private Ambiance.Ambiance_TextBox tbDCCaidat;
        private Ambiance.Ambiance_Label ambiance_Label6;
        private Ambiance.Ambiance_TextBox tbDCThuongTru;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private Ambiance.Ambiance_TextBox tbSoDienThoai;
        private Ambiance.Ambiance_Label ambiance_Label4;
        private Ambiance.Ambiance_TextBox tbNgheNghiep;
        private Ambiance.Ambiance_Label ambiance_Label3;
        private Ambiance.Ambiance_TextBox tbSoCMND;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_TextBox tbHoVaTen;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Button_1 btOK;
        private Ambiance.Ambiance_Label ambiance_Label10;
        private Ambiance.Ambiance_TextBox ambiance_TextBox1;
        private Ambiance.Ambiance_TextBox ambiance_TextBox2;
        private Ambiance.Ambiance_Label ambiance_Label8;
        private Ambiance.Ambiance_TextBox ambiance_TextBox3;
        private Ambiance.Ambiance_Label ambiance_Label11;
    }
}