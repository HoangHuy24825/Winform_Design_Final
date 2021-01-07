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
    public partial class FrmInforTabProvider : Form
    {
        public static Int32 id;
        public static Boolean isAdd;
        public FrmInforTabProvider()
        {
            InitializeComponent();
            if (isAdd)
                btnEditSupplier.Visible = false;
            else
            {
                btnAddSupplier.Visible = false;
                LoadTextBox();
            }
        }
        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }
        #endregion
        #region Methods
        private void UpdateSupplier()
        {
            try
            {
                if (txtIdSupplier.Text == "")
                {
                    throw new Exception("Vui lòng chọn nhà cung cấp cần cập nhật!");
                }
                Int32 idSupplier = Convert.ToInt32(txtIdSupplier.Text);
                String nameSupplier = txtNameSupplier.Text;
                String phoneSupplier = txtPhoneSupplier.Text;
                String addressSupplier = txtAddressSupplier.Text;
                if (nameSupplier == "" || phoneSupplier == "" || addressSupplier == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhà cung cấp!");
                }
                if (SupplierDAO.Instance.UpdateSupplier(idSupplier, nameSupplier, phoneSupplier, addressSupplier))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddSupplier()
        {
            try
            {
                String nameSupplier = txtNameSupplier.Text;
                String phoneSupplier = txtPhoneSupplier.Text;
                String addressSupplier = txtAddressSupplier.Text;
                if (nameSupplier == "" || phoneSupplier == "" || addressSupplier == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhà cung cấp!");
                }
                if (SupplierDAO.Instance.InsertSupplier(nameSupplier, phoneSupplier, addressSupplier))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTextBox()
        {
            Supplier sup = SupplierDAO.Instance.GetSupplierById(id);
            txtIdSupplier.Text = id.ToString();
            txtNameSupplier.Text = sup.Name;
            txtPhoneSupplier.Text = sup.Phone;
            txtAddressSupplier.Text = sup.Address;

        }
        #endregion


    }
}
