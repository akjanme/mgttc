using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;
using System.Data.Entity;


namespace ITI.Repository.Repository
{
    public class TradeAffiliationSouRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public TradeAffiliationSouRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<TradeAffiliationSou> GetTrades()
        {
            return iTIDataEntities.TradeAffiliationSous.ToList();
        }
        public TradeAffiliationSou GetTradeAffiliationSouById(int id)
        {
            return iTIDataEntities.TradeAffiliationSous.FirstOrDefault(x => x.ID == id);
        }
        public TradeAffiliationSou InsertTradeAffiliationSou(TradeAffiliationSou tradeAffiliationSou)
        {
            var inserted = iTIDataEntities.TradeAffiliationSous.Add(tradeAffiliationSou);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public TradeAffiliationSou UpdateTradeAffiliationSou(TradeAffiliationSou tradeAffiliationSou)
        {
            iTIDataEntities.Entry(tradeAffiliationSou).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return tradeAffiliationSou;
        }
        public void DelectTradeAffiliationSou(int id)
        {
            var trade = iTIDataEntities.TradeAffiliationSous.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.TradeAffiliationSous.Remove(trade);
            iTIDataEntities.SaveChanges();
        }
    }
}
