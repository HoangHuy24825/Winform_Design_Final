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
    public partial class FrmStaff : Form
    {
        private Int32 row;
        public FrmStaff()
        {
            InitializeComponent();
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            LoadTabStaff();
        }
        #region Event
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void btnDisplayStaff_Click(object sender, EventArgs e)
        {
            LoadTabStaff();
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DeletedStaff();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff();
        }
        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            SearchStaff();
            row = -1;
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff();
        }
        private void tlpStaff_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        #endregion
        #region Methods
        private void LoadTabStaff()
        {
            dgvStaff.DataSource = StaffDAO.Instance.GetFullStaff();
            dgvStaff.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvStaff.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvStaff.Columns[2].HeaderText = "Giới Tính";
            dgvStaff.Columns[3].HeaderText = "Số Điện Thoại";
            dgvStaff.Columns[4].HeaderText = "Địa Chỉ";
        }
        private void DeletedStaff()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn nhân viên cần xóa");
                Int32 idStaff = Int32.Parse(dgvStaff.Rows[row].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa nhân viên có mã " + dgvStaff.Rows[row].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (StaffDAO.Instance.DeleteStaff(idStaff))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTabStaff();
                    }
                    else
                        MessageBox.Show("Xóa nhân viên thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddStaff()
        {
            try
            {
                FrmInforTabStaff.isAdd = true;
                FrmInforTabStaff frm = new FrmInforTabStaff();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchStaff()
        {
            try
            {
                string nameStaff = txtStaffSearch.Text;
                if (nameStaff == "")
                    throw new Exception("Nhập tên nhân viên cần tìm");
                else
                    dgvStaff.DataSource = StaffDAO.Instance.SearchStaff(nameStaff);
                if (dgvStaff.Rows.Count <= 0)
                {
                    throw new Exception("Không tồn tại nhân viên có tên " + nameStaff + "!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditStaff()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn nhân viên cần sửa");
                FrmInforTabStaff.isAdd = false;
                FrmInforTabStaff.idStaff = Int32.Parse(dgvStaff.Rows[row].Cells[0].Value.ToString());
                FrmInforTabStaff frm = new FrmInforTabStaff();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

    }
}
