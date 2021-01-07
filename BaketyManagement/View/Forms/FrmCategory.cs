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
    public partial class FrmCategory : Form
    {
        Int32 row;
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            LoadTabCategory();
        }
        #region Events
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void btnDisplayCategory_Click(object sender, EventArgs e)
        {
            LoadTabCategory();
        }
        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            AddCategory();
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            EditCategory();
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }
        private void btnCategorySearch_Click(object sender, EventArgs e)
        {
            row = -1;
            SearchCategory();
        }
        private void tlpCategory_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);

        }
        #endregion
        #region Methods

        private void LoadTabCategory()
        {
            dgvCategory.DataSource = CategoryDAO.Instant.LoadCategory();
            dgvCategory.Columns[0].HeaderText = "Mã Loại Bánh";
            dgvCategory.Columns[1].HeaderText = "Tên Loại Bánh";
        }
        private void AddCategory()
        {
            try
            {
                FrmInforTabCategory.isAdd = true;
                FrmInforTabCategory frm = new FrmInforTabCategory();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCategory()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn loại bánh cần sửa");
                FrmInforTabCategory.id = Int32.Parse(dgvCategory.Rows[row].Cells[0].Value.ToString());
                FrmInforTabCategory.isAdd = false;
                FrmInforTabCategory frm = new FrmInforTabCategory();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteCategory()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn loại bánh cần xóa");
                Int32 idCategory = Int32.Parse(dgvCategory.Rows[row].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa loại bánh có mã " + dgvCategory.Rows[row].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (CategoryDAO.Instant.DeleteCategory(idCategory))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadTabCategory();
                    }
                    else
                        MessageBox.Show("Xóa không thành công");//del
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchCategory()
        {
            try
            {
                String keyWord = txtCategorySearch.Text;
                if (keyWord == "")
                    throw new Exception("Nhập từ khóa tìm kiếm");
                else
                    dgvCategory.DataSource = CategoryDAO.Instant.SearchCategory(keyWord);
                if (dgvCategory.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tồn tại sản phẩm nào có tên " + keyWord + "!", "Thông báo");
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
