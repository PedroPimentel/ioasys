using IoasysApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoasysApi.Models.Entities;

namespace IoasysApi.Repositories.Enterprise
{
    public class EnterpriseRepository : IEnterpriseRepository
    {
        private readonly ApiDbContext _context;

        public EnterpriseRepository(ApiDbContext context)
        {
            _context = context;
        }

        public Models.Entities.Enterprise GetByTypeAndName(int enterprise_types, string name)
        {
            return _context.TbEnterprise.FirstOrDefault(e => e.type == enterprise_types && e.name == name);
        }

        public Models.Entities.Enterprise GetById(int enterpriseId)
        {
            return _context.TbEnterprise.FirstOrDefault(e => e.enterpriseId == enterpriseId);
        }

        public IEnumerable<Models.Entities.Enterprise> GetAll()
        {
            return _context.TbEnterprise;
        }

        public IEnumerable<Models.Entities.Enterprise> GetByType(int type)
        {
            return _context.TbEnterprise.Where(e => e.type == type);
        }
    }
}
