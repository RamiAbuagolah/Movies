using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.DTO;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILoginService LoginService;
        private readonly IMailService mailService;
        public LoginController(ILoginService LoginService, IMailService mailService)
        {
            this.LoginService = LoginService;
            this.mailService = mailService;
        }
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Login), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetLogin")]//sub route
        public List<Login> GetLogin()
        {
            return LoginService.GetLogin();
        }
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Login), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertLogin")]//sub route
        public bool InsertLogin([FromBody] Login log)
        {
            return LoginService.InsertLogin(log);
        }
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Login), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteLogin/{id}")]//sub route
        public bool DeleteLogin(int id)
        {
            return LoginService.DeleteLogin(id);
        }
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Login), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateLogin")]//sub route
        public bool UpdateLogin([FromBody] Login log)
        {
            return LoginService.UpdateLogin(log);
        }
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Login), StatusCodes.Status400BadRequest)]
        [HttpPost]
        public string Authentication([FromBody]LoginDTO login)
        {
            return LoginService.Authentication(login);
        }
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Login), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("ResetPassword")]//sub route
        public bool ResetPassword(ResetPasswordDTO resetPassword)
        {
            return LoginService.ResetPassword(resetPassword);
        }
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Login), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("SendVerification/{username}")]//sub route
        public async Task<IActionResult> SendVerification(string username)
        {
            try
            {
                await mailService.SendVerification(username);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
