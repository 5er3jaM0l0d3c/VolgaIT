using HistoryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryServices.Interface
{
    public interface IHistory
    {
        public List<History> GetAccountHistory(int id);
        public History GetHistory(int id);
        public void AddHistory(History history);
        public void UpdateHistory(History history);
    }
}
