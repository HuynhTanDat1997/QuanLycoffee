
namespace WindowsFormsApp1
{
    partial class frmTrangChu
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.itemBanHang = new DevExpress.XtraEditors.TileItem();
            this.itemQuanLy = new DevExpress.XtraEditors.TileItem();
            this.itemBaoCao = new DevExpress.XtraEditors.TileItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trang chủ";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.BackColor = System.Drawing.Color.Black;
            this.lblNguoiDung.ForeColor = System.Drawing.Color.White;
            this.lblNguoiDung.Location = new System.Drawing.Point(64, 27);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(93, 19);
            this.lblNguoiDung.TabIndex = 3;
            this.lblNguoiDung.Text = "Người dùng";
            this.lblNguoiDung.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_x_50;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(1033, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(37, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Black;
            this.btnDangXuat.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_logout_rounded_left_32;
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Location = new System.Drawing.Point(963, 26);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(46, 34);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.anh_ly_cafe_buoi_sang_1;
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 200;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 6;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(0, 18, 18, 18);
            this.tileControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tileControl1.SelectionColor = System.Drawing.Color.Red;
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.Size = new System.Drawing.Size(1094, 591);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.itemBanHang);
            this.tileGroup2.Items.Add(this.itemQuanLy);
            this.tileGroup2.Items.Add(this.itemBaoCao);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // itemBanHang
            // 
            tileItemElement1.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.Iconbanhang;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "<color=black><size=13>Bán hàng </size></color><br>(Ctrl+F1)</br>";
            this.itemBanHang.Elements.Add(tileItemElement1);
            this.itemBanHang.Id = 0;
            this.itemBanHang.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.itemBanHang.Name = "itemBanHang";
            this.itemBanHang.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.itemBanHang_ItemClick);
            // 
            // itemQuanLy
            // 
            tileItemElement2.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.IconQuanLy;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "<color=black><size=13>Quản lý</size></color><br> (Ctrl+F2)</br>";
            this.itemQuanLy.Elements.Add(tileItemElement2);
            this.itemQuanLy.Id = 1;
            this.itemQuanLy.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.itemQuanLy.Name = "itemQuanLy";
            this.itemQuanLy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.itemQuanLy_ItemClick);
            // 
            // itemBaoCao
            // 
            tileItemElement3.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.Iconthongke;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "<color=black><size=13>Báo cáo thống kê</size></color><br>(Ctrl+F3)</br>";
            this.itemBaoCao.Elements.Add(tileItemElement3);
            this.itemBaoCao.Id = 3;
            this.itemBaoCao.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.itemBaoCao.Name = "itemBaoCao";
            this.itemBaoCao.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.itemBaoCao_ItemClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_user_24;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(17, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 34);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 591);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tileControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmTrangChu.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrangChu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem itemBanHang;
        private DevExpress.XtraEditors.TileItem itemQuanLy;
        private DevExpress.XtraEditors.TileItem itemBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}