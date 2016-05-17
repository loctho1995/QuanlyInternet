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
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ambiance_Button_11.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ambiance_Button_11.Location = new System.Drawing.Point(14, 19);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(121, 30);
            this.ambiance_Button_11.TabIndex = 1;
            this.ambiance_Button_11.Text = "Lọc danh sách";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_11.Click += new System.EventHandler(this.ambiance_Button_11_Click);
            // 
            // HoSoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 513);
            this.Controls.Add(this.ambiance_Button_11);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HoSoKhachHang";
            this.Text = "Hồ sơ khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
    }
}