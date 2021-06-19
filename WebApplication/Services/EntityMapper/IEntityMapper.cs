using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Services.EntityMapper
{
    interface IEntityMapper<T, V>
    {
        void Map(T entity, V viewModel);
    }
}
