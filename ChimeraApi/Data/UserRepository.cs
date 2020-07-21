using ChimeraApi.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChimeraApi.Data
{
    public class UserRepository : IUserRepository
    {
        private ChimeraContext _context;

        public UserRepository(ChimeraContext context)
        {
            _context = context;
        }

        public IUserRepository WithContext(ChimeraContext context)
        {
            _context = context;
            return this;
        }

        public int CreateUser(Users user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges();
        }

    }
}
