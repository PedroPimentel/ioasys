using IoasysApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Services.Type
{
    public interface ITypeService
    {
        List<TypeViewModel> GetAll();
    }
}
