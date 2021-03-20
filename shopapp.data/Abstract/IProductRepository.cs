using System.Collections.Generic;
using shopapp.entity;
namespace shopapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        //İnterface i interfaceden türettik.Bu sayede t yerine Product geçmiş oldu.

        //Alttaki method sadece bu interfaceye özgüdür.
        List<Product> GetPopularProducts();
    }
}