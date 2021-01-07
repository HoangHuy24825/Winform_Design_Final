using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BaketyManagement.DTO
{
    public class Account
    {
        string userName;
        string pass;
        string typeAccount;
        int idStaff;
        string nameStaff;

        public Account() { }
        public Account(DataRow row)
        {
            this.userName = row["userName"].ToString();
            this.pass = row["pass"].ToString();
            Boolean type = Convert.ToBoolean(row["typeAccount"]);
            if(type)
                this.typeAccount = "Nhân Viên";
            else
                this.typeAccount = "Admin";
            this.nameStaff = row["nameStaff"].ToString();
            this.idStaff =int.Parse(row["idStaff"].ToString());
        }

        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public string TypeAccount { get => typeAccount; set => typeAccount = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public int IdStaff { get => idStaff; set => idStaff = value; }
    }
}
