namespace CSharp_LanguageCentre.GUI
{
	partial class Teacher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblGiangVien = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLoadList = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.cbbLocTimKiem = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGVgv = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
			this.cbbChuyenMon = new System.Windows.Forms.ComboBox();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.cbbMaLuong = new System.Windows.Forms.ComboBox();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaGV = new System.Windows.Forms.TextBox();
			this.txtTenGV = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnQuayLai = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGVgv)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.lblGiangVien);
			this.panel1.Location = new System.Drawing.Point(42, 25);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 106);
			this.panel1.TabIndex = 4;
			// 
			// lblGiangVien
			// 
			this.lblGiangVien.AutoSize = true;
			this.lblGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGiangVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblGiangVien.Location = new System.Drawing.Point(28, 38);
			this.lblGiangVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGiangVien.Name = "lblGiangVien";
			this.lblGiangVien.Size = new System.Drawing.Size(189, 40);
			this.lblGiangVien.TabIndex = 0;
			this.lblGiangVien.Text = "Giảng viên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnLoadList);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.txtTimKiem);
			this.groupBox1.Controls.Add(this.cbbLocTimKiem);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(101, 159);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(911, 121);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin giảng viên";
			// 
			// btnLoadList
			// 
			this.btnLoadList.Location = new System.Drawing.Point(797, 72);
			this.btnLoadList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLoadList.Name = "btnLoadList";
			this.btnLoadList.Size = new System.Drawing.Size(106, 41);
			this.btnLoadList.TabIndex = 5;
			this.btnLoadList.Text = "Tải lại";
			this.btnLoadList.UseVisualStyleBackColor = true;
			this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
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
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(226, 77);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(426, 32);
			this.txtTimKiem.TabIndex = 2;
			// 
			// cbbLocTimKiem
			// 
			this.cbbLocTimKiem.FormattingEnabled = true;
			this.cbbLocTimKiem.Items.AddRange(new object[] {
            "Mã giảng viên ",
            "Tên giảng viên",
            "Số điện thoại"});
			this.cbbLocTimKiem.Location = new System.Drawing.Point(226, 35);
			this.cbbLocTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbbLocTimKiem.Name = "cbbLocTimKiem";
			this.cbbLocTimKiem.Size = new System.Drawing.Size(281, 34);
			this.cbbLocTimKiem.TabIndex = 1;
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
			// dataGVgv
			// 
			this.dataGVgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVgv.Location = new System.Drawing.Point(101, 299);
			this.dataGVgv.Name = "dataGVgv";
			this.dataGVgv.RowHeadersWidth = 62;
			this.dataGVgv.RowTemplate.Height = 28;
			this.dataGVgv.Size = new System.Drawing.Size(911, 558);
			this.dataGVgv.TabIndex = 5;
			this.dataGVgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVgv_CellContentClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.cbbTrinhDo);
			this.groupBox2.Controls.Add(this.cbbChuyenMon);
			this.groupBox2.Controls.Add(this.btnXacNhan);
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.cbbMaLuong);
			this.groupBox2.Controls.Add(this.txtSdt);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtMaGV);
			this.groupBox2.Controls.Add(this.txtTenGV);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(1033, 159);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(485, 701);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin chi tiết";
			// 
			// cbbTrinhDo
			// 
			this.cbbTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbTrinhDo.FormattingEnabled = true;
			this.cbbTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
			this.cbbTrinhDo.Location = new System.Drawing.Point(182, 242);
			this.cbbTrinhDo.Name = "cbbTrinhDo";
			this.cbbTrinhDo.Size = new System.Drawing.Size(275, 34);
			this.cbbTrinhDo.TabIndex = 19;
			// 
			// cbbChuyenMon
			// 
			this.cbbChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbChuyenMon.FormattingEnabled = true;
			this.cbbChuyenMon.Items.AddRange(new object[] {
            "Nghe",
            "Noi",
            "Doc",
            "Viet"});
			this.cbbChuyenMon.Location = new System.Drawing.Point(182, 294);
			this.cbbChuyenMon.Name = "cbbChuyenMon";
			this.cbbChuyenMon.Size = new System.Drawing.Size(275, 34);
			this.cbbChuyenMon.TabIndex = 18;
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Location = new System.Drawing.Point(256, 570);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(127, 46);
			this.btnXacNhan.TabIndex = 17;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(106, 570);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(113, 46);
			this.btnHuy.TabIndex = 16;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(344, 468);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(113, 46);
			this.btnXoa.TabIndex = 15;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(193, 468);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(113, 46);
			this.btnSua.TabIndex = 14;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(35, 468);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(113, 46);
			this.btnThem.TabIndex = 13;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// cbbMaLuong
			// 
			this.cbbMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbMaLuong.FormattingEnabled = true;
			this.cbbMaLuong.Location = new System.Drawing.Point(182, 349);
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
			this.label8.Location = new System.Drawing.Point(32, 349);
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
			this.label7.Size = new System.Drawing.Size(153, 26);
			this.label7.TabIndex = 6;
			this.label7.Text = "Chuyên môn:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 26);
			this.label6.TabIndex = 5;
			this.label6.Text = "Trình độ:";
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
			// txtMaGV
			// 
			this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaGV.Location = new System.Drawing.Point(182, 89);
			this.txtMaGV.Name = "txtMaGV";
			this.txtMaGV.Size = new System.Drawing.Size(275, 32);
			this.txtMaGV.TabIndex = 3;
			// 
			// txtTenGV
			// 
			this.txtTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenGV.Location = new System.Drawing.Point(182, 139);
			this.txtTenGV.Name = "txtTenGV";
			this.txtTenGV.Size = new System.Drawing.Size(275, 32);
			this.txtTenGV.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 26);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tên GV:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 26);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã GV:";
			// 
			// btnQuayLai
			// 
			this.btnQuayLai.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.button_background;
			this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
			this.btnQuayLai.Location = new System.Drawing.Point(1308, 38);
			this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnQuayLai.Name = "btnQuayLai";
			this.btnQuayLai.Size = new System.Drawing.Size(210, 65);
			this.btnQuayLai.TabIndex = 15;
			this.btnQuayLai.Text = "Quay lại";
			this.btnQuayLai.UseVisualStyleBackColor = true;
			this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
			// 
			// Teacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnQuayLai);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGVgv);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Teacher";
			this.Size = new System.Drawing.Size(1536, 886);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGVgv)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblGiangVien;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbLocTimKiem;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGVgv;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenGV;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaGV;
		private System.Windows.Forms.TextBox txtSdt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.ComboBox cbbMaLuong;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnQuayLai;
		private System.Windows.Forms.Button btnLoadList;
		private System.Windows.Forms.ComboBox cbbTrinhDo;
		private System.Windows.Forms.ComboBox cbbChuyenMon;
	}
}
