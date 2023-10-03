using ProductProject.Models;

namespace ProductProject.Repository
{
    public interface IProductRepository
    {
        Product Edit(Product product);
        Product GetById(int id);
        List<Product> GetAll();
        Product Create(Product product);
        bool Delete(int id);
    }
}
