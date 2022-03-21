using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class rpNhomThucUong : DevExpress.XtraReports.UI.XtraReport
    {
        public rpNhomThucUong()
        {
            InitializeComponent();
        }
        public rpNhomThucUong(DateTime tungay, DateTime denngay) : this()
        {
            TuNgay.Value = tungay;
            DenNgay.Value = denngay;
        }
    }
}
