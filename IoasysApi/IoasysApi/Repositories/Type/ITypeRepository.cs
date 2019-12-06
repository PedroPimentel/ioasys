using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Repositories.Type
{
    public interface ITypeRepository
    {
        Models.Entities.Type GetById(int typeId);
        IEnumerable<Models.Entities.Type> GetAll();
    }
}
