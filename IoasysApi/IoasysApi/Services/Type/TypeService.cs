using IoasysApi.Repositories.Type;
using IoasysApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Services.Type
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository _typeRepository;

        public TypeService(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public List<TypeViewModel> GetAll()
        {
            var types = _typeRepository.GetAll();
            var typesViewModel = new List<TypeViewModel>();

            foreach (var type in types)
            {
                typesViewModel.Add(new TypeViewModel()
                {
                    name = type.name,
                    typeId = type.typeId
                });
            }

            return typesViewModel;
        }
    }
}
