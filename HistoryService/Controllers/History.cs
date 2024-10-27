using HistoryServices.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HistoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class History : ControllerBase
    {
        private IHistory Histories {  get; set; }
        public History(IHistory history)
        {
            Histories = history;
        }

        [HttpGet("Account")]
        public List<HistoryEntities.History> GetAccountHistory(int id)
        {
            return Histories.GetAccountHistory(id);
        }

        [HttpGet]
        public HistoryEntities.History GetHistory(int id)
        {
            return Histories.GetHistory(id);
        }

        [HttpPost]
        public void AddHistory([FromBody] HistoryEntities.History history)
        {
            Histories.AddHistory(history);
        }

        [HttpPut]
        public void UpdateHistory([FromBody] HistoryEntities.History history)
        {
            Histories.UpdateHistory(history);
        }
    }
}
