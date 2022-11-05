using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //Generic Repository Design Pattern
    //class:referans tip,
    //IEntity:IEntity olabilir veya IEntity implement eden bir nesne olabilir. 
    //new():Newlenebilir olmalı yani soyut nesne (interface vs.) olamaz.
    public interface IEntityRepository<T> where T : class, IEntity, new()//Generic Constraint =>Generic Kısıtlama
    {
        //Filtreleme amacı ile Expression kullanıyoruz.)
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter); //Expression sayesinde verileri filtreleyebiliyoruz.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
