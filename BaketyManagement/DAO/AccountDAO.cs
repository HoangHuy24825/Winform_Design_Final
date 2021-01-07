using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class AccountDAO
    {
        private AccountDAO() { }
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set => instance = value;
        }

        public List<Account> FullListAccount()
        {
            string query = "EXEC GetFullAccount";
            List<Account> accounts = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);
                accounts.Add(acc);
            }
            return accounts;
        }

        public Boolean CompareAccount(String userName, String pass)
        {
            String query = "SELECT dbo.F_CompareAccount( @userName , @pass )";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteScalar(query, new object[] { userName, pass }));
        }
        public List<Account> SearchAccount(string nameStaff)
        {
            string query = "EXEC SearchAccount @nameStaff";
            List<Account> accounts = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { nameStaff});
            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);
                accounts.Add(acc);
            }
            return accounts;
        }
        public Boolean ResetPassword(string userName)
        {
            string query = "UPDATE Account SET pass = 1 where userName = @userName";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName }) > 0;
        }
        public Boolean DeleteAnAccount(string userName)
        {
            string query = "UPDATE Account SET isDeleted = 1 WHERE userName = @userName AND typeAccount = 1";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName }) > 0;
        }

        public Boolean GetTypeOfAccount(String userName)
        {
            String query = "SELECT TypeAccount FROM ACCOUNT WHERE userName = @userName AND isDeleted=0";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteScalar(query, new object[] { userName }));
        }
        public Boolean AddAnAccount(string userName, Boolean typeAccount,int idStaff)
        {
            string query ="EXEC STP_AddAnAccount @userName , @type , @idStaff ";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query, new object[] {userName ,typeAccount,idStaff}).Rows[0]["result"]);
        }
        public Account GetAccountByUserName(String userName)
        {
            string query = "EXEC STP_GetAccountByUserName @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { userName});
            Account account = new Account(data.Rows[0]);
            return account;
        }
        public Boolean ChangePassword(string userName,String password)
        {
            string query = "UPDATE Account SET pass = @password where userName = @userName";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { password,userName }) > 0;
        }
    }
}
