using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class CakeDAO
    {
        private CakeDAO() { }
        private static CakeDAO instance;
        public static CakeDAO Instance
        {
            get
            {
                if (CakeDAO.instance == null)
                {
                    instance = new CakeDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetFullCakeDetail()
        {
            String query = "EXEC STP_GetFullListCakeDetail";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetFullListCake()
        {
            String query = "EXEC GetListCakeForSelect";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetFullCakeWithCategory()//for Admin Tab Cake
        {
            String query = "EXEC STP_GetFullCakeWithCategory";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchCakeByCakeNameWithCategory(String cakeName)//for Admin Tab Cake
        {
            String query = "EXEC STP_SearchCakeByCakeNameWithCategory @cakeName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { cakeName });
        }
        public DataTable SearchCakePresentByName(String cakeName)//for Admin Tab Import Coupon
        {
            String query = "EXEC STP_SearchPresentCakeByName @cakeName ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { cakeName });
        }
        public DataTable SearchCakePresentBySupplier (String supplierName)//for Admin Tab Import Coupon
        {
            String query = "EXEC STP_SearchPresentCakeBySupplier @supplierName ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { supplierName });
        }
        public DataTable SearchCakeByCategoryNameWithCategory(String categoryName)//for Admin Tab Cake
        {
            String query = "EXEC STP_SearchCakeByCategoryNameWithCategory @cakeName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { categoryName });
        }
        public DataTable SearchCakeByCakeName(String cakeName)
        {
            String query = "EXEC STP_SearchCakeByCakeName @cakeName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { cakeName });
        }
        public DataTable SearchCakeByCategoryName(String categoryName)
        {
            String query = "EXEC STP_SearchCakeByCategoryName @cakeName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { categoryName });
        }
        public Int32 GetRemainingAmountByIdCake(Int32 idCake)
        {
            String query = "SELECT remainingAmount FROM Cake WHERE idCake = @idCake";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, new object[] { idCake }));
        }
        public Boolean DeleteCake(Int32 idCake)
        {
            String query = "EXEC STP_DeleteCake @idCake";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCake }) > 0;
        }

        public Boolean EditCake(String nameCake,float price,String size,Int32 idCategory,Int32 idCake)

        {
            String query = "EXEC STP_EditCake @nameCake , @price , @size , @nameCategory , @idCake ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { nameCake, price, size, idCategory, idCake }) > 0;
        }
        public Boolean AddCakeFromImportCoupon(String nameCake,Int32 exportPrice,Int32 importPrice ,Int32 amount ,DateTime expDay ,DateTime mfgDay ,String size ,String nameCategory )
        {
            String query = "EXEC STP_AddCakeFromCoupon @nameCake , @exportPrice , @importPrice , @amount , @expDay , @mfgDay , @size , @nameCategory ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { nameCake, exportPrice, importPrice, amount, expDay, mfgDay, size, nameCategory }) > 0;
        }
        public Int32 AmountRows()
        {
            String query = "SELECT COUNT(*) AS amount FROM Cake";
            return Int32.Parse(DataProvider.Instance.ExecuteQuery(query).Rows[0]["amount"].ToString());
        }
        public Int32 idCakeMax()
        {
            String query = "SELECT MAX(idCake) AS idMax FROM Cake WHERE isDeleted = 0";
            return Int32.Parse(DataProvider.Instance.ExecuteQuery(query).Rows[0]["idMax"].ToString());
        }
        public Cake GetCakeById(Int32 id)
        {
            String query = "EXEC STP_GetCakeById @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow row in data.Rows)
            {
                Cake cake = new Cake(row);
                return cake;
            }
            return null;
        }
        public DataTable GetCakePresentById(Int32 id)
        {
            String query = "EXEC STP_GetCakePresentById @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
    }
}
