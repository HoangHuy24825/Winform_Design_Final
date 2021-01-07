using BaketyManagement.DAO;
using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketyManagement.View
{
    public partial class FrmInforTabCategory : Form
    {
        public static Int32 id;
        public static Boolean isAdd;
        public FrmInforTabCategory()
        {
            InitializeComponent();
            if (isAdd)
                btnEditCategory.Visible = false;
            else
            {
                btnAddCategory.Visible = false;
                LoadTextBox();
            }
        }
        #region Events
        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            AddCategory();
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            EditCategory();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods

        private void AddCategory()
        {
            try
            {
                String nameCategory = txtNameCategory.Text;
                if (nameCategory == "")
                    throw new Exception("Nhập tên Loại bánh cần thêm");
                if (CategoryDAO.Instant.AddCategory(nameCategory))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
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
                String nameCategory = txtNameCategory.Text;
                Int32 idCategory = id;
                if (nameCategory == "")
                    throw new Exception("Nhập tên Loại bánh cần sửa");
                if (idCategory < 0)
                    throw new Exception("Chọn loại bánh cần sửa");
                if (CategoryDAO.Instant.EditCategory(nameCategory, idCategory))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTextBox()
        {
            Category cate = CategoryDAO.Instant.GetCateById(id);
            txtNameCategory.Text = cate.NameCategory;
            txtIdCategory.Text = cate.IdCategory.ToString();
        }
        #endregion

       
    }
}
