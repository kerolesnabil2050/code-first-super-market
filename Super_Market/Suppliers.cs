﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
   public class Suppliers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }
        public virtual List<Proudect> products { get; set; }
        public virtual  List<Recipt> recipts { get; set; }

    }
}
