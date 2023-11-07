﻿namespace CSharp_LanguageCentre
{
	partial class Staff
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblNhanVien = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.ccbLocTimKiem = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.cbbMaLuong = new System.Windows.Forms.ComboBox();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.txtTenTK = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.lblNhanVien);
			this.panel1.Location = new System.Drawing.Point(52, 44);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 106);
			this.panel1.TabIndex = 5;
			// 
			// lblNhanVien
			// 
			this.lblNhanVien.AutoSize = true;
			this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblNhanVien.Location = new System.Drawing.Point(28, 38);
			this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNhanVien.Name = "lblNhanVien";
			this.lblNhanVien.Size = new System.Drawing.Size(179, 40);
			this.lblNhanVien.TabIndex = 0;
			this.lblNhanVien.Text = "Nhân viên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.txtTimKiem);
			this.groupBox1.Controls.Add(this.ccbLocTimKiem);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(102, 169);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(911, 121);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin nhân viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(83, 83);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tìm kiếm:";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(681, 72);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(106, 41);
			this.btnTimKiem.TabIndex = 3;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(226, 77);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(426, 32);
			this.txtTimKiem.TabIndex = 2;
			// 
			// ccbLocTimKiem
			// 
			this.ccbLocTimKiem.FormattingEnabled = true;
			this.ccbLocTimKiem.Location = new System.Drawing.Point(226, 35);
			this.ccbLocTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ccbLocTimKiem.Name = "ccbLocTimKiem";
			this.ccbLocTimKiem.Size = new System.Drawing.Size(281, 34);
			this.ccbLocTimKiem.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(83, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lọc theo:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.SoDienThoai,
            this.MaLuong,
            this.TenTK});
			this.dataGridView1.Location = new System.Drawing.Point(102, 312);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(911, 558);
			this.dataGridView1.TabIndex = 7;
			// 
			// MaNV
			// 
			this.MaNV.HeaderText = "Mã NV";
			this.MaNV.MinimumWidth = 8;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 150;
			// 
			// HoTen
			// 
			this.HoTen.HeaderText = "Họ tên";
			this.HoTen.MinimumWidth = 8;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 150;
			// 
			// SoDienThoai
			// 
			this.SoDienThoai.HeaderText = "Số điện thoại";
			this.SoDienThoai.MinimumWidth = 8;
			this.SoDienThoai.Name = "SoDienThoai";
			this.SoDienThoai.Width = 150;
			// 
			// MaLuong
			// 
			this.MaLuong.HeaderText = "Mã lương";
			this.MaLuong.MinimumWidth = 8;
			this.MaLuong.Name = "MaLuong";
			this.MaLuong.Width = 150;
			// 
			// TenTK
			// 
			this.TenTK.HeaderText = "Tên tài khoản";
			this.TenTK.MinimumWidth = 8;
			this.TenTK.Name = "TenTK";
			this.TenTK.Width = 150;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btnXacNhan);
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.cbbMaLuong);
			this.groupBox2.Controls.Add(this.txtTenTK);
			this.groupBox2.Controls.Add(this.txtSdt);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtMaNV);
			this.groupBox2.Controls.Add(this.txtTenNV);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(1033, 312);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(485, 558);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin chi tiết";
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Location = new System.Drawing.Point(256, 451);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(127, 46);
			this.btnXacNhan.TabIndex = 17;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(106, 451);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(113, 46);
			this.btnHuy.TabIndex = 16;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(344, 380);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(113, 46);
			this.btnXoa.TabIndex = 15;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(193, 380);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(113, 46);
			this.btnSua.TabIndex = 14;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(35, 380);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(113, 46);
			this.btnThem.TabIndex = 13;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// cbbMaLuong
			// 
			this.cbbMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbMaLuong.FormattingEnabled = true;
			this.cbbMaLuong.Location = new System.Drawing.Point(182, 242);
			this.cbbMaLuong.Name = "cbbMaLuong";
			this.cbbMaLuong.Size = new System.Drawing.Size(275, 34);
			this.cbbMaLuong.TabIndex = 12;
			// 
			// txtSdt
			// 
			this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSdt.Location = new System.Drawing.Point(182, 191);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(275, 32);
			this.txtSdt.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 242);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 26);
			this.label8.TabIndex = 7;
			this.label8.Text = "Mã lương:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 294);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 26);
			this.label7.TabIndex = 6;
			this.label7.Text = "Tên TK:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "SĐT:";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNV.Location = new System.Drawing.Point(182, 89);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(275, 32);
			this.txtMaNV.TabIndex = 3;
			// 
			// txtTenNV
			// 
			this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNV.Location = new System.Drawing.Point(182, 139);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(275, 32);
			this.txtTenNV.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 26);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tên NV:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 26);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã NV:";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// txtTenTK
			// 
			this.txtTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenTK.Location = new System.Drawing.Point(182, 294);
			this.txtTenTK.Name = "txtTenTK";
			this.txtTenTK.Size = new System.Drawing.Size(275, 32);
			this.txtTenTK.TabIndex = 10;
			// 
			// Staff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.C_Sharp_Project_GUI1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Name = "Staff";
			this.Size = new System.Drawing.Size(1536, 886);
			this.Load += new System.EventHandler(this.Staff_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNhanVien;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.ComboBox ccbLocTimKiem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.ComboBox cbbMaLuong;
		private System.Windows.Forms.TextBox txtSdt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenTK;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}
