using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
   public class Proudect
    {
        public int Id { get; set; } // id must be uique
        public string Name { get; set; }
        public double SellingPrice { get; set; }
        public double PurchasingPrice { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
        public int CategorysId { get; set; }

        public virtual Categorys category { get; set; }
        public int Suppliersid { get; set; }
        public virtual Suppliers supplier { get; set;}

        public int Sellinvoceid { get; set; }
        public virtual Sellinvoce sellinvoce { get; set; }

        public int ReciptId { get; set; }
        public virtual Recipt recipt { get; set; }

    }
}
