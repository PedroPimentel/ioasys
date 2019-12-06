using IoasysApi.Repositories.Enterprise;
using IoasysApi.Repositories.Type;
using IoasysApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Services.Enterprise
{
    public class EnterpriseService : IEnterpriseService
    {
        private readonly IEnterpriseRepository _enterpriseRepository;
        private readonly ITypeRepository _typeRepository;

        public EnterpriseService(IEnterpriseRepository enterpriseRepository, ITypeRepository typeRepository)
        {
            _enterpriseRepository = enterpriseRepository;
            _typeRepository = typeRepository;
        }
        public EnterpriseViewModel GetByTypeAndName(int enterprise_types, string name)
        {
            var enterprise = _enterpriseRepository.GetByTypeAndName(enterprise_types, name);

            if (enterprise != null)
            {
                return new EnterpriseViewModel()
                {
                    enterpriseId = enterprise.enterpriseId,
                    name = enterprise.name,
                    type = enterprise.type,
                    typeName = _typeRepository.GetById(enterprise.type).name
                };
            }
            else
                return null;
        }

        public EnterpriseViewModel GetById(int enterpriseId)
        {
            var enterprise = _enterpriseRepository.GetById(enterpriseId);

            if (enterprise != null)
            {
                return new EnterpriseViewModel()
                {
                    enterpriseId = enterprise.enterpriseId,
                    name = enterprise.name,
                    type = enterprise.type,
                    typeName = _typeRepository.GetById(enterprise.type).name
                };
            }
            else
                return null;
        }

        public List<EnterpriseViewModel> GetAll()
        {
            var enterprises = _enterpriseRepository.GetAll();
            var enterprisesViewModel = new List<EnterpriseViewModel>();

            foreach (var enterprise in enterprises)
            {
                var type = _typeRepository.GetById(enterprise.type);

                enterprisesViewModel.Add(new EnterpriseViewModel()
                {
                    enterpriseId = enterprise.enterpriseId,
                    name = enterprise.name,
                    type = enterprise.type,
                    typeName = type.name
                });
            }

            return enterprisesViewModel;
        }

        public List<EnterpriseViewModel> GetByTypeId(int typeId)
        {
            var enterprises = _enterpriseRepository.GetByType(typeId);
            var enterprisesViewModel = new List<EnterpriseViewModel>();

            foreach (var enterprise in enterprises)
            {
                enterprisesViewModel.Add(new EnterpriseViewModel()
                {
                    enterpriseId = enterprise.enterpriseId,
                    name = enterprise.name,
                    type = enterprise.type,
                    typeName = _typeRepository.GetById(enterprise.type).name
                });
            }

            return enterprisesViewModel;
        }
    }
}
