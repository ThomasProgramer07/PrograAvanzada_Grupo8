using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.Data
{
    public interface IEntityBase
    {
        [NotMapped]
        int UniqueIdentifier { get; set; }
    }


    public class EntityBase : IEntityBase
    {
        [NotMapped]
        public int UniqueIdentifier { get; set; }
    }
}
