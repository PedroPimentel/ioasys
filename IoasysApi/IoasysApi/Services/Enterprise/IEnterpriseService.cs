using IoasysApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Services.Enterprise
{
    public interface IEnterpriseService
    {
        EnterpriseViewModel GetByTypeAndName(int enterprise_types, string name);
        EnterpriseViewModel GetById(int enterpriseId);
        List<EnterpriseViewModel> GetAll();

        List<EnterpriseViewModel> GetByTypeId(int type);
    }
}
