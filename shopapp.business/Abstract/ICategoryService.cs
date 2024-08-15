using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface ICategoryService: IValidator<Category>
    {
        Category GetById(int id);
        List<Category> GetAll();
        Category GetByIdWithProducts(int CategoryId);

        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void DeleteFromCategory(int productId, int categoryId);
    }
}