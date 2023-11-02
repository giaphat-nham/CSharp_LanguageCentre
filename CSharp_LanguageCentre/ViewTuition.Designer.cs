﻿
namespace CSharp_LanguageCentre.GUI
{
    partial class ViewTuition
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInHP = new System.Windows.Forms.Button();
            this.btnXemHP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalCourseDisplay = new System.Windows.Forms.Label();
            this.lblTotalTuitionDisplay = new System.Windows.Forms.Label();
            this.lblTuitionStatusDisplay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(16, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 69);
            this.panel1.TabIndex = 3;
            // 
            // lblLoginedUser
            // 
            this.lblLoginedUser.AutoSize = true;
            this.lblLoginedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(218)))));
            this.lblLoginedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.lblLoginedUser.Location = new System.Drawing.Point(19, 25);
            this.lblLoginedUser.Name = "lblLoginedUser";
            this.lblLoginedUser.Size = new System.Drawing.Size(102, 29);
            this.lblLoginedUser.TabIndex = 0;
            this.lblLoginedUser.Text = "Học phí";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInHP);
            this.groupBox1.Controls.Add(this.btnXemHP);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";
            // 
            // btnInHP
            // 
            this.btnInHP.Location = new System.Drawing.Point(496, 28);
            this.btnInHP.Name = "btnInHP";
            this.btnInHP.Size = new System.Drawing.Size(121, 26);
            this.btnInHP.TabIndex = 3;
            this.btnInHP.Text = "In học phí";
            this.btnInHP.UseVisualStyleBackColor = true;
            // 
            // btnXemHP
            // 
            this.btnXemHP.Location = new System.Drawing.Point(352, 28);
            this.btnXemHP.Name = "btnXemHP";
            this.btnXemHP.Size = new System.Drawing.Size(138, 26);
            this.btnXemHP.TabIndex = 2;
            this.btnXemHP.Text = "Xem học phí";
            this.btnXemHP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(182, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã học viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTuitionStatusDisplay);
            this.groupBox2.Controls.Add(this.lblTotalTuitionDisplay);
            this.groupBox2.Controls.Add(this.lblTotalCourseDisplay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(465, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 222);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin học phí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tình trạng học phí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng học phí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số khóa học:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.button_background;
            this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.btnQuayLai.Location = new System.Drawing.Point(800, 44);
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
            this.colHocPhi});
            this.dataGridView1.Location = new System.Drawing.Point(16, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 222);
            this.dataGridView1.TabIndex = 7;
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
            // colHocPhi
            // 
            this.colHocPhi.HeaderText = "Học Phí";
            this.colHocPhi.Name = "colHocPhi";
            this.colHocPhi.Width = 150;
            // 
            // lblTotalCourseDisplay
            // 
            this.lblTotalCourseDisplay.AutoSize = true;
            this.lblTotalCourseDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCourseDisplay.Location = new System.Drawing.Point(302, 37);
            this.lblTotalCourseDisplay.Name = "lblTotalCourseDisplay";
            this.lblTotalCourseDisplay.Size = new System.Drawing.Size(139, 20);
            this.lblTotalCourseDisplay.TabIndex = 3;
            this.lblTotalCourseDisplay.Text = "Tổng số khóa học:";
            this.lblTotalCourseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTuitionDisplay
            // 
            this.lblTotalTuitionDisplay.AutoSize = true;
            this.lblTotalTuitionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTuitionDisplay.Location = new System.Drawing.Point(302, 75);
            this.lblTotalTuitionDisplay.Name = "lblTotalTuitionDisplay";
            this.lblTotalTuitionDisplay.Size = new System.Drawing.Size(139, 20);
            this.lblTotalTuitionDisplay.TabIndex = 4;
            this.lblTotalTuitionDisplay.Text = "Tổng số khóa học:";
            this.lblTotalTuitionDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTuitionStatusDisplay
            // 
            this.lblTuitionStatusDisplay.AutoSize = true;
            this.lblTuitionStatusDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionStatusDisplay.Location = new System.Drawing.Point(302, 113);
            this.lblTuitionStatusDisplay.Name = "lblTuitionStatusDisplay";
            this.lblTuitionStatusDisplay.Size = new System.Drawing.Size(139, 20);
            this.lblTuitionStatusDisplay.TabIndex = 5;
            this.lblTuitionStatusDisplay.Text = "Tổng số khóa học:";
            this.lblTuitionStatusDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharp_LanguageCentre.Properties.Resources.general_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewTuition";
            this.Size = new System.Drawing.Size(1024, 576);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginedUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemHP;
        private System.Windows.Forms.Button btnInHP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTuitionStatusDisplay;
        private System.Windows.Forms.Label lblTotalTuitionDisplay;
        private System.Windows.Forms.Label lblTotalCourseDisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocPhi;
    }
}
