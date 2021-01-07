using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DTO
{
    public class Cake
    {
        private Int32 id;
        private String name;
        private Single price;
        private Int32 amount;
        private DateTime mfg;
        private DateTime exp;
        private String size;
        private String category;
        public Cake() { }
        public Cake(DataRow row)
        {
            this.id = Convert.ToInt32(row["idCake"]);
            this.name  = row["nameCake"].ToString();
            this.price = Convert.ToSingle(row["exportPrice"]);
            this.amount = Convert.ToInt32(row["remainingAmount"]);
            this.mfg = Convert.ToDateTime(row["mfgCake"]);
            this.exp = Convert.ToDateTime(row["expCake"]);
            this.size = row["size"].ToString();
            this.Category = row["nameCategory"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public DateTime Mfg { get => mfg; set => mfg = value; }
        public DateTime Exp { get => exp; set => exp = value; }
        public string Size { get => size; set => size = value; }
        public string Category { get => category; set => category = value; }
    }
}
