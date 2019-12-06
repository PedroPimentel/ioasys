using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Repositories.Enterprise
{
    public interface IEnterpriseRepository
    {
        Models.Entities.Enterprise GetByTypeAndName(int enterprise_types, string name);
        Models.Entities.Enterprise GetById(int enterpriseId);
        IEnumerable<Models.Entities.Enterprise> GetAll();
        IEnumerable<Models.Entities.Enterprise> GetByType(int type);
    }
}
