using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Commen;

namespace YoutubeApi.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail()
        {
            
        }
        public Detail(string title, string description, int categoryId  )
        {
            Title = title;
            Descriptipn = description;
            CategoryId = categoryId;
            
        }
        public required string Title { get; set; }
        public required string Descriptipn { get; set; }

        public required int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
