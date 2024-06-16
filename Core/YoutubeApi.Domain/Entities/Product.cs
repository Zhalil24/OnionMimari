using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Commen;

namespace YoutubeApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public  string Title { get; set; }
        public  string Description { get; set; }

        public  int BrandId { get; set; }

        public  Decimal Price { get; set; }

        public  Decimal Discount { get; set; }
        public Brand Brand { get; set; }

        public ICollection<Category> Categories { get; set; }

        //public required string ImagePath { get; set; }
    }
}
