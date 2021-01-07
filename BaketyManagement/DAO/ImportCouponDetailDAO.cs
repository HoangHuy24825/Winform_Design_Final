using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class ImportCouponDetailDAO
    {
        private static ImportCouponDetailDAO instant;

        public static ImportCouponDetailDAO Instant { get { if (instant == null) instant = new ImportCouponDetailDAO(); return instant; } private set => instant = value; }

        public Boolean AddCouponDetail(Int32 idCoupon, Int32 idCake,Int32 amountCake, Single priceImprot)
        {
            String query = "EXEC AddCouponDetail  @idCoupon ,  @idCake , @amountCake ,  @priceImprot ";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] {idCoupon,idCake,amountCake,priceImprot })>0;
        }
        public DataTable LoadNewDetailCoupon()
        {
            String query = "EXEC STP_GetNewDetailCoupon";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public Boolean EditDetailCoupon(Int32 idCouponDetail,Int32 amountCake , Int32 amountCakeEdited , Int32 priceImport)
        {
            String query = "EXEC STP_EditDetailCoupon @idCouponDetail , @amountCake , @amountCakeEdited , @priceImport ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCouponDetail, amountCake,amountCakeEdited, priceImport }) > 0;
        }
        public Boolean DeleteDetailCoupon(Int32 idCoupon)
        {
            String query = "EXEC STP_DeleteCouponDetail @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCoupon })>0;
        }
        public DataTable SearchCouponDetailByName(String cakeName)//for Admin Tab Import Coupon
        {
            String query = "EXEC STP_SearchCouponDetailByName @cakeName ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { cakeName });
        }
        public DataTable LoadDetailCouponById(Int32 idCoupon)
        {
            String query = "EXEC STP_GetDetailCouponImport @id";
            return DataProvider.Instance.ExecuteQuery(query,new object[] { idCoupon});
        }
        public DataTable GetDetailImportById(Int32 id)
        {
            String query = "EXEC STP_GetDetailImportCouponById @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
    }
}
