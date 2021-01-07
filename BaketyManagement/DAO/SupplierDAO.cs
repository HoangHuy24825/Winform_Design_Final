using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class SupplierDAO
    {
        private SupplierDAO() { }
        private static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get
            {
                if (SupplierDAO.instance == null)
                {
                    instance = new SupplierDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<Supplier> GetFullListSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            String query = "SELECT * FROM Supplier WHERE isDeleted=0";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                Supplier supplier = new Supplier(row);
                suppliers.Add(supplier);
            }
            return suppliers;
        }
        public List<Supplier> GetListSupplierByName(String nameSupplier)
        {
            List<Supplier> suppliers = new List<Supplier>();
            String query = "EXEC STP_SearchSupplierBySupplierName @nameSupplier";
            DataTable table = DataProvider.Instance.ExecuteQuery(query,new object[] { nameSupplier});
            foreach (DataRow row in table.Rows)
            {
                Supplier supplier = new Supplier(row);
                suppliers.Add(supplier);
            }
            return suppliers;
        }
        public Boolean DeleteSupplier(Int32 idSupplier)
        {
            String query = "UPDATE Supplier SET isDeleted = 1 WHERE idSupplier = @idSupplier";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idSupplier }) > 0;
        }
        public Boolean UpdateSupplier(Int32 idSupplier,String name,String phone,String address)
        {
            String query = "UPDATE Supplier SET nameSupplier = @name , phoneSupplier = @phone ," +
                "addressSupplier = @address WHERE idSupplier = @idSupplier";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { name,phone,address,idSupplier }) > 0;
        }
        public Boolean InsertSupplier(String name, String phone, String address)
        {
            String query = "INSERT INTO Supplier (nameSupplier,phoneSupplier,addressSupplier,isDeleted) VALUES" +
                "( @name , @phone , @address , 0)";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, phone, address}) > 0;
        }
        public Int32 CheckExistsSupplier(String idSupplier)
        {
            String query = "EXEC STP_CheckExistsSupplier @ID";
            return Int32.Parse(DataProvider.Instance.ExecuteQuery(query, new object[] { idSupplier }).Rows[0]["amount"].ToString());
        }
        public Supplier GetSupplierById(Int32 id)
        {
            String query = "SELECT * FROM Supplier WHERE idSupplier = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow row in data.Rows)
            {
                Supplier sup = new Supplier(row);
                return sup;
            }
            return null;
        }
        public List<Supplier> SearchSupplier(String keyWord)
        {
            List<Supplier> suppliers = new List<Supplier>();
            String query = "EXEC STP_SearchSupplierBySupplierName @key";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { keyWord });
            foreach (DataRow row in table.Rows)
            {
                Supplier supplier = new Supplier(row);
                suppliers.Add(supplier);
            }
            return suppliers;
        }
    }
}
