using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DTO
{
    public class Category
    {
        Int32 idCategory;
        String nameCategory;

        public Category() { }
        public Category(DataRow row)
        {
            this.IdCategory = Int32.Parse(row["idCategory"].ToString());
            this.NameCategory = row["nameCategory"].ToString();
        }

        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string NameCategory { get => nameCategory; set => nameCategory = value; }
    }
}
