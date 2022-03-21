using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
namespace WindowsFormsApp1
{
    public partial class frmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        DateTime TuNgay;
        DateTime DenNgay;
        NhomMonBUS nmBus = new NhomMonBUS();

        public frmBaoCao()
        {
            InitializeComponent();
        }

        public frmBaoCao(DateTime tungay, DateTime denngay):this()
        {
            TuNgay = tungay;
            DenNgay = denngay;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            radChiTietHoaDon.Checked = true;
            cboLoaiThucUong.DataSource = nmBus.LayDanhSachNhomMon();
            cboLoaiThucUong.DisplayMember = "TenNhom";
            cboLoaiThucUong.ValueMember = "IDNhom";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
          
            if(radChiTietHoaDon.Checked)
            {
                rpCT_HD rp = new rpCT_HD(TuNgay, DenNgay);
             
                ReportPrintTool tool = new ReportPrintTool(rp);
                tool.ShowPreview();
            }  
            
            if(radLoaiThucUong.Checked)
            {
                rpLoaiThucUong rp = new rpLoaiThucUong(TuNgay, DenNgay, cboLoaiThucUong.Text);

                ReportPrintTool tool = new ReportPrintTool(rp);
                tool.ShowPreview();
            }

            if (radNhomThucUongAll.Checked)
            {
                rpNhomThucUong rp = new rpNhomThucUong(TuNgay, DenNgay);

                ReportPrintTool tool = new ReportPrintTool(rp);
                tool.ShowPreview();
            }

            if (radDoanhThu.Checked)
            {
                rpDoanhThu rp = new rpDoanhThu(TuNgay, DenNgay);

                ReportPrintTool tool = new ReportPrintTool(rp);
                tool.ShowPreview();
            }
        }

        private void radLoaiSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (radLoaiThucUong.Checked)
            {
                cboLoaiThucUong.Enabled = true;
                return;
            }
            cboLoaiThucUong.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}