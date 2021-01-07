using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DTO
{
    public class Staff
    {
        Int32 idStaff;
        String nameStaff;
        String gender;
        String phoneStaff;
        String addressStaff;
        public Staff() { }
        public Staff(DataRow row)
        {
            this.idStaff = int.Parse(row["idStaff"].ToString());
            this.nameStaff = row["nameStaff"].ToString();
            Boolean sex = Convert.ToBoolean(row["gender"]);
            if (sex)
                this.gender = "Nữ";
            else 
                this.gender = "Nam";
            this.phoneStaff = row["phoneStaff"].ToString();
            this.addressStaff = row["addressStaff"].ToString(); 
        }

        public int IdStaff { get => idStaff; set => idStaff = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneStaff { get => phoneStaff; set => phoneStaff = value; }
        public string AddressStaff { get => addressStaff; set => addressStaff = value; }
    }
}
