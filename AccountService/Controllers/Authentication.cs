using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Authentication : ControllerBase
    {
        private IAccount Account { get; set; }
        public Authentication(IAccount account)
        {
            this.Account = account;
        }

        [HttpPost("SighUp")]
        public void SignUp([FromBody]Account account)
        {
            Account.SignUp(account);
        }

        [HttpPost("SignIn")]
        public string SignIn([FromBody] Account account)
        {
            return Account.SignIn(account.username, account.password);
        }

        [HttpPut("SignOut")]
        public void SignOut()
        {
            Account.SignOut();
        }

        [HttpGet("Validate")]
        public bool Validate(string accessToken)
        {
            return Account.Validate(accessToken);
        }

        [HttpPost("Refresh")]
        public string Refresh([FromBody]string accessToken) 
        {
            return Account.Refresh(accessToken);
        }

    }
}
