using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wheeler.Model.ViewModel;

namespace Wheeler.Domain
{
    public interface IUserDomain
    {
        Task<RegisterUserViewModel> Register(RegisterUserViewModel model);
    }
}
