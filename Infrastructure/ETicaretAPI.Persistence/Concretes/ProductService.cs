using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new(){ Id=Guid.NewGuid(), Name="Product1",Price=100,Stock=10,CreatedDate=DateTime.Now},
            new(){ Id=Guid.NewGuid(), Name="Product2",Price=200,Stock=20,CreatedDate=DateTime.Now},
            new(){ Id=Guid.NewGuid(), Name="Product3",Price=300,Stock=30,CreatedDate=DateTime.Now},
        };
    }
}
