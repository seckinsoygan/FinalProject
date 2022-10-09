using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryId=3 (3 farazi bir sayıdır.Aşağıdaki categoryId ne ise onu alır.)
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
