using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Doctors : ControllerBase
    {
        private IAccount Account { get; set; }
        public Doctors(IAccount account)
        {
            Account = account;
        }

        [HttpGet]
        public List<Account> GetDoctors()
        {
            return Account.Doctors();
        }

        [HttpGet("Id")]
        public Account GetDoctor([FromRoute]int id)
        {
            return Account.DoctorId(id);
        }
    }
}
