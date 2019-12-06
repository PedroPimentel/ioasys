using IoasysApi.Models.Entities;
using IoasysApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Repositories
{
    public interface IUserRepository
    {
        User SignIn(UserViewModel userViewModel);
    }
}
