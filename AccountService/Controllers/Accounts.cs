using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Accounts : ControllerBase
    {
        private IAccount Account { get; set; }
        public Accounts(IAccount account)
        {
            Account = account;
        }

        [HttpGet("Me")]
        public Account Me(int id)
        {
            return Account.Me(id);
        }

        [HttpPut("Update")]
        public void Update([FromBody] Account account)
        {
            Account.Update(account);
        }

        [HttpGet]
        public List<Account> GetAccounts(int from, int count)
        {
            return Account.Accounts(from, count);
        }

        [HttpPost]
        public void Post([FromBody] Account account)
        {
            Account.Accounts(account);
        }

        [HttpPut]
        public void UpdateByAdmin([FromBody] Account account)
        {
            Account.UpdateByAdmin(account);
        }

        [HttpDelete]
        public void DeleteByAdmin([FromRoute]int id)
        {
            Account.DeleteByAdmin(id);
        }

       
    }
}
