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
using BUS;
using DTO;
using System.Globalization;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApp1
{
    public partial class frmBaoCaoThongKe : DevExpress.XtraEditors.XtraForm
    {
        string TaiKhoan;
        string NguoiDung = "";
        private HoaDonBUS hdBus = new HoaDonBUS();
        private ThongKeMonBUS tkBus = new ThongKeMonBUS();
        TaiKhoanBUS taikhoanBus = new TaiKhoanBUS();

        DateTime denngay;
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
            
        }

        public frmBaoCaoThongKe(string taikhoan):this()
        {
            TaiKhoan = taikhoan;
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            NguoiDung = taikhoanBus.NguoiDungTK(TaiKhoan);
            lblNguoiDung.Text = NguoiDung;
            lblNguoiDung2.Text = NguoiDung;
            // Thống kê

            denngay = dtpDenNgay.Value.Date.AddHours(23).AddMinutes(59);
            double doanhthu = hdBus.DoanhThu(dtpTuNgay.Value.Date, denngay);

            lblDoanhThu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 VNĐ}", doanhthu);
           
            lblHDThanhToan.Text = hdBus.HDDaThanhToan(dtpTuNgay.Value.Date, denngay).ToString();
            
            lblHDChuaThanhToan.Text = hdBus.HDChuaThanhToan(dtpTuNgay.Value.Date, denngay).ToString();
            
            Series series = new Series("Thức uống", ViewType.Bar);
            series.DataSource = tkBus.ThongKeMonTheoNgay(dtpTuNgay.Value.Date, denngay);
            series.ArgumentDataMember = "TenMon";
            series.ValueDataMembers.AddRange("SoLuong");
            chartMon.Series.Add(series);

            // Xem hóa đơn

            dgvXemHoaDon.AutoGenerateColumns = false;
            dgvXemHoaDon.DataSource = hdBus.LayDanhSachHD();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            

            denngay = dtpDenNgay.Value.Date.AddHours(23).AddMinutes(59);
            double doanhthu = hdBus.DoanhThu(dtpTuNgay.Value.Date, denngay);

            lblDoanhThu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 VNĐ}", doanhthu);
            
            lblHDThanhToan.Text = hdBus.HDDaThanhToan(dtpTuNgay.Value.Date, denngay).ToString();
            
            lblHDChuaThanhToan.Text = hdBus.HDChuaThanhToan(dtpTuNgay.Value.Date, denngay).ToString();

            chartMon.Series.Clear();
            Series series = new Series("Thức uống", ViewType.Bar);
            series.DataSource = tkBus.ThongKeMonTheoNgay(dtpTuNgay.Value.Date, denngay);
            series.ArgumentDataMember = "TenMon";
            series.ValueDataMembers.AddRange("SoLuong");
            chartMon.Series.Add(series);
        }

     

        private void dgvXemHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idhd = Convert.ToInt32(dgvXemHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
           
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                rpInHoaDon rp = new rpInHoaDon();
                rp.FilterString = "[IDHoaDon] = " + idhd + "";
                ReportPrintTool tool = new ReportPrintTool(rp);
                tool.ShowPreview();
            } 
                
        }

        private void dtpTimKiemTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            if(dtpTimKiemTheoNgay.Value > DateTime.Now)
            {
                dtpTimKiemTheoNgay.Value = DateTime.Now;
            }    

            dgvXemHoaDon.AutoGenerateColumns = false;
            dgvXemHoaDon.DataSource = hdBus.LayDanhSachHDTheoNgay(dtpTimKiemTheoNgay.Value);
        }

        private void btnAllHD_Click(object sender, EventArgs e)
        {
            dtpTimKiemTheoNgay.Value = DateTime.Now;

            dgvXemHoaDon.AutoGenerateColumns = false;
            dgvXemHoaDon.DataSource = hdBus.LayDanhSachHD();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {

            frmBaoCao baocao = new frmBaoCao(dtpTuNgay.Value.Date, denngay);
            baocao.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu trangchu = new frmTrangChu(TaiKhoan);
            trangchu.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dangnhap = new frmDangNhap();
                dangnhap.ShowDialog();
                this.Close();
            }
        }

        private void dtpTuNgay_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtpDenNgay.Value < dtpTuNgay.Value || dtpTuNgay.Value > DateTime.Now)
            {
                dtpDenNgay.Value = DateTime.Now;
                dtpTuNgay.Value = DateTime.Now;
            }
        }

        private void dtpDenNgay_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtpDenNgay.Value < dtpTuNgay.Value || dtpDenNgay.Value > DateTime.Now)
            {
                dtpDenNgay.Value = DateTime.Now;
            }
        }
    }
}