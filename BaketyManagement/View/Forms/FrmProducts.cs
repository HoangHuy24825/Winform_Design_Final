using BaketyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketyManagement.View.Forms
{
    public partial class FrmProducts : Form
    {
        private Int32 row;
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadTabCake();
        }
        #region Events
        private void btnCakeDisplay_Click(object sender, EventArgs e)
        {
            LoadTabCake();
        }
        private void btnCakeDel_Click(object sender, EventArgs e)
        {
            DeleteCake();
        }
        private void dgvCake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void btnCakeEdit_Click(object sender, EventArgs e)
        {
            EditCake();
        }
        private void btnCakeSearch_Click(object sender, EventArgs e)
        {
            row = -1;
            SearchCake();
        }
        private void tlpProduct_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        #endregion
        #region Methods
        private void LoadTabCake()
        {
            dgvCake.DataSource = CakeDAO.Instance.GetFullCakeWithCategory();
            dgvCake.Columns[0].HeaderText = "Mã Bánh";
            dgvCake.Columns[1].HeaderText = "Tên Bánh";
            dgvCake.Columns[2].HeaderText = "Loại Bánh";
            dgvCake.Columns[3].HeaderText = "Giá";
            dgvCake.Columns[4].HeaderText = "Số Lượng Còn";
            dgvCake.Columns[5].HeaderText = "Kích Thước";
            dgvCake.Columns[6].HeaderText = "Hạn Dùng";


        }
        private void DeleteCake()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn loại bánh cần xóa");
                Int32 idCake = Int32.Parse(dgvCake.Rows[row].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa bánh có mã " + dgvCake.Rows[row].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (CakeDAO.Instance.DeleteCake(idCake))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadTabCake();
                    }
                    else
                        MessageBox.Show("Xóa không thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditCake()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn bánh cần xóa!");
                FrmInforTabProduct.id = Int32.Parse(dgvCake.Rows[row].Cells[0].Value.ToString());
                FrmInforTabProduct frm = new FrmInforTabProduct();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabCake();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchCake()
        {
            try
            {
                String keyWord = txtCakeSearch.Text;
                if (keyWord == "")
                    throw new Exception("Nhập từ khóa tìm kiếm");
                if (CakeDAO.Instance.SearchCakeByCakeName(keyWord).Rows.Count > 0)
                    dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCakeNameWithCategory(keyWord);
                else
                    dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryNameWithCategory(keyWord);
                if (dgvCake.Rows.Count <= 1)
                {
                    throw new Exception("Không tồn tại sản phẩm nào có tên " + keyWord + "!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
