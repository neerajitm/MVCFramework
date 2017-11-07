using MvcSolution.Data;
using MvcSolution.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSolution.Data
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {

        }

        public int AddCategory()
        {
            return 2;
        }
    }
}
