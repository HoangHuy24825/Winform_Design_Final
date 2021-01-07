using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DTO
{
    public class ImportCoupon
    {
        Int32 idCoupon;
        Int32 idSupplier;
        DateTime dayImport;

        public ImportCoupon() { }
        public ImportCoupon(DataRow row) 
        {
            this.idCoupon = Int32.Parse(row["idCoupon"].ToString());
            this.idSupplier = Int32.Parse(row["idSupplier"].ToString());
            this.dayImport = Convert.ToDateTime(row["dayImport"].ToString());
        }
        public int IdCoupon { get => idCoupon; set => idCoupon = value; }
        public int IdSupplier { get => idSupplier; set => idSupplier = value; }
        public DateTime DayImport { get => dayImport; set => dayImport = value; }
    }
}
