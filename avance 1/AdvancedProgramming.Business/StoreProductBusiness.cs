using AdvancedProgramming.Data;
using AdvancedProgramming.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Architecture.Extensions;

namespace AdvancedProgramming.Business
{
    public class StoreProductBusiness
    {
        private readonly RepositoryProduct repositoryProduct;

        public StoreProductBusiness ()
        {
            repositoryProduct = new RepositoryProduct();
        }
        public IEnumerable<Products> Get(int? id)
        {
            var prods = new List<Products>();
            if (id != null)
                prods.Add(repositoryProduct.GetById((int)id));
            else
                prods.AddRange(repositoryProduct.GetAll());

            return prods;
        }
        
        public void Save(int id,Products entity)
        {
            // O
            var test = entity.GetCrazyProduct();
            
            if (id <= 0)
                repositoryProduct.Add(entity);
            else
                repositoryProduct.Update(entity);
        }

        public void Delete(int id)
        {
            repositoryProduct.Delete(id);
        }
   
        public Products CreateTempOpbject()
        {
            return new EntityBase() as Products;
            //return (new BusinessManager<Products>()).GetEntityBaseObject();
        }
    }
}
