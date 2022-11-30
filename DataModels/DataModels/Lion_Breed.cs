using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataModels
{
    public class Lion_Breed
    {
        public Guid Id { get; set; }
        public string BreedName { get; set; }
        public ICollection<Lion> Lions { get; set; }
    }
}
