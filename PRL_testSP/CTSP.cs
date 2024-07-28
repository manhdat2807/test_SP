using BUStestSP;
using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL_testSP
{

    public partial class CTSP : Form
    {
        MSservice mSservice = new MSservice();
        Kichcoserivice kcservice = new Kichcoserivice();
        THservice thservice = new THservice();
        XXservice XXservice = new XXservice();
        private string idwhenclick;
        public CTSP()
        {
            InitializeComponent();
            loadms();
            loadkc();
            loadth();
            loadxx();
        }
        public void loadms()
        {
            dtg_ms.ColumnCount = 2;
            dtg_ms.Columns[0].Name = "Mã màu";
            dtg_ms.Columns[1].Name = "Màu";
            dtg_ms.Rows.Clear();
            foreach (var ms in mSservice.GetMausacs())
            {
                dtg_ms.Rows.Add(ms.MaMs, ms.TenMs);
            }

        }

        private void dtg_ms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= mSservice.GetMausacs().Count())
            {
                return;
            }
            idwhenclick = dtg_ms.Rows[rowindex].Cells[0].Value.ToString();
            filldatams();
        }
        public void filldatams()
        {
            var datams = mSservice.GetMausacs().First(x => x.MaMs == idwhenclick);
            txt_mamau.Text = datams.MaMs;
            txt_tenmau.Text = datams.TenMs;
        }
        public void filldatakc()
        {
            var datakc = kcservice.GetKichcos().First(x => x.MaSize == idwhenclick);
            txt_makc.Text = datakc.MaSize;
            txt_size.Text = datakc.Kichco1.ToString();
        }
        public void filldatath()
        {
            var datath = thservice.GetThuonghieus().First(x => x.MaTh == idwhenclick);
            txt_th.Text = datath.MaTh;
            txt_tenth.Text = datath.TenTh;
        }
        public void filldataxx()
        {
            var dataxx = XXservice.GetXuatxus().First(x => x.MaXx == idwhenclick);
            txt_maxx.Text = dataxx.MaXx;
            txt_noixx.Text = dataxx.TennoiXx;
        }
        public void loadkc()
        {
            dtg_kc.ColumnCount = 2;
            dtg_kc.Columns[0].Name = "Mã kích cỡ";
            dtg_kc.Columns[1].Name = "Kích cỡ";
            dtg_kc.Rows.Clear();
            foreach (var kc in kcservice.GetKichcos())
            {
                dtg_kc.Rows.Add(kc.MaSize, kc.Kichco1);
            }
        }
        public void loadxx()
        {
            dtg_XX.ColumnCount = 2;
            dtg_XX.Columns[0].Name = "Mã Xuất xứ";
            dtg_XX.Columns[1].Name = "Xuất xứ";
            dtg_XX.Rows.Clear();
            foreach (var xx in XXservice.GetXuatxus())
            {
                dtg_XX.Rows.Add(xx.MaXx, xx.TennoiXx);
            }

        }
        public void loadth()
        {
            dtg_th.ColumnCount = 2;
            dtg_th.Columns[0].Name = "Mã thương hiệu";
            dtg_th.Columns[1].Name = "Thương hiệu";
            dtg_ms.Rows.Clear();
            foreach (var th in thservice.GetThuonghieus())
            {
                dtg_th.Rows.Add(th.MaTh, th.TenTh);
            }

        }

        private void dtg_kc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= kcservice.GetKichcos().Count())
            {
                return;
            }
            idwhenclick = dtg_kc.Rows[rowindex].Cells[0].Value.ToString();
            filldatakc();
        }

        private void dtg_th_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= thservice.GetThuonghieus().Count())
            {
                return;
            }
            idwhenclick = dtg_th.Rows[rowindex].Cells[0].Value.ToString();
            filldatath();
        }

        private void dtg_XX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= XXservice.GetXuatxus().Count())
            {
                return;
            }
            idwhenclick = dtg_XX.Rows[rowindex].Cells[0].Value.ToString();
            filldataxx();
        }

        private void btn_themmau_Click(object sender, EventArgs e)
        {
            Mausac ms = new Mausac();
            ms.MaMs = txt_mamau.Text;
            ms.TenMs = txt_tenmau.Text;
            MessageBox.Show(mSservice.addms(ms));
            loadms();
        }

        private void btn_addkc_Click(object sender, EventArgs e)
        {
            Kichco kc = new Kichco();
            kc.MaSize = txt_makc.Text;
            kc.Kichco1 = float.Parse(txt_size.Text);
            MessageBox.Show(kcservice.addkc(kc));
            loadkc();
        }

        private void btn_addth_Click(object sender, EventArgs e)
        {
            Thuonghieu th = new Thuonghieu();
            th.MaTh = txt_th.Text;
            th.TenTh = txt_tenth.Text;
            MessageBox.Show(thservice.addth(th));
            loadth();
        }

        private void btn_themxx_Click(object sender, EventArgs e)
        {
            Xuatxu xx = new Xuatxu();
            xx.MaXx = txt_maxx.Text;
            xx.TennoiXx = txt_noixx.Text;
            MessageBox.Show(XXservice.addxx(xx));
            loadxx();
        }

        private void btn_capnhapmau_Click(object sender, EventArgs e)
        {
            var ms = mSservice.GetMausacs().Where(x => x.MaMs == idwhenclick).FirstOrDefault();
            ms.MaMs = txt_mamau.Text;
            ms.TenMs = txt_tenmau.Text;
            MessageBox.Show(mSservice.updatams(ms));
            loadms();
        }

        private void btn_upkc_Click(object sender, EventArgs e)
        {
            var kc = kcservice.GetKichcos().Where(x => x.MaSize == idwhenclick).FirstOrDefault();
            kc.MaSize = txt_makc.Text;
            kc.Kichco1 = float.Parse(txt_size.Text);
            MessageBox.Show(kcservice.updatekc(kc));
            loadkc();
        }

        private void btn_upth_Click(object sender, EventArgs e)
        {
            var th = thservice.GetThuonghieus().Where(x => x.MaTh == idwhenclick).FirstOrDefault();
            th.MaTh = txt_th.Text;
            th.TenTh = txt_tenth.Text;
            MessageBox.Show(thservice.updateth(th));
            loadth();
        }

        private void btn_suaxx_Click(object sender, EventArgs e)
        {
            var xx = XXservice.GetXuatxus().Where(x => x.MaXx == idwhenclick).FirstOrDefault();
            xx.MaXx = txt_maxx.Text;
            xx.TennoiXx = txt_noixx.Text;
            MessageBox.Show(XXservice.updatexx(xx));
            loadxx();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            form.Show();
        }
    }
}
