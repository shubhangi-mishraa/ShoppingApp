using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repo
{
    internal interface ICategoryRepo
    {
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        int InsertCategory(Category category);
        int UpdateCategory(int id, Category category);
        int DeleteCategory(int id);
    }
}
