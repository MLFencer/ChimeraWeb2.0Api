using ChimeraApi.Data;
using ChimeraApi.Data.EF;
using ChimeraApi.LogicInterfaces;
using ChimeraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChimeraApi.Logic
{
    public class LoginRegisterLogic: ILoginRegisterLogic
    {
        private IUnitOfWork _uow;
        public LoginRegisterLogic(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Login(Login login)
        {

        }

        public void Register(Register register)
        {
            Users user = new Users()
            {
                DisplayName = register.UserName,
                UserName = register.UserName,
                Email = register.Email,
                LastLoginDateTime = DateTime.UtcNow,
                RegistrationDateTime = DateTime.UtcNow,
                UserDataId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
                PasswordHash = ""
            };
        }
    }
}
