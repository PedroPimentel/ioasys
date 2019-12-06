using IoasysApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Repositories.Type
{
    public class TypeRepository : ITypeRepository
    {
        private readonly ApiDbContext _context;

        public TypeRepository(ApiDbContext context)
        {
            _context = context;
        }

        public Models.Entities.Type GetById(int typeId)
        {
            return _context.TbType.FirstOrDefault(t => t.typeId == typeId);
        }

        public IEnumerable<Models.Entities.Type> GetAll()
        {
            return _context.TbType;
        }
    }
}
