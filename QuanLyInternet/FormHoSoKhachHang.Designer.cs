namespace QuanLyInternet
{
    partial class FormHoSoKhachHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ambiance_Button_13 = new Ambiance.Ambiance_Button_1();
            this.ambiance_Button_12 = new Ambiance.Ambiance_Button_1();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.ambiance_Button_13_Click);
            // 
            // ambiance_Button_13
            // 
            this.ambiance_Button_13.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_13.Image = null;
            this.ambiance_Button_13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_13.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ambiance_Button_13.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ambiance_Button_13.Location = new System.Drawing.Point(34, 19);
            this.ambiance_Button_13.Name = "ambiance_Button_13";
            this.ambiance_Button_13.Size = new System.Drawing.Size(121, 30);
            this.ambiance_Button_13.TabIndex = 3;
            this.ambiance_Button_13.Text = "Chi Tiết";
            this.ambiance_Button_13.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_13.Click += new System.EventHandler(this.ambiance_Button_13_Click);
            // 
            // ambiance_Button_12
            // 
            this.ambiance_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_12.Image = null;
            this.ambiance_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_12.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ambiance_Button_12.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ambiance_Button_12.Location = new System.Drawing.Point(196, 19);
            this.ambiance_Button_12.Name = "ambiance_Button_12";
            this.ambiance_Button_12.Size = new System.Drawing.Size(121, 30);
            this.ambiance_Button_12.TabIndex = 2;
            this.ambiance_Button_12.Text = "Xóa";
            this.ambiance_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_12.Click += new System.EventHandler(this.ambiance_Button_12_Click);
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ambiance_Button_11.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ambiance_Button_11.Location = new System.Drawing.Point(345, 19);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(121, 30);
            this.ambiance_Button_11.TabIndex = 1;
            this.ambiance_Button_11.Text = "Tải Lại";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_11.Click += new System.EventHandler(this.ambiance_Button_11_Click);
            // 
            // FormHoSoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 513);
            this.Controls.Add(this.ambiance_Button_13);
            this.Controls.Add(this.ambiance_Button_12);
            this.Controls.Add(this.ambiance_Button_11);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHoSoKhachHang";
            this.Text = "Hồ sơ khách hàng";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
        private Ambiance.Ambiance_Button_1 ambiance_Button_12;
        private Ambiance.Ambiance_Button_1 ambiance_Button_13;
    }
}