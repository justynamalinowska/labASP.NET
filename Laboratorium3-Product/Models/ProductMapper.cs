using Data.Entities;
namespace Laboratorium3_Product.Models
{
    public class ProductMapper 
    {
        public static ProductEntity ToEntity(Product model)
        {
            return new ProductEntity()
            {
                Id = model.Id,
                ProductName = model.ProductName,
                Price = model.Price,
                DateOfProduction = model.DateOfProduction,
                Description = model.Description,
                Quality = (int)model.Quality,
                ProducentId = model.ProducentId,
                IsFavourite = model.IsFavourite
            };
        }
        public static Product FromEntity(ProductEntity model)
        {
            return new Product()
            {
                Id = model.Id,
                ProductName = model.ProductName,
                Price = model.Price,
                DateOfProduction = model.DateOfProduction,
                Description = model.Description,
                Quality = (Quality)model.Quality,
                ProducentId = (int)model.ProducentId,
                IsFavourite = model.IsFavourite
            };
        }
    }
}
