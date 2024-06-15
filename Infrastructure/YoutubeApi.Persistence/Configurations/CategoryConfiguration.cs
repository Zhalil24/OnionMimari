﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Elektirik",
                Priorty = 1,
                ParentId = 0,
                isDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                Priorty = 2,
                ParentId = 0,
                isDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category panret1 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priorty = 1,
                ParentId = 1,
                isDeleted = false,
                CreatedDate = DateTime.Now,
            };

            Category panret2 = new()
            {
                Id = 4,
                Name = "Kadın",
                Priorty = 1,
                ParentId = 2,
                isDeleted = false,
                CreatedDate = DateTime.Now,
            };


            builder.HasData(category1, category2, panret1, panret2);

        }
    }
}
