using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //İnterface i interfaceden türettik.Bu sayede t yerine category geçmiş oldu.
    }
}