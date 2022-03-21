using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class rpDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDoanhThu()
        {
            InitializeComponent();
        }

        public rpDoanhThu(DateTime tungay, DateTime denngay) : this()
        {
            TuNgay.Value = tungay;
            DenNgay.Value = denngay;
        }
    }
}
