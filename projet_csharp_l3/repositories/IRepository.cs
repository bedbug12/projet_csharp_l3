using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_ecole.repository
{
    public interface IRepository <T>
    {
        List<T> findAll ();
        T findById (int id);
        void save(T entity);
        void update(T entity);
        void deleteById (int id);
    }
}
