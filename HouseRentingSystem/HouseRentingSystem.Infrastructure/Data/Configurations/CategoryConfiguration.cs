using HouseRentingSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructure.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            var categories = new List<Category>();

            var cottageCategory = new Category()
            {
                Id = 1,
                Name = "Cottage"
            };

            categories.Add(cottageCategory);

            var singleCategory = new Category()
            {
                Id = 2,
                Name = "Single-Family"
            };

            categories.Add(singleCategory);

            var duplexCategory = new Category()
            {
                Id = 3,
                Name = "Duplex"
            };

            categories.Add(duplexCategory);

            return categories;
        }

    }
}
