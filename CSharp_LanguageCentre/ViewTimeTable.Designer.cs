﻿
namespace CSharp_LanguageCentre.GUI
{
    partial class ViewTimeTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginedUser = new System.Windows.Forms.Label();
            this.timeTableTabs = new System.Windows.Forms.TabControl();
            this.studentPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInTKBHV = new System.Windows.Forms.Button();
            this.btnXemTKBHV = new System.Windows.Forms.Button();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInTKBGV = new System.Windows.Forms.Button();
            this.btnXemTKBGV = new System.Windows.Forms.Button();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTietBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.timeTableTabs.SuspendLayout();
            this.studentPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
            this.panel1.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.label_background1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblLoginedUser);
            this.panel1.Location = new System.Drawing.Point(20, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 69);
            this.panel1.TabIndex = 2;
            // 
            // lblLoginedUser
            // 
            this.lblLoginedUser.AutoSize = true;
            this.lblLoginedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
            this.lblLoginedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.lblLoginedUser.Location = new System.Drawing.Point(13, 25);
            this.lblLoginedUser.Name = "lblLoginedUser";
            this.lblLoginedUser.Size = new System.Drawing.Size(187, 29);
            this.lblLoginedUser.TabIndex = 0;
            this.lblLoginedUser.Text = "Thời khóa biểu";
            // 
            // timeTableTabs
            // 
            this.timeTableTabs.Controls.Add(this.studentPage);
            this.timeTableTabs.Controls.Add(this.tabPage2);
            this.timeTableTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTableTabs.Location = new System.Drawing.Point(20, 103);
            this.timeTableTabs.Name = "timeTableTabs";
            this.timeTableTabs.SelectedIndex = 0;
            this.timeTableTabs.Size = new System.Drawing.Size(912, 128);
            this.timeTableTabs.TabIndex = 3;
            // 
            // studentPage
            // 
            this.studentPage.Controls.Add(this.groupBox1);
            this.studentPage.Location = new System.Drawing.Point(4, 29);
            this.studentPage.Name = "studentPage";
            this.studentPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentPage.Size = new System.Drawing.Size(904, 95);
            this.studentPage.TabIndex = 0;
            this.studentPage.Text = "Học viên";
            this.studentPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInTKBHV);
            this.groupBox1.Controls.Add(this.btnXemTKBHV);
            this.groupBox1.Controls.Add(this.txtMaHV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";
            // 
            // btnInTKBHV
            // 
            this.btnInTKBHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInTKBHV.Location = new System.Drawing.Point(464, 28);
            this.btnInTKBHV.Name = "btnInTKBHV";
            this.btnInTKBHV.Size = new System.Drawing.Size(105, 26);
            this.btnInTKBHV.TabIndex = 3;
            this.btnInTKBHV.Text = "In TKB";
            this.btnInTKBHV.UseVisualStyleBackColor = true;
            // 
            // btnXemTKBHV
            // 
            this.btnXemTKBHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTKBHV.Location = new System.Drawing.Point(353, 28);
            this.btnXemTKBHV.Name = "btnXemTKBHV";
            this.btnXemTKBHV.Size = new System.Drawing.Size(105, 26);
            this.btnXemTKBHV.TabIndex = 2;
            this.btnXemTKBHV.Text = "Xem TKB";
            this.btnXemTKBHV.UseVisualStyleBackColor = true;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHV.Location = new System.Drawing.Point(176, 28);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(171, 26);
            this.txtMaHV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã học viên:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 95);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giảng viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInTKBGV);
            this.groupBox2.Controls.Add(this.btnXemTKBGV);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giảng viên";
            // 
            // btnInTKBGV
            // 
            this.btnInTKBGV.Location = new System.Drawing.Point(510, 28);
            this.btnInTKBGV.Name = "btnInTKBGV";
            this.btnInTKBGV.Size = new System.Drawing.Size(85, 26);
            this.btnInTKBGV.TabIndex = 3;
            this.btnInTKBGV.Text = "In TKB";
            this.btnInTKBGV.UseVisualStyleBackColor = true;
            this.btnInTKBGV.Click += new System.EventHandler(this.btnInTKBGV_Click);
            // 
            // btnXemTKBGV
            // 
            this.btnXemTKBGV.Location = new System.Drawing.Point(388, 28);
            this.btnXemTKBGV.Name = "btnXemTKBGV";
            this.btnXemTKBGV.Size = new System.Drawing.Size(116, 26);
            this.btnXemTKBGV.TabIndex = 2;
            this.btnXemTKBGV.Text = "Xem TKB";
            this.btnXemTKBGV.UseVisualStyleBackColor = true;
            this.btnXemTKBGV.Click += new System.EventHandler(this.btnXemTKBGV_Click);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(196, 28);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(186, 26);
            this.txtMaGV.TabIndex = 1;
            this.txtMaGV.TextChanged += new System.EventHandler(this.txtMaGV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã giảng viên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.button_background;
            this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.btnQuayLai.Location = new System.Drawing.Point(792, 43);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(140, 42);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colThu,
            this.colTietBD,
            this.colSoTiet,
            this.colNgayBD,
            this.colNgayKT});
            this.dataGridView1.Location = new System.Drawing.Point(20, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 319);
            this.dataGridView1.TabIndex = 5;
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã Khóa Học";
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Tên Khóa Học";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Width = 150;
            // 
            // colThu
            // 
            this.colThu.HeaderText = "Thứ";
            this.colThu.Name = "colThu";
            this.colThu.Width = 50;
            // 
            // colTietBD
            // 
            this.colTietBD.HeaderText = "Tiết Bắt Đầu";
            this.colTietBD.Name = "colTietBD";
            // 
            // colSoTiet
            // 
            this.colSoTiet.HeaderText = "Số Tiết";
            this.colSoTiet.Name = "colSoTiet";
            this.colSoTiet.Width = 70;
            // 
            // colNgayBD
            // 
            this.colNgayBD.HeaderText = "Ngày Bắt Đầu";
            this.colNgayBD.Name = "colNgayBD";
            this.colNgayBD.Width = 200;
            // 
            // colNgayKT
            // 
            this.colNgayKT.HeaderText = "Ngày Kết Thúc";
            this.colNgayKT.Name = "colNgayKT";
            this.colNgayKT.Width = 200;
            // 
            // ViewTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.general_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.timeTableTabs);
            this.Controls.Add(this.panel1);
            this.Name = "ViewTimeTable";
            this.Size = new System.Drawing.Size(1024, 576);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.timeTableTabs.ResumeLayout(false);
            this.studentPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginedUser;
        private System.Windows.Forms.TabControl timeTableTabs;
        private System.Windows.Forms.TabPage studentPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemTKBHV;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInTKBHV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXemTKBGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInTKBGV;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTietBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKT;
    }
}