﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public Product()
        {

        }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public int ProductPrice { get; set; }
        public string ProductPhotoPath { get; set; }

    }
}
