namespace CSharp_LanguageCentre
{
	partial class Luong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luong));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblLuong = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MaLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MucLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtMucLuong = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaLuong = new System.Windows.Forms.TextBox();
			this.txtLoaiLuong = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnQuayLai = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.lblLuong);
			this.panel1.Location = new System.Drawing.Point(60, 46);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 106);
			this.panel1.TabIndex = 5;
			// 
			// lblLuong
			// 
			this.lblLuong.AutoSize = true;
			this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblLuong.Location = new System.Drawing.Point(59, 38);
			this.lblLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLuong.Name = "lblLuong";
			this.lblLuong.Size = new System.Drawing.Size(127, 40);
			this.lblLuong.TabIndex = 0;
			this.lblLuong.Text = "Lương ";
			this.lblLuong.Click += new System.EventHandler(this.lblLuong_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuong,
            this.LoaiLuong,
            this.MucLuong});
			this.dataGridView1.Location = new System.Drawing.Point(126, 210);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(728, 558);
			this.dataGridView1.TabIndex = 6;
			// 
			// MaLuong
			// 
			this.MaLuong.HeaderText = "Mã lương";
			this.MaLuong.MinimumWidth = 8;
			this.MaLuong.Name = "MaLuong";
			this.MaLuong.Width = 150;
			// 
			// LoaiLuong
			// 
			this.LoaiLuong.HeaderText = "Loại lương";
			this.LoaiLuong.MinimumWidth = 8;
			this.LoaiLuong.Name = "LoaiLuong";
			this.LoaiLuong.Width = 150;
			// 
			// MucLuong
			// 
			this.MucLuong.HeaderText = "Mức lương";
			this.MucLuong.MinimumWidth = 8;
			this.MucLuong.Name = "MucLuong";
			this.MucLuong.Width = 150;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btnXacNhan);
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.txtMucLuong);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtMaLuong);
			this.groupBox2.Controls.Add(this.txtLoaiLuong);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(914, 210);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(544, 558);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin chi tiết";
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Location = new System.Drawing.Point(293, 410);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(127, 46);
			this.btnXacNhan.TabIndex = 17;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(143, 410);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(113, 46);
			this.btnHuy.TabIndex = 16;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(381, 329);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(113, 46);
			this.btnXoa.TabIndex = 15;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(230, 329);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(113, 46);
			this.btnSua.TabIndex = 14;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(72, 329);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(113, 46);
			this.btnThem.TabIndex = 13;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// txtMucLuong
			// 
			this.txtMucLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMucLuong.Location = new System.Drawing.Point(182, 191);
			this.txtMucLuong.Name = "txtMucLuong";
			this.txtMucLuong.Size = new System.Drawing.Size(275, 32);
			this.txtMucLuong.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mức lương:";
			// 
			// txtMaLuong
			// 
			this.txtMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaLuong.Location = new System.Drawing.Point(182, 89);
			this.txtMaLuong.Name = "txtMaLuong";
			this.txtMaLuong.Size = new System.Drawing.Size(275, 32);
			this.txtMaLuong.TabIndex = 3;
			this.txtMaLuong.TextChanged += new System.EventHandler(this.txtMaGV_TextChanged);
			// 
			// txtLoaiLuong
			// 
			this.txtLoaiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLoaiLuong.Location = new System.Drawing.Point(182, 139);
			this.txtLoaiLuong.Name = "txtLoaiLuong";
			this.txtLoaiLuong.Size = new System.Drawing.Size(275, 32);
			this.txtLoaiLuong.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 26);
			this.label4.TabIndex = 1;
			this.label4.Text = "Loại lương:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 26);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã lương:";
			// 
			// btnQuayLai
			// 
			this.btnQuayLai.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.button_background;
			this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
			this.btnQuayLai.Location = new System.Drawing.Point(1248, 59);
			this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnQuayLai.Name = "btnQuayLai";
			this.btnQuayLai.Size = new System.Drawing.Size(210, 65);
			this.btnQuayLai.TabIndex = 16;
			this.btnQuayLai.Text = "Quay lại";
			this.btnQuayLai.UseVisualStyleBackColor = true;
			// 
			// Luong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.C_Sharp_Project_GUI1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnQuayLai);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Name = "Luong";
			this.Size = new System.Drawing.Size(1536, 886);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblLuong;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn MucLuong;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtMucLuong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaLuong;
		private System.Windows.Forms.TextBox txtLoaiLuong;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnQuayLai;
	}
}
