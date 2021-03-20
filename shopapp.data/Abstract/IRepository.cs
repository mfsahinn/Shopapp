using System.Collections.Generic;

namespace shopapp.data.Abstract
{
    //Base olarfak kullanılan interface

    public interface IRepository<T>
    //Bir entity e bağlık olmayan bir interface tanımlıyoruz
    //Bu sayede hangi entity i gönderirsek t yerine o parametre geçecek.
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}