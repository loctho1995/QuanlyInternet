namespace QuanLyInternet
{
    partial class FilterOption
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
            this.ambiance_CheckBox1 = new Ambiance.Ambiance_CheckBox();
            this.ambiance_CheckBox2 = new Ambiance.Ambiance_CheckBox();
            this.SuspendLayout();
            // 
            // ambiance_CheckBox1
            // 
            this.ambiance_CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_CheckBox1.Checked = false;
            this.ambiance_CheckBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_CheckBox1.Location = new System.Drawing.Point(12, 38);
            this.ambiance_CheckBox1.Name = "ambiance_CheckBox1";
            this.ambiance_CheckBox1.Size = new System.Drawing.Size(171, 15);
            this.ambiance_CheckBox1.TabIndex = 0;
            this.ambiance_CheckBox1.Text = "Đang nợ hóa đơn";
            // 
            // ambiance_CheckBox2
            // 
            this.ambiance_CheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_CheckBox2.Checked = false;
            this.ambiance_CheckBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_CheckBox2.Location = new System.Drawing.Point(12, 12);
            this.ambiance_CheckBox2.Name = "ambiance_CheckBox2";
            this.ambiance_CheckBox2.Size = new System.Drawing.Size(171, 15);
            this.ambiance_CheckBox2.TabIndex = 1;
            this.ambiance_CheckBox2.Text = "Đã thanh toán";
            // 
            // FilterOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 261);
            this.Controls.Add(this.ambiance_CheckBox2);
            this.Controls.Add(this.ambiance_CheckBox1);
            this.Name = "FilterOption";
            this.Text = "Danh sách lọc";
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_CheckBox ambiance_CheckBox1;
        private Ambiance.Ambiance_CheckBox ambiance_CheckBox2;
    }
}