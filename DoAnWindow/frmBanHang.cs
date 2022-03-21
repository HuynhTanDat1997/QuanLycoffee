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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        string Taikhoan = "";//xác định quyền đang xử dụng
        public int IDnv = 0;//ID người dùng
        public string NguoiDung = "";//Người dùng tk

        BanBUS banBus = new BanBUS();
        NhomMonBUS nmBus = new NhomMonBUS();
        public MonBUS monBus = new MonBUS();
        CTHoaDonBUS cthdBus = new CTHoaDonBUS();
        HoaDonBUS hdBus = new HoaDonBUS();
        TaiKhoanBUS tkBus = new TaiKhoanBUS();

        public DateTime day = DateTime.Now;
        public string trangthaimacdinh = "Chưa chọn bàn";
        public string trangthai1 = "Trống";
        public string trangthai2 = "Đang phục vụ";
        public string giomacdinh = "Chưa mở";
        public string tamtinhmacdinh = "0";
        public string tenbanmacdinh = "Tên bàn";
        public int idnhom;
        public int idban;
        public int idmenu;
        public int idhd;
        int soluong = 1;//mặc định khi thêm vào listview  
        
        
        public frmBanHang()
        {
            InitializeComponent();
        }

        public frmBanHang(string taikhoan):this()
        {
            Taikhoan = taikhoan;
        }

        public void ThongTinTK(string taikhoan)
        {
            NguoiDung = tkBus.NguoiDungTK(taikhoan);
            IDnv = tkBus.IDNguoiDungTK(taikhoan);
        }

        public void frmBanHang_Load_1(object sender, EventArgs e)
        {
            ThongTinTK(Taikhoan);

            HienThiBan();
            HienThiNhomMon();

            this.Text = NguoiDung;

            grNhomMon.Visible = false;
            grChonMon.Visible = false;
            lstvChonMon.Visible = false;
            grChucNang.Visible = false;

            btnMoBan.Enabled = false;
            btnHuyBan.Enabled = false;

            btnXoa.Visible = false;
        }

        public void Macdinh()
        {
            lblTenBan.Text = tenbanmacdinh;
            lblTrangThai.Text = trangthaimacdinh;
            lblGioVao.Text = giomacdinh;
            lblTamTinh.Text = tamtinhmacdinh;

            grNhomMon.Visible = false;
            grChonMon.Visible = false;
            lstvChonMon.Visible = false;
            grChucNang.Visible = false;
            btnMoBan.Enabled = false;
            btnHuyBan.Enabled = false;
            btnXoa.Visible = false;

            grChuThich.Visible = true;
            grThongTinBan.Visible = true;
            grHome.Visible = true;
        }    

        public void btnban_Click(object sender, EventArgs e)
        {
            idban = (int)((Button)sender).Tag;

            BanDTO ban = banBus.LayThongTinTheoBan(idban);

            lblTenBan.Text = ban.TenBan;
            lblTrangThai.Text = ban.TrangThai;

            switch (ban.TrangThai)
            {
                case ("Trống"):
                    btnMoBan.Enabled = true;

                    btnHuyBan.Enabled = false;
                    grChucNang.Visible = false;
                    grChonMon.Visible = false;
                    grNhomMon.Visible = false;
                    lstvChonMon.Visible = false;
                    btnXoa.Visible = false;

                    lblGioVao.Text = giomacdinh;//Chưa mở
                    lblTamTinh.Text = tamtinhmacdinh; // 0
                    break;
                default:
                    btnMoBan.Enabled = false;
                    btnHuyBan.Enabled = true;
                    grNhomMon.Visible = true;
                    grChonMon.Visible = true;
                    lstvChonMon.Visible = true;
                    grChucNang.Visible = true;
                    btnXoa.Visible = true;

                    btnChuyenBan.Enabled = true;
                    btnTachBan.Enabled = true;

                    HoaDonDTO hd = hdBus.HDTheoBan(idban);
                    if(hd.IDHoaDon != 0)// đã có hóa đơn theo bàn
                    {
                       idhd = hd.IDHoaDon;
                       lblGioVao.Text = hd.NgayLap.ToString();
                       lblTamTinh.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 VNĐ}", hd.TongTien);
                    }
                    else// bàn chưa có hóa đơn nào
                    {
                        idhd = 0;
                        lblGioVao.Text = day.ToString();//Chưa mở
                        lblTamTinh.Text = tamtinhmacdinh; // 0
                    }    
                    
                    
                    break;
            }
            lstvChonMon.Items.Clear();
        }

        public void btnbantrong_Click(object sender, EventArgs e)
        {
            int idbanmoi = (int)((Button)sender).Tag;
           
            DialogResult dlr = MessageBox.Show("Bạn muốn chuyển sang bàn này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (dlr == DialogResult.Yes)
            {
                int kq = hdBus.CapNhatIDbanTrongHD(idhd, idbanmoi);
                if(kq == 0)
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                banBus.ChuyenTrangThai(idbanmoi, trangthai2);
               
                banBus.ChuyenTrangThai(idban, trangthai1);

               

                Macdinh();
                Loadlaiban();
            }
            
            if(dlr == DialogResult.Cancel)
            {
                grChonMon.Visible = true;
                grChucNang.Visible = true;
                grChuThich.Visible = true;
                grNhomMon.Visible = true;
                grThongTinBan.Visible = true;
                grHome.Visible = true;
                lstvChonMon.Visible = true;
                btnXoa.Visible = true;

                Loadlaiban();
            }
        }
  
        private void btnNhomMon_Click(object sender, EventArgs e)
        {
            grChonMon.Visible = true;
          
            idnhom = (int)((Button)sender).Tag;
            flpChonMon.Controls.Clear();
            HienThiMonTheoNhom(idnhom);
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            if(lblTamTinh.Text != tamtinhmacdinh)
            {
                MessageBox.Show("Không thể hủy bàn chưa thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            grNhomMon.Visible = false;
            grChonMon.Visible = false;
            lstvChonMon.Visible = false;
            btnXoa.Visible = false;
            grChucNang.Visible = false;
            btnHuyBan.Enabled = false;

            lblTrangThai.Text = trangthai1;//Trống
            lblGioVao.Text = giomacdinh;//Chưa mở
            banBus.ChuyenTrangThai(idban, lblTrangThai.Text);

            flpDanhSachBan.Controls.Clear();
            HienThiBan();
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            grNhomMon.Visible = true;
            grChonMon.Visible = true;
            lstvChonMon.Visible = true;
            btnXoa.Visible = true;
            grChucNang.Visible = true;
            btnMoBan.Enabled = false;
            
            lblTrangThai.Text = trangthai2;//Đang phục vụ
            lblGioVao.Text = day.ToString();

            banBus.ChuyenTrangThai(idban, lblTrangThai.Text);
            
            flpDanhSachBan.Controls.Clear();
            HienThiBan();
        }
        
        private void btnMonTheoNhom_Click(object sender, EventArgs e)//chọn món vào listview
        {
            idmenu = (int)((Button)sender).Tag;

            MonDTO mon = monBus.LayThongTinTheoMon(idmenu);

               for(int i = 0; i<lstvChonMon.Items.Count;i++)
                {                 
                    if(lstvChonMon.Items[i].SubItems[1].Text == mon.TenMon)
                    {                       
                        int tang = int.Parse(lstvChonMon.Items[i].SubItems[2].Text);
                        tang++;
                        lstvChonMon.Items[i].SubItems[2].Text = tang.ToString();
                        
                        return;
                    }                     
                }

               
            ListViewItem item = new ListViewItem();
                
            item.Text = mon.IDMeNu.ToString();
            
            item.SubItems.Add(mon.TenMon);
            
            item.SubItems.Add(soluong.ToString());
              
            item.SubItems.Add(mon.Gia.ToString());
            
            item.SubItems.Add(mon.DonViTinh);
           
            lstvChonMon.Items.Add(item);

        }

        public void HienThiBan()
        {
            List<BanDTO> danhsachban = banBus.LayDanhSachBan();
            flpDanhSachBan.Controls.Add(grChuThich);
            foreach (var item in danhsachban)
            {

                Button btnban = new Button();

                btnban.Width = 100;
                btnban.Height = 100;

                btnban.Text = item.TenBan;
                btnban.Image = Image.FromFile(HoTro._img);
                btnban.ImageAlign = ContentAlignment.MiddleCenter;
                btnban.TextImageRelation = TextImageRelation.ImageAboveText;
               
                switch(item.TrangThai)
                {
                    case ("Đang phục vụ"):                        
                        btnban.BackColor = Color.RosyBrown;
                        break;
                    default:
                        btnban.BackColor = Color.White;
                        break;
                }

                btnban.Tag = item.IDBan;

                btnban.Click += new EventHandler(btnban_Click);

                flpDanhSachBan.Controls.Add(btnban);
            }
        }

        public void HienThiBanDangTrong()
        {
            List<BanDTO> danhsachban = banBus.DanhSachBanTrong();
        
            foreach (var item in danhsachban)
            {

                Button btnban = new Button();

                btnban.Width = 100;
                btnban.Height = 100;

                btnban.Text = item.TenBan;
               
                btnban.Image = Image.FromFile(HoTro._img);
               
                btnban.ImageAlign = ContentAlignment.MiddleCenter;
               
                btnban.TextImageRelation = TextImageRelation.ImageAboveText;
               
                btnban.BackColor = Color.White;
                
                btnban.Tag = item.IDBan;

                btnban.Click += new EventHandler(btnbantrong_Click);

                flpDanhSachBan.Controls.Add(btnban);
            }
        }

        public void HienThiNhomMon()
        {
            List<NhomMonDTO> danhsachnhommon = nmBus.LayDanhSachNhomMon();

            foreach (var item in danhsachnhommon)
            {
                Button btnNM = new Button();
                btnNM.Width = 100;
                btnNM.Height = 60;
                btnNM.Text = item.TenNhom;
                btnNM.BackColor = Color.Red;
                btnNM.Tag = item.IDNhom;
                btnNM.Click += new EventHandler(btnNhomMon_Click);

                flpNhomMon.Controls.Add(btnNM);
            }
        }

        public void HienThiMonTheoNhom(int idnhom)
        {
            List<MonDTO> montheonhom = monBus.LayDSMonTheoNhom(idnhom);

            foreach (var item in montheonhom)
            {

                Button btnMonTheoNhom = new Button();

                btnMonTheoNhom.Width = 100;
                btnMonTheoNhom.Height = 50;
                btnMonTheoNhom.BackColor = Color.Green;
                btnMonTheoNhom.Text =string.Format("{0} {1}/{2}",item.TenMon, item.Gia, item.DonViTinh);
                btnMonTheoNhom.Tag = item.IDMeNu;
                
                btnMonTheoNhom.Click += new EventHandler(btnMonTheoNhom_Click);

                flpChonMon.Controls.Add(btnMonTheoNhom);
            }
        }

        private void btnTamTinh_Click(object sender, EventArgs e)
        {
            btnChuyenBan.Enabled = false;
            btnTachBan.Enabled = false;
            //kiểm tra có món nào được chọn chưa
            if (lstvChonMon.Items.Count == 0)//chưa có món nào trong listview
            {
                MessageBox.Show("Chưa chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //-------Đã chọn món-------
            btnHuyBan.Enabled = false;
            //Tạm tính hóa đơn
            float tamtinh = 0;
            for(int i = 0; i < lstvChonMon.Items.Count; i++)
            {
                int sl = int.Parse(lstvChonMon.Items[i].SubItems[2].Text);
                float dg = float.Parse(lstvChonMon.Items[i].SubItems[3].Text);
                tamtinh += (sl*dg);
            }
            // Kiểm tra bàn này đã có hóa đơn chưa
            if(hdBus.KTHoaDon(idban)) // Th bàn đã có hóa đơn
            {
                int kq = hdBus.CapNhatTongTien(idban, tamtinh);
                if(kq == 0)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                HoaDonDTO hd = hdBus.HDTheoBan(idban);
                ThemCTHD(hd.IDHoaDon);
                lblTamTinh.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 VNĐ}", hd.TongTien);
            }  
            else// TH bàn chưa có hóa đơn
            {
                //Thêm hd
                int themhd = hdBus.ThemHD(idban, IDnv, tamtinh);
                if (themhd == 1)//Thêm hd thành công
                {
                    int idhd = hdBus.IDHoaDon();//lấy id hóa đơn
                    //Thêm cthd
                    ThemCTHD(idhd);
                    //hiển thị
                    HoaDonDTO hd = hdBus.HDTheoBan(idban);
                    lblGioVao.Text = hd.NgayLap.ToString();
                    lblTamTinh.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 VNĐ}", hd.TongTien);
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            lstvChonMon.Items.Clear();
            
        }

        public void ThemCTHD(int idhd)
        {
            int idmon;
 
            int sl;
            float gia;
            for (int i = 0; i < lstvChonMon.Items.Count; i++)
            {
                idmon = int.Parse(lstvChonMon.Items[i].SubItems[0].Text);
                //tenmon = lstvChonMon.Items[i].SubItems[1].Text;
                sl = int.Parse(lstvChonMon.Items[i].SubItems[2].Text);
                gia = float.Parse(lstvChonMon.Items[i].SubItems[3].Text);
                int cthd = cthdBus.ThemCT_HD(idhd, idmon, sl, (sl * gia));
                if(cthd == 0)
                {
                    MessageBox.Show("Lỗi hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu trangchu = new frmTrangChu(Taikhoan);
            trangchu.ShowDialog();
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(lblTamTinh.Text == tamtinhmacdinh)
            {
                MessageBox.Show("Bàn này hiện chưa có hóa đơn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   
            
            frmHienThiHoaDon hoadon = new frmHienThiHoaDon(idban, this);
            hoadon.Show();
            hoadon.Focus();
           
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {            
            grChonMon.Visible = false;
            grChucNang.Visible = false;
            grChuThich.Visible = false;
            grNhomMon.Visible = false;
            grThongTinBan.Visible = false;
            grHome.Visible = false;
            lstvChonMon.Visible = false;
            btnXoa.Visible = false;

            flpDanhSachBan.Controls.Clear();

            HienThiBanDangTrong();
        }

        public void Loadlaiban()
        {
            flpDanhSachBan.Controls.Clear();
            HienThiBan();
        }

        private void frmBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F4)
            {
                btnThanhToan_Click(null, null);
            }    
            
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvChonMon.Items)
            {
                if (item.Selected)
                    lstvChonMon.Items.Remove(item);
            }
        }

        private void btnTangMon_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in lstvChonMon.Items)
            {
                if (item.Selected)
                {
                    int soluong = int.Parse(item.SubItems[2].Text);
                    soluong++;
                    item.SubItems[2].Text = soluong.ToString();
                } 
            }
        }

        private void btnGiamMon_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvChonMon.Items)
            {
                if (item.Selected)
                {
                    int soluong = int.Parse(item.SubItems[2].Text);
                    soluong--;
                    if(soluong == 0)
                    {
                        lstvChonMon.Items.Remove(item);
                        return;
                    }    
                    item.SubItems[2].Text = soluong.ToString();
                }
            }
        }

        private void btnTachBan_Click(object sender, EventArgs e)
        {
            if(lblTamTinh.Text == tamtinhmacdinh)
            {
                MessageBox.Show("Bàn này hiện chưa có hóa đơn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            frmTachBan f = new frmTachBan(idban, this);
            f.Show();
        }
    }
}

