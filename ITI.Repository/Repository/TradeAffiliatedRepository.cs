using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;
using System.Data.Entity;


namespace ITI.Repository.Repository
{
    public class TradeAffiliatedRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public TradeAffiliatedRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<TradeAffiliated> GetTrades()
        {
            return iTIDataEntities.TradeAffiliateds.ToList();
        }
        public TradeAffiliated GetTradeAffiliatedById(int id)
        {
            return iTIDataEntities.TradeAffiliateds.FirstOrDefault(x => x.ID == id);
        }
        public TradeAffiliated InsertTradeAffiliated(TradeAffiliated tradeAffiliated)
        {
            var inserted = iTIDataEntities.TradeAffiliateds.Add(tradeAffiliated);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public TradeAffiliated UpdateTradeAffiliated(TradeAffiliated tradeAffiliated)
        {
            iTIDataEntities.Entry(tradeAffiliated).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return tradeAffiliated;
        }
        public void DelectTradeAffiliated(int id)
        {
            var trade = iTIDataEntities.TradeAffiliateds.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.TradeAffiliateds.Remove(trade);
            iTIDataEntities.SaveChanges();
        }
    }
}
