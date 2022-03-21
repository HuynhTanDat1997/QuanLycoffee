using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraReports.UI;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class frmHienThiHoaDon : DevExpress.XtraEditors.XtraForm
    {
        int IDBan;
        

        HoaDonBUS hdBus = new HoaDonBUS();
        HoaDonThanhToanBUS hdttBus = new HoaDonThanhToanBUS();
        HoaDonDTO hd;
        BanBUS banBus = new BanBUS();
        
        frmBanHang banhang;

        public frmHienThiHoaDon()
        {
            InitializeComponent();
        }

        public frmHienThiHoaDon(int idban, frmBanHang f):this()
        {         
            IDBan = idban;
            this.banhang = f;
        }

        private void frmHienThiHoaDon_Load(object sender, EventArgs e)
        {
            hd = hdBus.HDTheoBan(IDBan);
            
            lblSoHD.Text = hd.IDHoaDon.ToString();
           
            BanDTO ban = banBus.LayThongTinTheoBan(IDBan);
            lblTenBan.Text = ban.TenBan;
            
            lblNhanVien.Text = banhang.NguoiDung;
            
            lblThoiGian.Text = hd.NgayLap.ToString();
            
            lblTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 VNĐ}", hd.TongTien);

            dgvDSMonTheoHD.AutoGenerateColumns = false;
            dgvDSMonTheoHD.DataSource = hdttBus.LayDSMonTheoHD(hd.IDHoaDon);
        }

        private void btnTraLai_Click(object sender, EventArgs e)
        {
            float tralai = float.Parse(txtKhachDua.Text) - float.Parse(hd.TongTien.ToString());
            if (tralai < 0)
            {
                MessageBox.Show("Số tiền tối thiểu là: " + lblTongTien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblTraLai.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 VNĐ}", tralai);

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            //chuyển trạng thái hóa đơn thành đã thanh toán
            int kq = hdBus.ThanhToanHD(hd.IDHoaDon);
            if (kq == 0)
            {
                MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Chuyển trạng thái bàn
            banBus.ChuyenTrangThai(IDBan, banhang.trangthai1); // trạng thái trống

            banhang.Loadlaiban();

            banhang.Macdinh();

            this.Close();

            rpInHoaDon rp = new rpInHoaDon();
            rp.FilterString = "[IDHoaDon] = " + hd.IDHoaDon + "";
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

     
    }
}