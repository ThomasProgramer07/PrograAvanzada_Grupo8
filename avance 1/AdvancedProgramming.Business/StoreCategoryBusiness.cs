using AdvancedProgramming.Data;
using AdvancedProgramming.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.Business
{
    public class StoreCategoryBusiness
    {
        private readonly RepositoryCategory repositoryCategory;

        public StoreCategoryBusiness()
        {
            repositoryCategory = new RepositoryCategory();
        }
        public IEnumerable<Category> Get(int? id)
        {
            var prods = new List<Category>();
            if (id != null)
                prods.Add(repositoryCategory.GetById((int)id));
            else
                prods.AddRange(repositoryCategory.GetAll());

            return prods;
        }

        public void Save(int id, Category entity)
        {
            if (id <= 0)
                repositoryCategory.Add(entity);
            else
                repositoryCategory.Update(entity);
        }

        public void Delete(int id)
        {
            repositoryCategory.Delete(id);
        }
    }
}
