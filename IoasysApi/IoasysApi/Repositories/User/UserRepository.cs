using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoasysApi.Models.Context;
using IoasysApi.Models.Entities;
using IoasysApi.ViewModel;

namespace IoasysApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiDbContext _context;

        public UserRepository(ApiDbContext context)
        {
            _context = context;
        }
        public User SignIn(UserViewModel userViewModel)
        {
            return _context.TbUser.FirstOrDefault(u => u.email == userViewModel.email && u.password == userViewModel.password);
        }
    }
}
