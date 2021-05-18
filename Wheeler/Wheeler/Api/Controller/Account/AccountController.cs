using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheeler.Application;
using Wheeler.Model.DbEntities;
using Wheeler.Model.ViewModel;
using Wheeler.Utils.CustomException;

namespace Wheeler.Web.Api.Controller.Account
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserApplication _userApplication;
        public AccountController(IUserApplication userApplication) 
        {
            this._userApplication = userApplication;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserViewModel request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid inputs.");
               var result= await _userApplication.Register(request);
                return Ok(ResponseModel.Success("User registered successfully.",result));
            }
            catch(CustomException ex)
            {
                return StatusCode(StatusCodes.Status501NotImplemented, ResponseModel.Info(ex.Message, request));
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseModel.Error("Something went wrong. Please contact administartor."));
            }
        }
    }
}
