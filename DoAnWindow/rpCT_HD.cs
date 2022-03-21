using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class rpCT_HD : DevExpress.XtraReports.UI.XtraReport
    {
        public rpCT_HD()
        {
            InitializeComponent();
        }

       public rpCT_HD(DateTime tungay, DateTime denngay):this()
        {
            TuNgay.Value = tungay;
            DenNgay.Value = denngay;
        }
    }
}
