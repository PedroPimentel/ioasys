using IoasysApi.Repositories;
using IoasysApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserViewModel SignIn(UserViewModel userViewModel)
        {
            var user = _userRepository.SignIn(userViewModel);

            if (user != null)
            {
                return new UserViewModel
                {
                    userId = user.userId,
                    email = user.email,
                    authenticated = true
                };
            }

            return new UserViewModel
            {
                authenticated = false
            };
        }
    }
}
