using IoasysApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Services.User
{
    public interface IUserService
    {
        UserViewModel SignIn(UserViewModel userViewModel);
    }
}
