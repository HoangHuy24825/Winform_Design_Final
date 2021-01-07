using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class StaffDAO
    {
        private StaffDAO() { }
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get
            {
                if (StaffDAO.instance == null)
                {
                    instance = new StaffDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public Int32 GetIDStaffByUserName(String userName)
        {
            String query = "SELECT dbo.F_GetIDStaffByUserName ( @userName )";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, new object[] { userName }));
        }
        public List<Staff> GetFullStaff()
        {
            string query = "EXEC GetFullStaff";
            List<Staff> staffs = new List<Staff>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Staff staff = new Staff(row);
                staffs.Add(staff);
            }
            return staffs;
        }
        public Boolean DeleteStaff(Int32 idStaff)
        {
            string query = "UPDATE Staff SET isDeleted = 1 WHERE idStaff = @idStaff";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idStaff }) > 0;
        }
        public Boolean AddStaff(string nameStaff, Boolean gender, string phoneStaff, string addressStaff)
        {
            string query = "EXEC AddStaff @nameStaff , @gender , @phoneStaff , @addressStaff";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { nameStaff, gender, phoneStaff, addressStaff }) > 0;
        }
        public List<Staff> SearchStaff(string nameStaff)
        {
            string query = "EXEC SearchStaff @nameStaff";
            List<Staff> staffs = new List<Staff>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { nameStaff });
            foreach (DataRow row in data.Rows)
            {
                Staff staff = new Staff(row);
                staffs.Add(staff);
            }
            return staffs;
        }
        public Boolean EditStaff(String name,Boolean gender,String phoneStaff,String addressStaff,Int32 idStaff)
        {
            string query = "EXEC STP_EditStaff @name , @gender , @phone , @address , @idStaff";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {name,gender,phoneStaff,addressStaff,idStaff })>0;
        }
        public Staff GetStaffById(Int32 id)
        {
            String query = "SELECT * FROM Staff WHERE idStaff = @ID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            
            foreach (DataRow row in data.Rows)
            {
                Staff staff = new Staff(row);
                return staff;
            }
            return null;
        }
    }
}
