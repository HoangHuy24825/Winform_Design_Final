using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DTO
{
    public class Supplier
    {
        private Int32 id;
        private String name;
        private String phone;
        private String address;
        public Supplier() { }
        public Supplier(DataRow row)
        {
            this.id = Convert.ToInt32(row["idSupplier"]);
            this.name = row["nameSupplier"].ToString();
            this.phone = row["phoneSupplier"].ToString();
            this.address = row["addressSupplier"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
