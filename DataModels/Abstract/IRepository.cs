using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Abstract
{
    public interface IRepository<T> where T: class
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
       
        IEnumerable<T> GetAll();    
        T GetById(dynamic id);
    }
}
