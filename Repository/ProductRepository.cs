using ProductProject.Data; 
using ProductProject.Models;

namespace ProductProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly BancoContext _bancoContext;
        public ProductRepository(BancoContext bancoContext)
        {
        _bancoContext=bancoContext;
        }
        public Product Create(Product product)
        {
          _bancoContext.Produtos.Add(product);
            _bancoContext.SaveChanges();    
            return product;
        }

        public bool Delete(int id)
        {
            Product productDb = GetById(id);
            if (productDb == null) throw new System.Exception("Houve um erro na deleção do Produto");
            _bancoContext.Produtos.Remove(productDb);
            _bancoContext.SaveChanges();
            return true;
        }

        public Product Edit(Product product)
        {
          Product productDb = GetById(product.Id);
            if (productDb == null) throw new System.Exception("Houve um erro na atualização do Produto");
            productDb.Nome=product.Nome;
            _bancoContext.Produtos.Update(productDb);
            _bancoContext.SaveChanges();
            return productDb;
        }

        public List<Product> GetAll()
        {
            return _bancoContext.Produtos.ToList();
        }

        public Product GetById(int id)
        {
          return _bancoContext.Produtos.FirstOrDefault(p => p.Id == id);
        }
    }
}
