
namespace WindowsFormsApp1
{
    partial class frmTachBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstvBanDuocTach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstvBanTach = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboChonBanTach = new System.Windows.Forms.ComboBox();
            this.lblBanCanTach = new System.Windows.Forms.Label();
            this.btnChuyenTrai = new System.Windows.Forms.Button();
            this.btnChuyenPhai = new System.Windows.Forms.Button();
            this.btnTachBan = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstvBanDuocTach);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 476);
            this.panel1.TabIndex = 0;
            // 
            // lstvBanDuocTach
            // 
            this.lstvBanDuocTach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvBanDuocTach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvBanDuocTach.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvBanDuocTach.FullRowSelect = true;
            this.lstvBanDuocTach.GridLines = true;
            this.lstvBanDuocTach.HideSelection = false;
            this.lstvBanDuocTach.Location = new System.Drawing.Point(0, 0);
            this.lstvBanDuocTach.MultiSelect = false;
            this.lstvBanDuocTach.Name = "lstvBanDuocTach";
            this.lstvBanDuocTach.Size = new System.Drawing.Size(438, 476);
            this.lstvBanDuocTach.TabIndex = 1;
            this.lstvBanDuocTach.UseCompatibleStateImageBehavior = false;
            this.lstvBanDuocTach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 124;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstvBanTach);
            this.panel2.Location = new System.Drawing.Point(614, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 476);
            this.panel2.TabIndex = 0;
            // 
            // lstvBanTach
            // 
            this.lstvBanTach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstvBanTach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvBanTach.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvBanTach.FullRowSelect = true;
            this.lstvBanTach.GridLines = true;
            this.lstvBanTach.HideSelection = false;
            this.lstvBanTach.Location = new System.Drawing.Point(0, 0);
            this.lstvBanTach.MultiSelect = false;
            this.lstvBanTach.Name = "lstvBanTach";
            this.lstvBanTach.Size = new System.Drawing.Size(438, 476);
            this.lstvBanTach.TabIndex = 2;
            this.lstvBanTach.UseCompatibleStateImageBehavior = false;
            this.lstvBanTach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên món";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn giá";
            this.columnHeader8.Width = 124;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboChonBanTach);
            this.panel3.Controls.Add(this.lblThongBao);
            this.panel3.Controls.Add(this.lblBanCanTach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 64);
            this.panel3.TabIndex = 1;
            // 
            // cboChonBanTach
            // 
            this.cboChonBanTach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonBanTach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonBanTach.FormattingEnabled = true;
            this.cboChonBanTach.Location = new System.Drawing.Point(756, 15);
            this.cboChonBanTach.Name = "cboChonBanTach";
            this.cboChonBanTach.Size = new System.Drawing.Size(121, 37);
            this.cboChonBanTach.TabIndex = 1;
            // 
            // lblBanCanTach
            // 
            this.lblBanCanTach.AutoSize = true;
            this.lblBanCanTach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanCanTach.Location = new System.Drawing.Point(162, 18);
            this.lblBanCanTach.Name = "lblBanCanTach";
            this.lblBanCanTach.Size = new System.Drawing.Size(108, 29);
            this.lblBanCanTach.TabIndex = 0;
            this.lblBanCanTach.Text = "Tên bàn";
            // 
            // btnChuyenTrai
            // 
            this.btnChuyenTrai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenTrai.Location = new System.Drawing.Point(496, 182);
            this.btnChuyenTrai.Name = "btnChuyenTrai";
            this.btnChuyenTrai.Size = new System.Drawing.Size(75, 47);
            this.btnChuyenTrai.TabIndex = 2;
            this.btnChuyenTrai.Text = ">";
            this.btnChuyenTrai.UseVisualStyleBackColor = true;
            this.btnChuyenTrai.Click += new System.EventHandler(this.btnChuyenTrai_Click);
            // 
            // btnChuyenPhai
            // 
            this.btnChuyenPhai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenPhai.Location = new System.Drawing.Point(496, 251);
            this.btnChuyenPhai.Name = "btnChuyenPhai";
            this.btnChuyenPhai.Size = new System.Drawing.Size(75, 46);
            this.btnChuyenPhai.TabIndex = 2;
            this.btnChuyenPhai.Text = "<";
            this.btnChuyenPhai.UseVisualStyleBackColor = true;
            this.btnChuyenPhai.Click += new System.EventHandler(this.btnChuyenPhai_Click);
            // 
            // btnTachBan
            // 
            this.btnTachBan.BackColor = System.Drawing.Color.White;
            this.btnTachBan.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTachBan.ForeColor = System.Drawing.Color.Blue;
            this.btnTachBan.Location = new System.Drawing.Point(456, 354);
            this.btnTachBan.Name = "btnTachBan";
            this.btnTachBan.Size = new System.Drawing.Size(152, 54);
            this.btnTachBan.TabIndex = 2;
            this.btnTachBan.Text = "Thực hiện tách";
            this.btnTachBan.UseVisualStyleBackColor = false;
            this.btnTachBan.Click += new System.EventHandler(this.btnTachBan_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(319, 26);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(18, 19);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "*";
            // 
            // frmTachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 558);
            this.Controls.Add(this.btnTachBan);
            this.Controls.Add(this.btnChuyenPhai);
            this.Controls.Add(this.btnChuyenTrai);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTachBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTachBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstvBanDuocTach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstvBanTach;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cboChonBanTach;
        private System.Windows.Forms.Label lblBanCanTach;
        private System.Windows.Forms.Button btnChuyenTrai;
        private System.Windows.Forms.Button btnChuyenPhai;
        private System.Windows.Forms.Button btnTachBan;
        private System.Windows.Forms.Label lblThongBao;
    }
}