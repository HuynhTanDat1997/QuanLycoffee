
namespace WindowsFormsApp1
{
    partial class frmHienThiHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.dgvDSMonTheoHD = new System.Windows.Forms.DataGridView();
            this.dgvcTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnTraLai = new System.Windows.Forms.Button();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.lblTraLai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonTheoHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số HĐ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian: ";
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(602, 123);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(83, 22);
            this.lblTenBan.TabIndex = 0;
            this.lblTenBan.Text = "Tên bàn";
            // 
            // dgvDSMonTheoHD
            // 
            this.dgvDSMonTheoHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMonTheoHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMonTheoHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonTheoHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcTenMon,
            this.dgvcSoLuong,
            this.dgvcDonGia,
            this.dgvcThanhTien});
            this.dgvDSMonTheoHD.Location = new System.Drawing.Point(0, 208);
            this.dgvDSMonTheoHD.Name = "dgvDSMonTheoHD";
            this.dgvDSMonTheoHD.RowHeadersWidth = 62;
            this.dgvDSMonTheoHD.RowTemplate.Height = 28;
            this.dgvDSMonTheoHD.Size = new System.Drawing.Size(717, 307);
            this.dgvDSMonTheoHD.TabIndex = 1;
            // 
            // dgvcTenMon
            // 
            this.dgvcTenMon.DataPropertyName = "TenMon";
            this.dgvcTenMon.HeaderText = "Tên món";
            this.dgvcTenMon.MinimumWidth = 8;
            this.dgvcTenMon.Name = "dgvcTenMon";
            // 
            // dgvcSoLuong
            // 
            this.dgvcSoLuong.DataPropertyName = "SoLuong";
            this.dgvcSoLuong.HeaderText = "Số lượng";
            this.dgvcSoLuong.MinimumWidth = 8;
            this.dgvcSoLuong.Name = "dgvcSoLuong";
            // 
            // dgvcDonGia
            // 
            this.dgvcDonGia.DataPropertyName = "DonGia";
            this.dgvcDonGia.HeaderText = "Đơn giá";
            this.dgvcDonGia.MinimumWidth = 8;
            this.dgvcDonGia.Name = "dgvcDonGia";
            // 
            // dgvcThanhTien
            // 
            this.dgvcThanhTien.DataPropertyName = "ThanhTien";
            this.dgvcThanhTien.HeaderText = "Thành tiền";
            this.dgvcThanhTien.MinimumWidth = 8;
            this.dgvcThanhTien.Name = "dgvcThanhTien";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblNhanVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnInHoaDon);
            this.groupBox1.Controls.Add(this.btnTraLai);
            this.groupBox1.Controls.Add(this.txtKhachDua);
            this.groupBox1.Controls.Add(this.dgvDSMonTheoHD);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.lblTenBan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSoHD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTraLai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblThoiGian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 713);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInHoaDon.Location = new System.Drawing.Point(550, 663);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(155, 38);
            this.btnInHoaDon.TabIndex = 3;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnTraLai
            // 
            this.btnTraLai.BackColor = System.Drawing.Color.White;
            this.btnTraLai.FlatAppearance.BorderSize = 0;
            this.btnTraLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraLai.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraLai.Location = new System.Drawing.Point(6, 614);
            this.btnTraLai.Name = "btnTraLai";
            this.btnTraLai.Size = new System.Drawing.Size(135, 38);
            this.btnTraLai.TabIndex = 3;
            this.btnTraLai.Text = "Tiền thừa";
            this.btnTraLai.UseVisualStyleBackColor = false;
            this.btnTraLai.Click += new System.EventHandler(this.btnTraLai_Click);
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Location = new System.Drawing.Point(511, 564);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(156, 29);
            this.txtKhachDua.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(505, 518);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(26, 27);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "0";
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(680, 170);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(21, 22);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "0";
            // 
            // lblTraLai
            // 
            this.lblTraLai.AutoSize = true;
            this.lblTraLai.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraLai.Location = new System.Drawing.Point(506, 614);
            this.lblTraLai.Name = "lblTraLai";
            this.lblTraLai.Size = new System.Drawing.Size(26, 27);
            this.lblTraLai.TabIndex = 0;
            this.lblTraLai.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Khách đưa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(96, 123);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(21, 22);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nhân viên:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(121, 170);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(20, 22);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "?";
            // 
            // frmHienThiHoaDon
            // 
            this.AcceptButton = this.btnTraLai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 713);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHienThiHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHienThiHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonTheoHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSMonTheoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcThanhTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnTraLai;
        private System.Windows.Forms.TextBox txtKhachDua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTraLai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label6;
    }
}