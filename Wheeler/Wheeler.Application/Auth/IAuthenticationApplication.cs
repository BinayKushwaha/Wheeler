using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wheeler.Model.ViewModel;

namespace Wheeler.Application
{
    public interface IAuthenticationApplication
    {
        Task<ResponseModel> Login(LoginViewModel request);
        Task<ResponseModel> GetRefreshedToken(RefreshTokenViewModel request);
    }
}
