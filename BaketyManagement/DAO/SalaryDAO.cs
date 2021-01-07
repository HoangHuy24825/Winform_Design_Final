using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class SalaryDAO
    {
        private SalaryDAO() { }
        private static SalaryDAO instance;
        public static SalaryDAO Instance
        {
            get
            {
                if (SalaryDAO.instance == null)
                {
                    instance = new SalaryDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetListSalary(DateTime currentDate)
        {
            String query = "EXEC STP_GetListSalary @currentDate";
            return DataProvider.Instance.ExecuteQuery(query,new object[] { currentDate});
        }

        public DataTable GetListSalaryByStaffName(String nameStaff)
        {
            String query = "EXEC STP_GetListSalaryByStaffName @staffName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { nameStaff });
        }
        public DataTable GetSalaryByIdStaff(Int32 idStaff,DateTime currentDate)
        {
            String query = "EXEC STP_GetListSalaryByStaffID @idStaff , @currentDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idStaff,currentDate });
        }
        public Boolean InsertSalaryInNewMonth()
        {
            String query = "EXEC STP_InsertSalaryNewMonth";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public Boolean TimeKeeping(Single hoursOverTime, Int32 idStaff)
        {
            String query = "EXEC STP_TimeKeeping @hours , @idStaff";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoursOverTime,idStaff}) > 0;
        }
        public Boolean CancelTimeKeeping(Int32 idStaff)
        {
            String query = "EXEC STP_CancelTimeKeeping @idStaff";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {idStaff }) > 0;
        }
        public Boolean UpdateSalaryByID(Int32 idStaff,Single salaryDate,Single reward,Single salaryOverTime)
        {
            String query = " EXEC STP_UpdateSalaryByIdStaff @idStaff , @salaryDate , @reward, @salaryOverTime";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idStaff,salaryDate,reward,salaryOverTime }) > 0;
        }
        public Boolean CheckExistsSalaryByIdStaff(Int32 idStaff)
        {
            String query = " SELECT DBO.F_CheckExistsSalaryByIdStaff ( @idStaff )";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteScalar(query, new object[] { idStaff}));
        }
        public Boolean AddSalaryByIdStaff(Int32 idStaff, Single salaryDate, Single salaryOverTime)
        {
            String query = " SELECT DBO.EXEC STP_InsertNewSalaryByIdStaff @idStaff , @salaryDate , @salaryOverTime";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idStaff,salaryDate,salaryOverTime })>0;
        }
        public DataTable GetPayroll(DateTime currentDate)
        {
            String query = "EXEC STP_Payroll @currentDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { currentDate });
        }
    }
}
