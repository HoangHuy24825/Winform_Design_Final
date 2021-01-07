using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class BillDAO
    {
        private BillDAO() { }
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (BillDAO.instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public Int32 GetMaxIDBill()
        {
            String query = "SELECT MAX(idBill) FROM Bill";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }
        public Boolean InsertBill(Int32 idStaff)
        {
            String query = "INSERT INTO Bill (exportDate,discount,idStaff) VALUES ( @exportDate , 0 , @idStaff )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { DateTime.Now, idStaff }) > 0;
        }
        public DataTable GetBillByID(Int32 idBill)
        {
            String query = "EXEC STP_GetBillByIdBill @idBill";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
        }
        public Boolean UpdateDisCountBillByID(Single discount,Int32 idBill)
        {
            String query = "UPDATE Bill SET discount = @discount WHERE idBill = @idBill";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {discount,idBill }) > 0;
        }
        public DataTable GetFullListBill()
        {
            String query = "EXEC STP_GetFullListBill";
            return DataProvider.Instance.ExecuteQuery(query);     
        }
        public DataTable SearchBillByNameStaff(String nameStaff)
        {
            String query = "EXEC STP_SearchBillByNameStaff @nameStaff";
            return DataProvider.Instance.ExecuteQuery(query,new object[] { nameStaff});
        }
        public DataTable FilterBillByDate(DateTime startDate,DateTime endDate)
        {
            String query = "EXEC STP_FilterBillByDate  @start , @end ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { startDate,endDate });
        }
        public Boolean DeleteBillByIdBill(Int32 idBill)
        {
            String query = "DELETE Bill WHERE idBill = @idBill";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill }) > 0;
        }
        public Boolean InsertPayBill(Int32 idBill,Single totalMoney,Single totalAfterDiscount,Single customerPay, Single returnMoney)
        {
            String query = "INSERT INTO ##PayBill VALUES ( @idBill , @totalMoeny , @totalAfterDiscount , @customerPay , @returnMoney )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill, totalMoney, totalAfterDiscount, customerPay, returnMoney }) > 0;
        }
        public DataTable PrintBill(Int32 idBill)
        {
            String query = "EXEC STP_PrintBill @idBill";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
        }
    }
}
