using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class rpLoaiThucUong : DevExpress.XtraReports.UI.XtraReport
    {
        public rpLoaiThucUong()
        {
            InitializeComponent();
        }
        public rpLoaiThucUong(DateTime tungay, DateTime denngay, string tennhom) : this()
        {
            TuNgay.Value = tungay;
            DenNgay.Value = denngay;
            TenNhom.Value = tennhom;
        }
    }
}
