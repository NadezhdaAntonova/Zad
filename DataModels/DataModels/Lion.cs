using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataModels
{
    public class Lion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public Guid Breed { get; set; }
        public string BreedName { get; set; }
    }
}
