using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Abstract
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Add(T model);
        void Update(T model);
        void Delete(Guid id);
    }
}
