namespace QuanLyInternet
{
    partial class FormQLKhuyenMai
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
            this.btOK = new Ambiance.Ambiance_Button_1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Transparent;
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btOK.Image = null;
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOK.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btOK.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btOK.Location = new System.Drawing.Point(12, 12);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(91, 38);
            this.btOK.TabIndex = 40;
            this.btOK.Text = "Thêm mới";
            this.btOK.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(782, 307);
            this.dataGridView1.TabIndex = 41;
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ambiance_Button_11.InActiveColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ambiance_Button_11.Location = new System.Drawing.Point(703, 369);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(91, 38);
            this.ambiance_Button_11.TabIndex = 42;
            this.ambiance_Button_11.Text = "Đóng";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FormQLKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 414);
            this.Controls.Add(this.ambiance_Button_11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btOK);
            this.Name = "FormQLKhuyenMai";
            this.Text = "Quản lý chương trình khuyến mãi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_Button_1 btOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
    }
}