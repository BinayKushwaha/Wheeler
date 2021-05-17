using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wheeler.Domain;
using Wheeler.Model.ViewModel;

namespace Wheeler.Application
{
    public interface IUserApplication
    {
        Task<RegisterUserViewModel> Register(RegisterUserViewModel model);
    }
}
