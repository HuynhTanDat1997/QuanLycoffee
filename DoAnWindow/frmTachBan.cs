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
namespace WindowsFormsApp1
{
    public partial class frmTachBan : DevExpress.XtraEditors.XtraForm
    {
        frmBanHang banhang;
        int IDBancu;
        BanBUS banBus = new BanBUS();
        HoaDonBUS hdBus = new HoaDonBUS();
        HoaDonThanhToanBUS hdttBus = new HoaDonThanhToanBUS();
        CTHoaDonBUS cthdBus = new CTHoaDonBUS();
        float TongTienHDcu = 0;
        float TongTienHDmoi = 0;
        public frmTachBan()
        {
            InitializeComponent();
        }

        public frmTachBan (int idban, frmBanHang f):this()
        {
            banhang = f;
            IDBancu = idban;
        }

        private void frmTachBan_Load(object sender, EventArgs e)
        {
            cboChonBanTach.DataSource = banBus.DanhSachBanTrong();
            cboChonBanTach.DisplayMember = "TenBan";
            cboChonBanTach.ValueMember = "IDBan";

            BanDTO ban = banBus.LayThongTinTheoBan(IDBancu);
            lblBanCanTach.Text = ban.TenBan;

            HoaDonDTO hd =  hdBus.HDTheoBan(IDBancu);
            List<HoaDonThanhToanDTO> list = hdttBus.LayDSMonTheoHD(hd.IDHoaDon);
            
            foreach (var mon in list)
            {
                ListViewItem item = new ListViewItem();

                item.Text = mon.IDMenu.ToString();

                item.SubItems.Add(mon.TenMon);

                item.SubItems.Add(mon.SoLuong.ToString());

                item.SubItems.Add(mon.DonGia.ToString());

                item.SubItems.Add(mon.ThanhTien.ToString());

                lstvBanDuocTach.Items.Add(item);
            }    
        }

        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "*";
            if(lstvBanDuocTach.Items.Count == 1)
            {
                return;
            }    
           foreach(ListViewItem item in lstvBanDuocTach.Items)
            {
                if(item.Selected)
                {
                    lstvBanDuocTach.Items.Remove(item);
                    lstvBanTach.Items.Add(item);
                }    
            }    
        }

        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvBanTach.Items)
            {
                if (item.Selected)
                {
                    lstvBanTach.Items.Remove(item);
                    lstvBanDuocTach.Items.Add(item);
                }
            }
        }

        private void btnTachBan_Click(object sender, EventArgs e)
        {
           
            if (lstvBanTach.Items.Count == 0)
            {
                lblThongBao.Text = "Hãy dùng mũi tên bên dưới để chọn những món cần tách";
                return;
            }
            else
            {
                lblThongBao.Text = "*";
               
                if (MessageBox.Show("Xác nhận tách bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                for (int i = 0; i < lstvBanDuocTach.Items.Count; i++)
                {

                    int sl = Int32.Parse(lstvBanDuocTach.Items[i].SubItems[2].Text);
                    int dongia = Int32.Parse(lstvBanDuocTach.Items[i].SubItems[3].Text);

                    TongTienHDcu += sl * dongia;
                }

                for (int i = 0; i < lstvBanTach.Items.Count; i++)
                {

                    int sl = Int32.Parse(lstvBanTach.Items[i].SubItems[2].Text);
                    int dongia = Int32.Parse(lstvBanTach.Items[i].SubItems[3].Text);

                    TongTienHDmoi += sl * dongia;

                }

                int idbanmoi = int.Parse(cboChonBanTach.SelectedValue.ToString());

                HoaDonDTO hdcu = hdBus.HDTheoBan(IDBancu);

                //b1: Cập nhật tổng tiền hóa đơn cũ
                int kq = hdBus.TongTienSauTach(IDBancu, TongTienHDcu);

                //b2: Tạo hóa đơn mới
                int themhd = hdBus.ThemHD(idbanmoi, banhang.IDnv, TongTienHDmoi);

                HoaDonDTO hdmoi = hdBus.HDTheoBan(idbanmoi);

                //b3: Đổi  ID hóa đơn cũ trong cthd thành id hóa đơn mới
                for (int i = 0; i < lstvBanTach.Items.Count; i++)
                {
                    int idmeu = int.Parse(lstvBanTach.Items[i].SubItems[0].Text);

                    int cthd = cthdBus.TachCT_HD(hdmoi.IDHoaDon, hdcu.IDHoaDon, idmeu);
                    if (cthd == 0)
                    {
                        MessageBox.Show("Lỗi hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (kq == 0 || themhd == 0)
                {
                    MessageBox.Show("Lỗi hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //b4: Đổi trạng thái bàn
                banBus.ChuyenTrangThai(idbanmoi, banhang.trangthai2); // trạng thái đang phục vụ

                banhang.Loadlaiban();

                banhang.Macdinh();

                this.Close();
            }    
           
        }
    }
}