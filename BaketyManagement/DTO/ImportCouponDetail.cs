using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DTO
{
    public class ImportCouponDetail
    {
        Int32 idCouponDetail;
        Int32 idCoupon;
        Int32 idCake;
        Int32 amountCake;
        Single priceImport;

        public ImportCouponDetail() { }
        public ImportCouponDetail(DataRow row) 
        {
            this.idCouponDetail =Int32.Parse(row["idCouponDetail"].ToString());
            this.idCoupon = Int32.Parse(row["idCoupon"].ToString());
            this.idCake = Int32.Parse(row["idCake"].ToString());
            this.amountCake = Int32.Parse(row["amountCake"].ToString());
            this.priceImport = Single.Parse(row["priceImport"].ToString());

        }
        public int IdCouponDetail { get => idCouponDetail; set => idCouponDetail = value; }
        public int IdCoupon { get => idCoupon; set => idCoupon = value; }
        public int IdCake { get => idCake; set => idCake = value; }
        public int AmountCake { get => amountCake; set => amountCake = value; }
        public float PriceImport { get => priceImport; set => priceImport = value; }
    }
}
