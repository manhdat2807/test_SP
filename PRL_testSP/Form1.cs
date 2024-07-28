using BUStestSP;
using DALtestSP.DAL_dat;

namespace PRL_testSP
{
    public partial class Form1 : Form
    {
        SPservice spservice = new SPservice();
        private string idwhenclick;
        List<Sanpham> lisp = new List<Sanpham>();
        public Form1()
        {

            InitializeComponent();
            setingcb();
            lisp = spservice.GetSanphams().Where(x => x.Trangthai == true).ToList();
            loadSP();
        }
        public void loadSP()
        {

            dtg_sp.ColumnCount = 5;
            dtg_sp.Columns[0].Name = "Mã sản phẩm";
            dtg_sp.Columns[1].Name = "Tên sản phẩm ";
            dtg_sp.Columns[2].Name = "Số lượng ";
            dtg_sp.Columns[3].Name = "Giá";
            dtg_sp.Columns[4].Name = "Trạng thái";
            dtg_sp.Rows.Clear();
            foreach (var sp in spservice.GetSanphams())
            {
                dtg_sp.Rows.Add(sp.Masp, sp.Tensp, sp.Slton, sp.Gia, sp.Trangthai == true ? "Đang bán" : "Hết hàng");
            }
        }

        private void dtg_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= spservice.GetSanphams().Count())
            {
                return;
            }
            idwhenclick = dtg_sp.Rows[rowindex].Cells[0].Value.ToString();
            filldata();
        }
        public void filldata()
        {
            var data = spservice.GetSanphams().First(x => x.Masp == idwhenclick);
            txt_masp.Text = data.Masp;
            txt_tensp.Text = data.Tensp;
            txt_sl.Text = data.Slton.ToString();
            txt_gia.Text = data.Gia.ToString();
            if (data.Trangthai == true)
            {
                rbtn_DB.Checked = true;
            }
            else
            {
                rbtn_hethang.Checked = true;
            }
        }

        private void btn_addsp_Click(object sender, EventArgs e)
        {
            Sanpham sp = new Sanpham();
            sp.Masp = txt_masp.Text;
            sp.Tensp = txt_tensp.Text;
            sp.Slton = int.Parse(txt_sl.Text);
            sp.Gia = float.Parse(txt_gia.Text);
            if (rbtn_DB.Checked == true)
            {
                sp.Trangthai = true;
            }
            else { sp.Trangthai = false; }

            MessageBox.Show(spservice.addsp(sp));
            loadSP();
        }

        private void btn_updatesp_Click(object sender, EventArgs e)
        {
            var sp = spservice.GetSanphams().Where(x => x.Masp == idwhenclick).FirstOrDefault();
            sp.Masp = txt_masp.Text;
            sp.Tensp = txt_tensp.Text;
            sp.Slton = int.Parse(txt_sl.Text);
            sp.Gia = float.Parse(txt_gia.Text);
            if (rbtn_DB.Checked == true)
            {
                sp.Trangthai = true;
            }
            else
            {
                sp.Trangthai = false;
            }

            MessageBox.Show(spservice.updatesp(sp));
            loadSP();
        }
        private void setingcb()
        {
            cb_trangthai.SelectedIndex = 0;
            cb_trangthai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cb_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_trangthai.SelectedIndex == 0)
            {
                lisp = spservice.GetSanphams().Where(x => x.Trangthai == true).ToList();
            }
            else if (cb_trangthai.SelectedIndex == 1)
            {
                lisp = spservice.GetSanphams().Where(x => x.Trangthai == false).ToList();
            }
            else
            {
                lisp = spservice.GetSanphams();
            }
        }

        private void btn_ctsp_Click(object sender, EventArgs e)
        {
            CTSP ct = new CTSP();
            ct.Show();
        }
    }
}
