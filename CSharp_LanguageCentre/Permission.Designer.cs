
namespace CSharp_LanguageCentre
{
    partial class Permission
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginedUser = new System.Windows.Forms.Label();
            this.dgvQuyen = new System.Windows.Forms.DataGridView();
            this.colMaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChucNang = new System.Windows.Forms.DataGridView();
            this.colMaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedPer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.btnThemQuyen = new System.Windows.Forms.Button();
            this.btnXoaQuyen = new System.Windows.Forms.Button();
            this.btnSuaQuyen = new System.Windows.Forms.Button();
            this.txtTenQuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuyQuyen = new System.Windows.Forms.Button();
            this.btnXacNhanQuyen = new System.Windows.Forms.Button();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbChonCN = new System.Windows.Forms.ComboBox();
            this.btnXacNhanCN = new System.Windows.Forms.Button();
            this.btnHuyCN = new System.Windows.Forms.Button();
            this.btnXoaCN = new System.Windows.Forms.Button();
            this.btnThemCN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucNang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.groupBox1.Controls.Add(this.dgvQuyen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách quyền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
            this.panel1.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.label_background1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblLoginedUser);
            this.panel1.Location = new System.Drawing.Point(33, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 69);
            this.panel1.TabIndex = 5;
            // 
            // lblLoginedUser
            // 
            this.lblLoginedUser.AutoSize = true;
            this.lblLoginedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.lblLoginedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.lblLoginedUser.Location = new System.Drawing.Point(19, 25);
            this.lblLoginedUser.Name = "lblLoginedUser";
            this.lblLoginedUser.Size = new System.Drawing.Size(149, 29);
            this.lblLoginedUser.TabIndex = 0;
            this.lblLoginedUser.Text = "Phân quyền";
            // 
            // dgvQuyen
            // 
            this.dgvQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaQuyen,
            this.colTenQuyen});
            this.dgvQuyen.Location = new System.Drawing.Point(6, 25);
            this.dgvQuyen.Name = "dgvQuyen";
            this.dgvQuyen.Size = new System.Drawing.Size(315, 194);
            this.dgvQuyen.TabIndex = 0;
            // 
            // colMaQuyen
            // 
            this.colMaQuyen.HeaderText = "Mã quyền";
            this.colMaQuyen.Name = "colMaQuyen";
            this.colMaQuyen.ReadOnly = true;
            this.colMaQuyen.Width = 120;
            // 
            // colTenQuyen
            // 
            this.colTenQuyen.HeaderText = "Tên quyền";
            this.colTenQuyen.Name = "colTenQuyen";
            this.colTenQuyen.ReadOnly = true;
            this.colTenQuyen.Width = 150;
            // 
            // dgvChucNang
            // 
            this.dgvChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChucNang,
            this.colTenChucNang});
            this.dgvChucNang.Location = new System.Drawing.Point(24, 78);
            this.dgvChucNang.Name = "dgvChucNang";
            this.dgvChucNang.Size = new System.Drawing.Size(335, 141);
            this.dgvChucNang.TabIndex = 0;
            // 
            // colMaChucNang
            // 
            this.colMaChucNang.HeaderText = "Mã chức năng";
            this.colMaChucNang.Name = "colMaChucNang";
            this.colMaChucNang.ReadOnly = true;
            this.colMaChucNang.Width = 140;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.HeaderText = "Tên chức năng";
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.ReadOnly = true;
            this.colTenChucNang.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblSelectedPer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvChucNang);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(486, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 225);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quyền đã chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã quyền:";
            // 
            // lblSelectedPer
            // 
            this.lblSelectedPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedPer.AutoSize = true;
            this.lblSelectedPer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSelectedPer.Location = new System.Drawing.Point(341, 25);
            this.lblSelectedPer.Name = "lblSelectedPer";
            this.lblSelectedPer.Size = new System.Drawing.Size(18, 20);
            this.lblSelectedPer.TabIndex = 2;
            this.lblSelectedPer.Text = "0";
            this.lblSelectedPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách chức năng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.groupBox2.Controls.Add(this.btnXacNhanQuyen);
            this.groupBox2.Controls.Add(this.btnHuyQuyen);
            this.groupBox2.Controls.Add(this.txtTenQuyen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSuaQuyen);
            this.groupBox2.Controls.Add(this.btnXoaQuyen);
            this.groupBox2.Controls.Add(this.btnThemQuyen);
            this.groupBox2.Controls.Add(this.txtMaQuyen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác quyền";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.groupBox4.Controls.Add(this.btnXacNhanCN);
            this.groupBox4.Controls.Add(this.btnHuyCN);
            this.groupBox4.Controls.Add(this.btnXoaCN);
            this.groupBox4.Controls.Add(this.btnThemCN);
            this.groupBox4.Controls.Add(this.cbbChonCN);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtMaCN);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(486, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 144);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác chức năng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã quyền";
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Enabled = false;
            this.txtMaQuyen.Location = new System.Drawing.Point(140, 19);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(181, 26);
            this.txtMaQuyen.TabIndex = 5;
            // 
            // btnThemQuyen
            // 
            this.btnThemQuyen.Location = new System.Drawing.Point(59, 86);
            this.btnThemQuyen.Name = "btnThemQuyen";
            this.btnThemQuyen.Size = new System.Drawing.Size(75, 26);
            this.btnThemQuyen.TabIndex = 6;
            this.btnThemQuyen.Text = "Thêm";
            this.btnThemQuyen.UseVisualStyleBackColor = true;
            // 
            // btnXoaQuyen
            // 
            this.btnXoaQuyen.Location = new System.Drawing.Point(140, 86);
            this.btnXoaQuyen.Name = "btnXoaQuyen";
            this.btnXoaQuyen.Size = new System.Drawing.Size(75, 26);
            this.btnXoaQuyen.TabIndex = 7;
            this.btnXoaQuyen.Text = "Xóa";
            this.btnXoaQuyen.UseVisualStyleBackColor = true;
            // 
            // btnSuaQuyen
            // 
            this.btnSuaQuyen.Location = new System.Drawing.Point(221, 86);
            this.btnSuaQuyen.Name = "btnSuaQuyen";
            this.btnSuaQuyen.Size = new System.Drawing.Size(100, 26);
            this.btnSuaQuyen.TabIndex = 8;
            this.btnSuaQuyen.Text = "Cập nhật";
            this.btnSuaQuyen.UseVisualStyleBackColor = true;
            // 
            // txtTenQuyen
            // 
            this.txtTenQuyen.Location = new System.Drawing.Point(140, 51);
            this.txtTenQuyen.Name = "txtTenQuyen";
            this.txtTenQuyen.Size = new System.Drawing.Size(181, 26);
            this.txtTenQuyen.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên quyền";
            // 
            // btnHuyQuyen
            // 
            this.btnHuyQuyen.Location = new System.Drawing.Point(246, 118);
            this.btnHuyQuyen.Name = "btnHuyQuyen";
            this.btnHuyQuyen.Size = new System.Drawing.Size(75, 26);
            this.btnHuyQuyen.TabIndex = 11;
            this.btnHuyQuyen.Text = "Hủy";
            this.btnHuyQuyen.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanQuyen
            // 
            this.btnXacNhanQuyen.Location = new System.Drawing.Point(140, 118);
            this.btnXacNhanQuyen.Name = "btnXacNhanQuyen";
            this.btnXacNhanQuyen.Size = new System.Drawing.Size(100, 26);
            this.btnXacNhanQuyen.TabIndex = 12;
            this.btnXacNhanQuyen.Text = "Xác nhận";
            this.btnXacNhanQuyen.UseVisualStyleBackColor = true;
            this.btnXacNhanQuyen.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMaCN
            // 
            this.txtMaCN.Enabled = false;
            this.txtMaCN.Location = new System.Drawing.Point(153, 22);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(206, 26);
            this.txtMaCN.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã chức năng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chọn chức năng";
            // 
            // cbbChonCN
            // 
            this.cbbChonCN.FormattingEnabled = true;
            this.cbbChonCN.Location = new System.Drawing.Point(153, 54);
            this.cbbChonCN.Name = "cbbChonCN";
            this.cbbChonCN.Size = new System.Drawing.Size(206, 28);
            this.cbbChonCN.TabIndex = 16;
            // 
            // btnXacNhanCN
            // 
            this.btnXacNhanCN.Location = new System.Drawing.Point(178, 118);
            this.btnXacNhanCN.Name = "btnXacNhanCN";
            this.btnXacNhanCN.Size = new System.Drawing.Size(100, 26);
            this.btnXacNhanCN.TabIndex = 20;
            this.btnXacNhanCN.Text = "Xác nhận";
            this.btnXacNhanCN.UseVisualStyleBackColor = true;
            // 
            // btnHuyCN
            // 
            this.btnHuyCN.Location = new System.Drawing.Point(284, 118);
            this.btnHuyCN.Name = "btnHuyCN";
            this.btnHuyCN.Size = new System.Drawing.Size(75, 26);
            this.btnHuyCN.TabIndex = 19;
            this.btnHuyCN.Text = "Hủy";
            this.btnHuyCN.UseVisualStyleBackColor = true;
            // 
            // btnXoaCN
            // 
            this.btnXoaCN.Location = new System.Drawing.Point(284, 86);
            this.btnXoaCN.Name = "btnXoaCN";
            this.btnXoaCN.Size = new System.Drawing.Size(75, 26);
            this.btnXoaCN.TabIndex = 18;
            this.btnXoaCN.Text = "Xóa";
            this.btnXoaCN.UseVisualStyleBackColor = true;
            // 
            // btnThemCN
            // 
            this.btnThemCN.Location = new System.Drawing.Point(178, 86);
            this.btnThemCN.Name = "btnThemCN";
            this.btnThemCN.Size = new System.Drawing.Size(100, 26);
            this.btnThemCN.TabIndex = 17;
            this.btnThemCN.Text = "Thêm";
            this.btnThemCN.UseVisualStyleBackColor = true;
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.general_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Permission";
            this.Size = new System.Drawing.Size(1024, 576);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucNang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvQuyen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginedUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenQuyen;
        private System.Windows.Forms.DataGridView dgvChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChucNang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXacNhanQuyen;
        private System.Windows.Forms.Button btnHuyQuyen;
        private System.Windows.Forms.TextBox txtTenQuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSuaQuyen;
        private System.Windows.Forms.Button btnXoaQuyen;
        private System.Windows.Forms.Button btnThemQuyen;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXacNhanCN;
        private System.Windows.Forms.Button btnHuyCN;
        private System.Windows.Forms.Button btnXoaCN;
        private System.Windows.Forms.Button btnThemCN;
        private System.Windows.Forms.ComboBox cbbChonCN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label label5;
    }
}
