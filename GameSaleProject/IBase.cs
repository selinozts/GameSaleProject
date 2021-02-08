using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject
{
    interface IBase<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
