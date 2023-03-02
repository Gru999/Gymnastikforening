using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastikforening {
    public interface IGenericRepository<T> {
        int Count { get; }
        List<T> List { get; }
        void Add(T item);
        void Remove(T item);
        void Update(T oldItem, T newItem);
    }
}
