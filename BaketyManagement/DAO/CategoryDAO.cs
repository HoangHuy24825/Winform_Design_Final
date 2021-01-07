using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instant;

        public static CategoryDAO Instant { get { if (instant == null) instant = new CategoryDAO(); return instant; } private set => instant = value; }
        private CategoryDAO() { }
        public DataTable LoadCategory()
        {
            String query = "EXEC STP_LoadCategory";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public Boolean AddCategory(String nameCategory)
        {
            String query = "INSERT INTO Category VALUES ( @nameCategory , 0 )";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] {nameCategory })>0;
        }
        public Boolean DeleteCategory(Int32 idCategory)
        {
            String query = "UPDATE Category SET isDeleted = 1 WHERE idCategory = @idCategory ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCategory }) > 0;
        }
        public Boolean EditCategory(String nameCategory,Int32 idCategory)
        {
            String query = "UPDATE Category SET nameCategory = @nameCategory WHERE idCategory = @idCategory ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {nameCategory, idCategory }) > 0;
        }
        public DataTable SearchCategory(String keyWord)
        {
            String query = "EXEC STP_SearchCategoryByNameCategory @keyWord ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { keyWord });
        }
        public List<Category> GetFullListCategory()
        {
            String query = "SELECT * FROM Category WHERE isDeleted=0";
            List<Category> listCategory = new List<Category>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                Category category = new Category(row);
                listCategory.Add(category);
            }
            return listCategory;
        }
        public Int32 CheckExistsCategory(String idCategory)
        {
            String query = "EXEC STP_CheckExistsCategory @ID";
            return Int32.Parse(DataProvider.Instance.ExecuteQuery(query, new object[] { idCategory }).Rows[0]["amount"].ToString());
        }
        public Category GetCateById(Int32 id)
        {
            String query = "SELECT * FROM Category WHERE idCategory = @ID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow row in data.Rows)
            {
                Category cate = new Category(row);
                return cate;
            }
            return null;
        }
    }
}
