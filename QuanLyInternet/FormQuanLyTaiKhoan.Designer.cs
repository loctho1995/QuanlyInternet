namespace QuanLyInternet
{
    partial class FormQuanLyTaiKhoan
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btDong = new Ambiance.Ambiance_Button_1();
            this.btThemMoi = new Ambiance.Ambiance_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(601, 287);
            this.dataGridView.TabIndex = 0;
            // 
            // btDong
            // 
            this.btDong.BackColor = System.Drawing.Color.Transparent;
            this.btDong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btDong.Image = null;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btDong.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btDong.Location = new System.Drawing.Point(528, 305);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(85, 30);
            this.btDong.TabIndex = 1;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btThemMoi
            // 
            this.btThemMoi.BackColor = System.Drawing.Color.Transparent;
            this.btThemMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btThemMoi.Image = null;
            this.btThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMoi.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btThemMoi.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btThemMoi.Location = new System.Drawing.Point(437, 305);
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.Size = new System.Drawing.Size(85, 30);
            this.btThemMoi.TabIndex = 2;
            this.btThemMoi.Text = "Thêm mới ";
            this.btThemMoi.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 347);
            this.Controls.Add(this.btThemMoi);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.dataGridView);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "Tên khách hàng - ID";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private Ambiance.Ambiance_Button_1 btDong;
        private Ambiance.Ambiance_Button_1 btThemMoi;
    }
}