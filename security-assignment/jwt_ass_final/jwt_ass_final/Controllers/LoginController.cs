using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using jwt_ass_final.Model;
using jwt_ass_final.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace jwt_ass_final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        private readonly IConfiguration _config;
        private readonly ITokenGeneration _generate;
        UserInfoDataAccessLayer UserInfoDataAccess = new UserInfoDataAccessLayer();


        public LoginController(IConfiguration config,ITokenGeneration tokenGeneration)
        {
            _generate = tokenGeneration;
            _config = config;
        }



        //this method is a get method which takes username and password from the url
        [HttpGet]
        public IActionResult Login(string UserName, string pass)
        {
            try
            {


                UserModel login = new UserModel();
                login.LoginId = UserName;
                login.Password = pass;
                IActionResult response = Unauthorized();

                var user = AuthenticateUser(login);
                if (user != null)
                {
                    var tokenStr = _generate.GenerateJSONWebToken(user);
                    response = Ok(new { token = tokenStr });
                    return response;
                }
                else
                {
                    return Ok(BadRequest("Wrong entries"));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }

        //this method will authenticate our user
        private UserModel AuthenticateUser(UserModel login)
        {
            try
            {
                UserModel user = UserInfoDataAccess.GetLoginUser(login);
                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //static user info
            //if(login.Username=="latika" && login.Password == "123")
            //{
            //    user = new UserModel { Username = "latika", Email = "latika@tothenew.com", Password = "123" };
            //}

        }


        // Get Method which is accessed by admin only

        [Authorize(Roles = "administrator")]
        [HttpPost("Post")]
           
		public string Post()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                IList<Claim> claim = identity.Claims.ToList();
                var UserName = claim[0].Value;
                return "Welcome : " + UserName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
	
        

        // Get Method which is accessed by users only

        [Authorize(Roles = "user")]
        [HttpGet("GetValue")]
        public ActionResult<IEnumerable<string>> Get()
        {
            try

            {
                return new string[]
                {
                    "Hi, i'm in getValue function"
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}