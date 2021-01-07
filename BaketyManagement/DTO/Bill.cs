using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DTO
{
    public class Bill
    {
        private Int32 id;
        private DateTime exportDate;
        private String nameStaff;
        private Single discount;
        private Single totalMoney;
        public Bill() { }
        public Bill(DataRow row)
        {
            this.id = Convert.ToInt32(row["idBill"]);
            this.exportDate = Convert.ToDateTime(row["exportDate"]);
            this.nameStaff = Convert.ToString(row["nameStaff"]);
            this.discount = Convert.ToSingle(row["discount"]);
            this.totalMoney = Convert.ToSingle(row["totalMoney"]);
        }
        public int Id { get => id; set => id = value; }
        public DateTime ExportDate { get => exportDate; set => exportDate = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public float Discount { get => discount; set => discount = value; }
        public float TotalMoney { get => totalMoney; set => totalMoney = value; }
    }
}
