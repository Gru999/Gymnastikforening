using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikforening {
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private List<T> _list;

        public GenericRepository() {
            _list = new List<T>();
        }
        public int Count => _list.Count;

        public List<T> List => _list;

        public void Add(T item) {
            _list.Add(item);
            Console.WriteLine($"Tilføjede: {item}\n");
        }

        public void Remove(T item) {
            ////Løsning 1
            //int index = -1;
            //foreach (var i in _list)
            //{
            //    if (i.Equals(item))
            //    {
            //        index = _list.IndexOf(i);
            //        break;
            //    }
            //}
            //if (index != -1)
            //{
            //    _list.RemoveAt(index);
            //}

            //løsning 2
            _list.Remove(item);
            Console.WriteLine($"\nFjernede: {item}");
        }

        public void Update(T oldItem, T newItem) {
            int index = _list.IndexOf(oldItem);
            if (index != -1) {
                _list[index] = newItem;
            }
            Console.WriteLine($"\nOpdateret: {oldItem}\n til: {newItem}");
        }
    }
}
