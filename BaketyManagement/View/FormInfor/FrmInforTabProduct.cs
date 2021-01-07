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
    public partial class FrmInforTabProduct : Form
    {
        public static Int32 id;

        public FrmInforTabProduct()
        {
            InitializeComponent();
            LoadTextBox();
        }

        #region Events
        private void btnCakeEdit_Click(object sender, EventArgs e)
        {
            EditCake();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods
        private void EditCake()
        {
            try
            {
                String name = txtNameCake.Text;
                if (name == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin bánh!");
                Int32 idCategory = (cbbCategory.SelectedItem as Category).IdCategory;
                Single price = Single.Parse(txtPrice.Text);
                String size = txtSize.Text;
                if (price < 0)
                    throw new Exception("Giá bánh phải lớn hơn 0!");
                if (size == "")
                    throw new Exception("Cần ghi size bánh!");
                if (CakeDAO.Instance.EditCake(name, price, size, idCategory, id))
                {
                    MessageBox.Show("Sửa thành công!");
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
            Cake cake = CakeDAO.Instance.GetCakeById(id);
            txtNameCake.Text = cake.Name;
            cbbCategory.Text = cake.Category;
            txtPrice.Text = cake.Price.ToString();
            txtSize.Text = cake.Size;
            cbbCategory.DataSource = CategoryDAO.Instant.GetFullListCategory();
            cbbCategory.DisplayMember = "nameCategory";
            cbbCategory.Text = cake.Category;
        }
        #endregion
  
    }
}
