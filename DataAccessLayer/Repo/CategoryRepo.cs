using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repo
{
    public class CategoryRepo: ICategoryRepo
    {
        ShoppingContext context = new ShoppingContext();

        public List<Category> GetCategories()
        {
            //using LINQ Query 

            //var data = (from c in context.Categories
            //           select c).ToList();

            //using lambda expression
            var data = context.Categories.ToList();

            return data;
        }


        public Category GetCategoryById(int id)
        {
            /*
             * LINQ QUery
             * var category = (from c in context.Categories
                            where c.CategoryID == id
                            select c).FirstOrDefault();
            return category;
             */
            var category = context.Categories.Find(id);
            if (category == null)
                return null;

            return category;
        }

        public int DeleteCategory(int id)
        {
            Category cate = GetCategoryById(id);
            if (cate != null)
            {
                //var data = from c in context.Categories where c.CategoryID == id select c;

                context.Categories.Remove(cate);
                int i = context.SaveChanges();
                return i;
            }
            return 0;
        }
  


        public int InsertCategory(Category category)
        {
            context.Categories.Add(category);   // it add in dbset

            int i= context.SaveChanges();    // permenat save in db

            return i;
        }

        public int UpdateCategory(int id, Category newcategory)
        {
            Category cate = GetCategoryById(id);
            if(cate !=null)
            {
                cate.CategoryName = newcategory.CategoryName;
                int i = context.SaveChanges();
                return i;
            }
            return 0;
        }
    }

}
