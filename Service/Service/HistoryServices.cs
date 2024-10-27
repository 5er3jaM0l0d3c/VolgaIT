using HistoryEntities;
using HistoryServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryServices.Service
{
    public class HistoryServices : IHistory
    {
        private HistoryDbVolgaItContext context {  get; set; }
        public HistoryServices(HistoryDbVolgaItContext context)
        {
            this.context = context;
        }

        public List<History> GetAccountHistory(int id)
        {
            return context.history.Where(x => x.pacientid == id).ToList();
        }

        public History GetHistory(int id)
        {
            return context.history.FirstOrDefault(x => x.id == id);
        }

        public void AddHistory(History history)
        {
            context.history.Add(history);
            context.SaveChanges();
        }

        public void UpdateHistory(History history)
        {
            context.history.Update(history);
            context.SaveChanges();
        }
    }
}
