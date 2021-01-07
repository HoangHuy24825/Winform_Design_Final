using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class BillDetailDAO
    {
        private BillDetailDAO() { }
        private static BillDetailDAO instance;
        public static BillDetailDAO Instance
        {
            get
            {
                if (BillDetailDAO.instance == null)
                {
                    instance = new BillDetailDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public Boolean InsertBillDetail(Int32 idCake, Int32 idBill, Int32 amountOrder)
        {
            String query = "EXEC STP_AddCakeToBill  @idCake , @idBill , @amountOrder";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCake, idBill, amountOrder }) > 0;
        }
        public Int32 GetOldOrder(Int32 idCake,Int32 idBill)
        {
            String query = "SELECT dbo.F_GetOldAmountOrder ( @idCake , @idBill )";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query,new object[] { idCake,idBill}));
        }
        public Single GetTotalMoneyByIDBill(Int32 idBill)
        {
            String query = "SELECT dbo.F_TotalMoney ( @idBill )";
            return Convert.ToSingle(DataProvider.Instance.ExecuteScalar(query,new object[] { idBill}));
        }
        public Int32 GetRowCountByIDBill(Int32 idBill)
        {
            String query = "SELECT COUNT(*) FROM BillDetail WHERE idBill = @idBill";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, new object[] { idBill }));
        }
        public Boolean DeleteRecordByIdBill(Int32 idBill)
        {
            String query = "DELETE BillDetail WHERE idBill = @idBill";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill }) > 0;
        }
        public DataTable GetBillDetailByIdBill(Int32 idBill)
        {
            String query = "EXEC STP_GetBillDetailByIDBill @idBill";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
        }
        public Boolean DeleteAllRecordByIdBill(Int32 idBill)
        {
            String query = "DELETE BillDetail WHERE idBill = @idBill";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill }) > 0;
        }
    }
}
