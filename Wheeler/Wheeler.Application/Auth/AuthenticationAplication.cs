using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wheeler.Domain.Auth;
using Wheeler.Model.ViewModel;

namespace Wheeler.Application
{
    public class AuthenticationAplication : IAuthenticationApplication
    {
        public readonly IAuthenticationDomain _authenticationDomain;
        public AuthenticationAplication(IAuthenticationDomain authenticationDomain)
        {
            _authenticationDomain = authenticationDomain;
        }
        public async Task<ResponseModel> Login(LoginViewModel request)
        {
            return await _authenticationDomain.Login(request);
        }
        public async Task<ResponseModel> GetRefreshedToken(RefreshTokenViewModel request)
        {
            return await _authenticationDomain.GetRefreshedToken(request);
        }
    }
}
