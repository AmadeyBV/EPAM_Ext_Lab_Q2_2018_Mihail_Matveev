using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTS
{
    public abstract class DataBaseService<T> where T : class, new()
    {
        public List<T> list = new List<T>();

        public bool Delete(int id)
        {
            if ((id < list.Count) && (id >= 0))
            {
                list.RemoveAt(id);

                return true;
            }
            else
            {
                return false;
            }
        }

        public T Get(int id)
        {
            if ((list.Count > id) && (id >= 0))
                return list[id];
            else
                return null;
        }

        public List<T> GetAll()
        {
            return list;
        }

        public bool Save(T entity)
        {
            if (entity != null)
            {
                list.Add(entity);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
