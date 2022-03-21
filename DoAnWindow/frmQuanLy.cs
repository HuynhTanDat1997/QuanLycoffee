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
using DevExpress.XtraBars.Docking2010;

namespace WindowsFormsApp1
{
    public partial class frmQuanLy : DevExpress.XtraEditors.XtraForm
    {
        string TaiKhoan = "";
        string Nguoidung = "";
        //Khai báo biến
        private NhanVienBUS nvBus = new NhanVienBUS();

        private TaiKhoanBUS tkBus = new TaiKhoanBUS();

        private MonBUS monBus = new MonBUS();

        private NhomMonBUS nmBus = new NhomMonBUS();

        private BanBUS banBus = new BanBUS();

        private int bodemBan = 0;//dùng tăng tự động số bàn

        private int IdNhanVien; // dùng chỉnh sửa thông tin nhân viên

        private int Idmon; // dùng chỉnh sửa thông tin món

        private int IdNhomMon; // dùng chỉnh sửa thông tin nhóm món

        public frmQuanLy()
        {
            InitializeComponent();

           this.dtgvMenu.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgvMenu_DataError);
        }

        private void dtgvMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        public frmQuanLy(string taikhoan) : this()
        {
            TaiKhoan = taikhoan; //nhận tài khoản đang đăng nhập
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadTaiKhoan();
            LoadMenu();
            LoadNhomMon();
            LoadBan();

            Nguoidung = tkBus.NguoiDungTK(TaiKhoan);
            this.Text = Nguoidung;
        }
      
        // Hàm chức năng button
        private void Home()
        {
            this.Hide();
            frmTrangChu trangchu = new frmTrangChu(TaiKhoan);
            trangchu.ShowDialog();
            this.Close();
        }
        private void BanHang()
        {
            this.Hide();
            frmBanHang banhang = new frmBanHang(TaiKhoan);
            banhang.ShowDialog();
            this.Close();
        }
        private void ThongKe()
        {
            this.Hide();
            frmBaoCaoThongKe thongke = new frmBaoCaoThongKe(TaiKhoan);
            thongke.ShowDialog();
            this.Close();
        }

        #region Form Load

        public void LoadNhanVien()
        {
            radNam.Checked = true;

            btnLuu.Enabled = false;

            dtgvDanhSachNV.AutoGenerateColumns = false;
            dtgvDanhSachNV.DataSource = nvBus.LayDanhSachNV();
        }

        public void LoadTaiKhoan()
        {
            dgvcNhanVien.DataSource = nvBus.LayDanhSachNV();
            dgvcNhanVien.DisplayMember = "HoVaTen";
            dgvcNhanVien.ValueMember = "IDNhanVien";

            dtgvDanhSachTK.AutoGenerateColumns = false;
            dtgvDanhSachTK.DataSource = tkBus.LayDanhSachTK();
        }

        public void ComboboxNhomMon()
        {
            cboNhom.DataSource = nmBus.LayDanhSachNhomMon();
            cboNhom.DisplayMember = "TenNhom";
            cboNhom.ValueMember = "IDNhom";

        }
        public void LoadMenu()
        {
            btnLuuMon.Enabled = false;

            ComboboxNhomMon();
            //combobox datagridview
            dgvcNhom.DataSource = nmBus.LayDanhSachNhomMon();
            dgvcNhom.DisplayMember = "TenNhom";
            dgvcNhom.ValueMember = "IDNhom";


            dtgvMenu.AutoGenerateColumns = false;
            dtgvMenu.DataSource = monBus.LayDanhSachMenu();

            //Đếm số lượng món
            lblTong.Text = dtgvMenu.RowCount.ToString();
        }

        public void LoadNhomMon()
        {
            dtgvNhomMon.AutoGenerateColumns = false;
            dtgvNhomMon.DataSource = nmBus.LayDanhSachNhomMon();

            btnLuuNhom.Enabled = false;
            btnThemNhom.Enabled = true;
        }

        public void LoadBan()
        {
            dtgvBan.AutoGenerateColumns = false;
            dtgvBan.DataSource = banBus.LayDanhSachBan();
        }

        #endregion

        #region Quản lý nhân viên
        //Làm mới
        private void ClearNhanVien()
        {
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtCmnd.Text = string.Empty;
            txtSdt.Text = string.Empty;
            radNam.Checked = true;

            dtpNgaySinh.Value = DateTime.Now;
        }
        //Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;

            string DiaChi = txtDiaChi.Text;

            string Sdt = txtSdt.Text;

            string Cmnd = txtCmnd.Text;

            string GioiTinh = radNam.Text;
            if (radNu.Checked)
            {
                GioiTinh = radNu.Text;
            }

            DateTime NgaySinh = dtpNgaySinh.Value;

            int kq;

            if (String.IsNullOrEmpty(HoTen) || String.IsNullOrEmpty(DiaChi) || String.IsNullOrEmpty(Cmnd))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                if (nvBus.KiemTraCmnd(Cmnd))
                {
                    // Thực thi
                    kq = nvBus.ThemNhanVien(HoTen, GioiTinh, DiaChi, Sdt, Cmnd, NgaySinh);
                    //kiểm tra
                    if (kq == 1)// 0 thất bại
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadNhanVien();

                        ClearNhanVien();

                        frmThemTaiKhoan themtk = new frmThemTaiKhoan(this);
                        themtk.Show();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Chứng minh nhân dân đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        //Lưu chỉnh sửa
        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;

            string HoTen = txtHoTen.Text;

            string DiaChi = txtDiaChi.Text;

            string Sdt = txtSdt.Text;

            string Cmnd = txtCmnd.Text;

            string GioiTinh = radNam.Text;
            if (radNu.Checked)
            {
                GioiTinh = radNu.Text;
            }

            DateTime NgaySinh = dtpNgaySinh.Value;

            int kq;

            if (String.IsNullOrEmpty(HoTen) || String.IsNullOrEmpty(DiaChi) || String.IsNullOrEmpty(Cmnd))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn muốn lưu chỉnh sửa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    ClearNhanVien();
                    btnLuu.Enabled = false;
                    return;
                }
                else
                {
                    //Thực thi
                    kq = nvBus.SuaNhanVien(IdNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, Sdt, Cmnd);
                    //kiểm tra

                    if (kq == 0)
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK);
                    }

                    LoadNhanVien();

                    ClearNhanVien();
                }
            }
            
        }
        //Chức năng button
        private void navigationPage1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag)
            {
                case ("btnBanHang")://Thêm nhân viên
                    BanHang();                  
                    break;
                case ("btnThongKe")://Sửa nhân viên             
                    ThongKe();
                    break;

                case ("btnHome")://Trở về trang chủ
                    Home();
                    break;
            }
        }

        //Thực hiện chỉnh sửa nhân viên
        private void dtgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                IdNhanVien = Convert.ToInt32(dtgvDanhSachNV.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtHoTen.Text = dtgvDanhSachNV.Rows[e.RowIndex].Cells[1].Value.ToString();

                dtpNgaySinh.Value = Convert.ToDateTime(dtgvDanhSachNV.Rows[e.RowIndex].Cells[3].Value.ToString());

                string gioitinh = dtgvDanhSachNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (gioitinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtDiaChi.Text = dtgvDanhSachNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCmnd.Text = dtgvDanhSachNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtSdt.Text = dtgvDanhSachNV.Rows[e.RowIndex].Cells[5].Value.ToString();

                btnLuu.Enabled = true;
                btnThem.Enabled = false;
            }            
        }

        //Xóa nhân viên
        private void dtgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                int idnv = int.Parse(dtgvDanhSachNV.Rows[e.RowIndex].Cells[0].Value.ToString());

                TaiKhoanDTO tk = tkBus.TaiKhoanNV(idnv);//Kiểm tra nhân viên này đang sử dụng tài khoản nào

                if(tk!=null)
                {
                     if(tk.TaiKhoan == TaiKhoan)//Tài khoản này đang sử dụng
                    {
                        MessageBox.Show("Không thể xóa nhân viên đang sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                     else
                    {
                        if (MessageBox.Show("Xóa nhân viên này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int kqtk = tkBus.XoaTaiKhoan(tk.TaiKhoan);//Xóa tài khoản nhân viên đó trước
                                                                      //xóa nhân viên
                            int kqnv = nvBus.XoaNhanVien(idnv);

                            if (kqnv == 0 || kqtk == 0)
                            {
                                MessageBox.Show("Lỗi hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    

                            LoadNhanVien();
                            LoadTaiKhoan();
                        }
                    }    
                }
                else
                {
                    int kqnv = nvBus.XoaNhanVien(idnv);
                    if (kqnv == 0)
                    {
                        MessageBox.Show("Lỗi hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            
            }
        }

        //Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            ClearNhanVien();
        }

        #endregion

        #region Quản lý tài khoản

        //Xóa tài khoản
        private void dtgvDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                if (dtgvDanhSachTK.Rows[e.RowIndex].Cells[0].Value.ToString() == TaiKhoan)
                {
                    MessageBox.Show("Không thể xóa tài khoản đang dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Xóa tài khoản này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int kq = tkBus.XoaTaiKhoan(dtgvDanhSachTK.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if(kq == 0)
                        {
                            MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }    
                        LoadTaiKhoan();
                    }
                }

            }
        }

        //Đăng ký tài khoản 
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frmThem = new frmThemTaiKhoan(this);

            frmThem.Show();
        }

        //Đổi mật khẩu
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoimatKhau frmDoi = new frmDoimatKhau(this);
            frmDoi.Show();
        }

        //chức năng button
        private void pageQuanLyTaiKhoan_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag)
            {
                case ("btnBanHang"):
                    BanHang();
                    break;

                case ("btnThongKe"):
                    ThongKe();
                    break;

                case ("btnHome"):

                    Home();

                    break;
            }
        }
        #endregion

        #region Quản lý Menu

        // clear Menu
        public void ClearMenu()
        {
            txtTenMon.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
            cboNhom.SelectedIndex = 0;
        }

        // Chỉnh sửa hoặc xóa món
        private void dtgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉnh sửa món
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                Idmon = Convert.ToInt32(dtgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtTenMon.Text = dtgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtGia.Text = dtgvMenu.Rows[e.RowIndex].Cells[3].Value.ToString();

                txtDonViTinh.Text = dtgvMenu.Rows[e.RowIndex].Cells[2].Value.ToString();

                cboNhom.SelectedValue = Convert.ToInt32(dtgvMenu.Rows[e.RowIndex].Cells[4].Value.ToString());

                btnLuuMon.Enabled = true;
                btnThemMon.Enabled = false;
            }
            //Xóa món
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Xóa thức uống này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   int kq = monBus.XoaMon(int.Parse(dtgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString()));

                    if(kq == 0)
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                    LoadMenu();
                }

                ClearMenu();
                btnThemMon.Enabled = true;
                btnLuu.Enabled = false;
            }

        }

        //Lưu chỉnh sửa
        private void btnLuuMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMon.Text) || string.IsNullOrEmpty(txtDonViTinh.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int idnhommon = int.Parse(cboNhom.SelectedValue.ToString());// lấy id nhóm món

                float gia = float.Parse(txtGia.Text.ToString());

                int sua = monBus.SuaMon(Idmon, txtTenMon.Text, idnhommon, txtDonViTinh.Text, gia);

                if (sua == 1)// 0 thất bại
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadMenu();                
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ClearMenu();
                btnThemMon.Enabled = true;
                btnLuuMon.Enabled = false;
            }
        }

        //Thêm món
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMon.Text) || string.IsNullOrEmpty(txtDonViTinh.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idnhommon = int.Parse(cboNhom.SelectedValue.ToString());// lấy id nhóm món

                float gia = float.Parse(txtGia.Text.ToString());

                if (monBus.KTTrungLapMon(txtTenMon.Text))
                {
                    int them = monBus.ThemMon(txtTenMon.Text, idnhommon, txtDonViTinh.Text, gia);

                    if (them == 1)// 0 thất bại
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadMenu();
                        ClearMenu();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Thức uống này đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        //Làm mới
        private void btnLamMoiMon_Click(object sender, EventArgs e)
        {
            ClearMenu();
            btnLuuMon.Enabled = false;
            btnThemMon.Enabled = true;
        }

        // Chức năng button
        private void pageQuanLyMenu_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag)
            {
                case ("btnBanHang"):
                    BanHang();                  
                    break;

                case ("btnThongKe"):
                    ThongKe();
                    break;

                case ("btnHome"):
                    Home();
                    break;
            }
        }

        #endregion

        #region Quản lý nhóm món
        //Thêm nhóm
        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhom.Text))
            {
                MessageBox.Show("Chưa điền tên nhóm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (nmBus.KiemTraNhomMon(txtTenNhom.Text))
                {
                    int kq = nmBus.ThemNhomMon(txtTenNhom.Text);

                    if (kq == 0)
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    LoadNhomMon();
                    ComboboxNhomMon();
                    ClearNhomMon();
                }
                else
                {
                    MessageBox.Show("Nhóm đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        //Làm mới
        private void btnLamMoiNhom_Click(object sender, EventArgs e)
        {
            ClearNhomMon();
            btnThemNhom.Enabled = true;
            btnLuuNhom.Enabled = false;
        }

        //clear
        public void ClearNhomMon()
        {
            txtTenNhom.Text = string.Empty;
        }

        //Chỉnh sửa hoặc Xóa nhóm món
        private void dtgvNhomMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xóa nhóm món
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Tất cả các món thuộc nhóm này cũng sẽ bị xóa, bạn có muốn 'Xóa' nhóm này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IdNhomMon = int.Parse(dtgvNhomMon.Rows[e.RowIndex].Cells[0].Value.ToString());

                    foreach (var item in monBus.LayDSMonTheoNhom(IdNhomMon))
                    {
                        monBus.XoaMon(item.IDMeNu);
                    }

                    int kq = nmBus.XoaNhomMon(IdNhomMon);

                    if (kq == 0)
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    LoadNhomMon();
                    LoadMenu();
                }
            }
            //Chỉnh sửa nhóm
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                IdNhomMon = int.Parse(dtgvNhomMon.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                txtTenNhom.Text = dtgvNhomMon.Rows[e.RowIndex].Cells[1].Value.ToString();

                btnLuuNhom.Enabled = true;
                btnThemNhom.Enabled = false;
            }    
        }

        //Lưu chỉnh sửa
        private void btnLuuNhom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhom.Text))
            {
                MessageBox.Show("Chưa điền tên nhóm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                
                int kq = nmBus.SuaNhomMon(IdNhomMon, txtTenNhom.Text);

                if (kq == 0)
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadNhomMon();

                ClearNhomMon();
            }
            btnLuuNhom.Enabled = false;
            btnThemNhom.Enabled = true;
        }

        //Chức năng button
        private void pageQuanlyNhomMon_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag)
            {
                case ("btnBanHang"):
                    BanHang();
                    break;

                case ("btnThongKe"):
                    ThongKe();
                    break;

                case ("btnHome"):

                    Home();

                    break;
            }
        }

        #endregion

        #region Quản lý bàn

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NumberBan.Value.ToString()))
            {
                MessageBox.Show("Chưa chọn số bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            bodemBan = Convert.ToInt32(NumberBan.Value);

            string Tenban = string.Format("Bàn {0}", bodemBan);//Định dạng tên bàn

            if (banBus.KTTenBan(Tenban))
            {
                MessageBox.Show("Bàn này đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kq = banBus.ThemBan(Tenban);

            if (kq == 0)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoadBan();
        }
        //Chức năng button
        private void pageQuanLyBan_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag)
            {
                case ("btnBanHang"):

                    BanHang();

                    break;

                case ("btnHome"):

                    Home();

                    break;
                case ("btnThongKe"):
                    ThongKe();
                    break;
            }
        }

        //Xóa bàn
        private void dtgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                int Idban = int.Parse(dtgvBan.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (dtgvBan.Rows[e.RowIndex].Cells[2].Value.ToString() == "Trống")
                {
                    if (MessageBox.Show("Xóa bàn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int kq = banBus.XoaBan(Idban);

                        if (kq == 0)
                        {
                            MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LoadBan();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa bàn đang phục vu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        #endregion

        #region Ràng buộc dữ liệu
        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                dtpNgaySinh.Value = DateTime.Now;
            }
        }









        #endregion

  
    }
}
