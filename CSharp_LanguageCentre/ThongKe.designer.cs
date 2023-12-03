namespace CSharp_LanguageCentre
{
    partial class ThongKe
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNhanVien = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cbbLocTimKiem = new System.Windows.Forms.ComboBox();
			this.btnQuayLai = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblSoLuong = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.txtDoanhThu = new System.Windows.Forms.TextBox();
			this.lblDoanhThu = new System.Windows.Forms.Label();
			this.lblThang = new System.Windows.Forms.Label();
			this.lblHienThi = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.lblNhanVien);
			this.panel1.Location = new System.Drawing.Point(97, 77);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(249, 106);
			this.panel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(4, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(240, 106);
			this.panel2.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(28, 38);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 40);
			this.label2.TabIndex = 0;
			this.label2.Text = "Thống kê";
			// 
			// lblNhanVien
			// 
			this.lblNhanVien.AutoSize = true;
			this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblNhanVien.Location = new System.Drawing.Point(28, 38);
			this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNhanVien.Name = "lblNhanVien";
			this.lblNhanVien.Size = new System.Drawing.Size(167, 40);
			this.lblNhanVien.TabIndex = 0;
			this.lblNhanVien.Text = "Thống kê";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.txtDoanhThu);
			this.groupBox1.Controls.Add(this.lblDoanhThu);
			this.groupBox1.Controls.Add(this.txtSoLuong);
			this.groupBox1.Controls.Add(this.lblSoLuong);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(376, 240);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(912, 398);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi tiết";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.lblHienThi);
			this.groupBox2.Controls.Add(this.lblThang);
			this.groupBox2.Controls.Add(this.cbbLocTimKiem);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(376, 77);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(912, 106);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Bảng thống kê";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "MM/yyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(727, 46);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(146, 32);
			this.dateTimePicker1.TabIndex = 0;
			this.dateTimePicker1.Value = new System.DateTime(2023, 12, 25, 23, 59, 59, 0);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(0, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 28);
			this.comboBox1.TabIndex = 9;
			// 
			// cbbLocTimKiem
			// 
			this.cbbLocTimKiem.FormattingEnabled = true;
			this.cbbLocTimKiem.Items.AddRange(new object[] {
            "Hóa Đơn",
            "Khóa Học",
            ""});
			this.cbbLocTimKiem.Location = new System.Drawing.Point(187, 45);
			this.cbbLocTimKiem.Name = "cbbLocTimKiem";
			this.cbbLocTimKiem.Size = new System.Drawing.Size(332, 34);
			this.cbbLocTimKiem.TabIndex = 1;
			// 
			// btnQuayLai
			// 
			this.btnQuayLai.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.button_background;
			this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
			this.btnQuayLai.Location = new System.Drawing.Point(1295, 24);
			this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnQuayLai.Name = "btnQuayLai";
			this.btnQuayLai.Size = new System.Drawing.Size(210, 65);
			this.btnQuayLai.TabIndex = 17;
			this.btnQuayLai.Text = "Quay lại";
			this.btnQuayLai.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(912, 305);
			this.dataGridView1.TabIndex = 0;
			// 
			// lblSoLuong
			// 
			this.lblSoLuong.AutoSize = true;
			this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoLuong.Location = new System.Drawing.Point(78, 32);
			this.lblSoLuong.Name = "lblSoLuong";
			this.lblSoLuong.Size = new System.Drawing.Size(124, 29);
			this.lblSoLuong.TabIndex = 1;
			this.lblSoLuong.Text = "Số lượng:";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(208, 31);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(182, 32);
			this.txtSoLuong.TabIndex = 2;
			// 
			// txtDoanhThu
			// 
			this.txtDoanhThu.Location = new System.Drawing.Point(691, 33);
			this.txtDoanhThu.Name = "txtDoanhThu";
			this.txtDoanhThu.Size = new System.Drawing.Size(182, 32);
			this.txtDoanhThu.TabIndex = 4;
			// 
			// lblDoanhThu
			// 
			this.lblDoanhThu.AutoSize = true;
			this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDoanhThu.Location = new System.Drawing.Point(538, 34);
			this.lblDoanhThu.Name = "lblDoanhThu";
			this.lblDoanhThu.Size = new System.Drawing.Size(147, 29);
			this.lblDoanhThu.TabIndex = 3;
			this.lblDoanhThu.Text = "Doanh Thu:";
			// 
			// lblThang
			// 
			this.lblThang.AutoSize = true;
			this.lblThang.Location = new System.Drawing.Point(573, 50);
			this.lblThang.Name = "lblThang";
			this.lblThang.Size = new System.Drawing.Size(144, 26);
			this.lblThang.TabIndex = 2;
			this.lblThang.Text = " Theo tháng:";
			// 
			// lblHienThi
			// 
			this.lblHienThi.AutoSize = true;
			this.lblHienThi.Location = new System.Drawing.Point(68, 50);
			this.lblHienThi.Name = "lblHienThi";
			this.lblHienThi.Size = new System.Drawing.Size(101, 26);
			this.lblHienThi.TabIndex = 3;
			this.lblHienThi.Text = "Hiển thị:";
			// 
			// ThongKe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.C_Sharp_Project_GUI1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnQuayLai);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Name = "ThongKe";
			this.Size = new System.Drawing.Size(1536, 886);
			this.Load += new System.EventHandler(this.ThongKe_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNhanVien;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cbbLocTimKiem;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnQuayLai;
		private System.Windows.Forms.Label lblSoLuong;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.TextBox txtDoanhThu;
		private System.Windows.Forms.Label lblDoanhThu;
		private System.Windows.Forms.Label lblThang;
		private System.Windows.Forms.Label lblHienThi;
	}
}
