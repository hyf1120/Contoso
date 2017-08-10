using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void DeleteById(int id);
        void Create(T obj);
        void Update(T obj);
    }
}
