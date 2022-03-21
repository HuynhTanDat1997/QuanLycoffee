
namespace WindowsFormsApp1
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.radChiTietHoaDon = new System.Windows.Forms.RadioButton();
            this.radLoaiThucUong = new System.Windows.Forms.RadioButton();
            this.radDoanhThu = new System.Windows.Forms.RadioButton();
            this.cboLoaiThucUong = new System.Windows.Forms.ComboBox();
            this.radNhomThucUongAll = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBaoCao.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(268, 190);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(178, 41);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Lập báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // radChiTietHoaDon
            // 
            this.radChiTietHoaDon.AutoSize = true;
            this.radChiTietHoaDon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChiTietHoaDon.Location = new System.Drawing.Point(12, 22);
            this.radChiTietHoaDon.Name = "radChiTietHoaDon";
            this.radChiTietHoaDon.Size = new System.Drawing.Size(194, 28);
            this.radChiTietHoaDon.TabIndex = 1;
            this.radChiTietHoaDon.TabStop = true;
            this.radChiTietHoaDon.Text = "Chi tiết hóa đơn";
            this.radChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // radLoaiThucUong
            // 
            this.radLoaiThucUong.AutoSize = true;
            this.radLoaiThucUong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLoaiThucUong.Location = new System.Drawing.Point(243, 78);
            this.radLoaiThucUong.Name = "radLoaiThucUong";
            this.radLoaiThucUong.Size = new System.Drawing.Size(185, 28);
            this.radLoaiThucUong.TabIndex = 1;
            this.radLoaiThucUong.TabStop = true;
            this.radLoaiThucUong.Text = "Loại thức uống";
            this.radLoaiThucUong.UseVisualStyleBackColor = true;
            this.radLoaiThucUong.CheckedChanged += new System.EventHandler(this.radLoaiSanPham_CheckedChanged);
            // 
            // radDoanhThu
            // 
            this.radDoanhThu.AutoSize = true;
            this.radDoanhThu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDoanhThu.Location = new System.Drawing.Point(12, 78);
            this.radDoanhThu.Name = "radDoanhThu";
            this.radDoanhThu.Size = new System.Drawing.Size(140, 28);
            this.radDoanhThu.TabIndex = 1;
            this.radDoanhThu.TabStop = true;
            this.radDoanhThu.Text = "Doanh thu";
            this.radDoanhThu.UseVisualStyleBackColor = true;
            // 
            // cboLoaiThucUong
            // 
            this.cboLoaiThucUong.Enabled = false;
            this.cboLoaiThucUong.FormattingEnabled = true;
            this.cboLoaiThucUong.Location = new System.Drawing.Point(259, 112);
            this.cboLoaiThucUong.Name = "cboLoaiThucUong";
            this.cboLoaiThucUong.Size = new System.Drawing.Size(156, 27);
            this.cboLoaiThucUong.TabIndex = 2;
            // 
            // radNhomThucUongAll
            // 
            this.radNhomThucUongAll.AutoSize = true;
            this.radNhomThucUongAll.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhomThucUongAll.Location = new System.Drawing.Point(243, 22);
            this.radNhomThucUongAll.Name = "radNhomThucUongAll";
            this.radNhomThucUongAll.Size = new System.Drawing.Size(203, 28);
            this.radNhomThucUongAll.TabIndex = 1;
            this.radNhomThucUongAll.TabStop = true;
            this.radNhomThucUongAll.Text = "Nhóm thức uống";
            this.radNhomThucUongAll.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBaoCao
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(458, 243);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboLoaiThucUong);
            this.Controls.Add(this.radDoanhThu);
            this.Controls.Add(this.radNhomThucUongAll);
            this.Controls.Add(this.radLoaiThucUong);
            this.Controls.Add(this.radChiTietHoaDon);
            this.Controls.Add(this.btnBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmBaoCao.IconOptions.SvgImage")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.RadioButton radChiTietHoaDon;
        private System.Windows.Forms.RadioButton radLoaiThucUong;
        private System.Windows.Forms.RadioButton radDoanhThu;
        private System.Windows.Forms.ComboBox cboLoaiThucUong;
        private System.Windows.Forms.RadioButton radNhomThucUongAll;
        private System.Windows.Forms.Button button1;
    }
}