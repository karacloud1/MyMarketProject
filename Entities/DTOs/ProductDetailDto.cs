using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short ProductAmount { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductPhotoPath { get; set; }
    }
}
