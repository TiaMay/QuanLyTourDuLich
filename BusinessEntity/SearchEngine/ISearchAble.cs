using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public interface ISearchAble<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Search(string keyword);

    }
}
