using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmManHinhChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType) //Neu Form duoc truyen vao da duoc mo
                    return f;
            }
            return null;
        }
        private void barLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLop f = new frmLop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barKhoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKhoilop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmKhoilop f = new frmKhoilop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barHocky_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmHocKy));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHocKy f = new frmHocKy
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmHocSinh));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHocSinh f = new frmHocSinh
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barNamHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNamHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNamHoc f = new frmNamHoc
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmMonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNhapDiemChung));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhapDiemChung f = new frmNhapDiemChung
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barDiemCT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNhapDiemChiTiet));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhapDiemChiTiet f = new frmNhapDiemChiTiet
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barrpHK_Lop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmrpTongKetMon));
            if (frm != null)
                frm.Activate();
            else
            {
                frmrpTongKetMon f = new frmrpTongKetMon
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barPhanLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmPhanLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPhanLop f = new frmPhanLop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
        
        private void barQuyDinhTuoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_menuQuyDinh("QuyDinhTuoi");
        }

        private void barQuyDinhSiSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_menuQuyDinh("QuyDinhSiSo");
        }
       
        private void barQuyDinhDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_menuQuyDinh("QuyDinhDiem");
        }
        private void load_menuQuyDinh(string s)
        {
            frmQuyDinh frm = new frmQuyDinh(s);
            frm.Show();
        }
    }
}