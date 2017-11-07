using MvcSolution.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSolution.Data
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        int AddCategory();

    }
}
