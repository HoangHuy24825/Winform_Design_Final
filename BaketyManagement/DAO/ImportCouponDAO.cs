using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class ImportCouponDAO
    {
        private static ImportCouponDAO instant;

        public static ImportCouponDAO Instant { get { if (instant == null) instant = new ImportCouponDAO(); return instant; } private set => instant = value; }
        
        public Boolean AddImportCoupon(Int32 idSupplier,DateTime dayImport)
        {
            String query = "INSERT INTO ImportCoupon VALUES ( @idSupplier , @dayIport , 0)";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] {idSupplier,dayImport })>0;
        }
        public Int32 GetIdCouponPresent()
        {
            String query = "EXEC GetMaxIdCoupon";
            return Int32.Parse(DataProvider.Instance.ExecuteQuery(query).Rows[0]["idCoupon"].ToString());
        }
        public Int32 GetIdSupplierPresent()
        {
            String query = "EXEC STP_GetMaxIdSupplier";
            return Int32.Parse(DataProvider.Instance.ExecuteQuery(query).Rows[0]["idSupplier"].ToString());
        }
        public Boolean DeleteCouponPresent(Int32 idCoupon)
        {
            String query = "EXEC STP_DeleteCouponPresent @idCoupon ";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] { idCoupon})>0;
        }
        public DataTable GetListCouponImport()
        {
            String query = "STP_GetListCouponImport";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchCouponByNameSupplier(String keyWord)
        {
            String query = "EXEC STP_SearchCouponBuSupplier @nameSupplier";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { keyWord });
        }
        public DataTable FilterCouponImportByDate(DateTime startDate, DateTime endDate)
        {
            String query = "EXEC STP_FilterCouponByDate  @start , @end ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { startDate, endDate });
        }
    }
}
