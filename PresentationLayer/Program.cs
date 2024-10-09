using DataAccessLayer;
using DataAccessLayer.Repo;

namespace PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryRepo categoryRepo = new CategoryRepo();
            int ch, r, id;
            do
            {
                Console.WriteLine("\n\t 1. Display All \n\t 2. Add \n\t 3. Update \n\t 4. Delete \n\t 5. Exit");
                Console.Write("\n\t Enter Choice :- ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        List<Category> cates = categoryRepo.GetCategories();
                        foreach (Category c1 in cates)
                        {
                            Console.WriteLine("{0,15}{1,15}", c1.CategoryID, c1.CategoryName);
                        }
                        break;
                    case 2:
                        Category c = new Category();
                        Console.Write("\n\t Eneter Category Name :- ");
                        c.CategoryName = Console.ReadLine();
                        r = categoryRepo.InsertCategory(c);
                        if (r > 0)
                            Console.WriteLine("\n\t Date Inserted");
                        else
                            Console.WriteLine("\n\t Error... ");
                        break;
                    case 3:
                        Console.Write("\n\t Enetr Id to Update:- ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\t Enetr new Cate Name :- ");
                        string cname = Console.ReadLine();
                        r = categoryRepo.UpdateCategory(id, new Category() { CategoryID = id, CategoryName = cname });
                        if (r > 0)
                            Console.WriteLine("\n\t Date Updated");
                        else
                            Console.WriteLine("\n\t Error... ");
                        break;
                    case 4:
                        Console.Write("\n\t Enetr Id to delete:- ");
                        id = Convert.ToInt32(Console.ReadLine());
                        r = categoryRepo.DeleteCategory(id);
                        if (r > 0)
                            Console.WriteLine("\n\t Date Deleted");
                        else
                            Console.WriteLine("\n\t Error... ");
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n\t Invalid Choice ");
                        break;
                }
            } while (ch != 5);
        }
    }

    
}
