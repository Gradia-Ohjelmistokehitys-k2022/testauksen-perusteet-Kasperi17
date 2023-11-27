using Warehouse;


namespace WareHouse
{

    public class WareHouseClass
    {

        private List<Stock> _stockOfItems;
        public void WareHouseSimulator()
        {
            _stockOfItems = new();
            Stock item1 = new("Hat", 2);
            Stock item2 = new("Shoes", 3);
            Stock item3 = new("Jacket", 5);

            _stockOfItems.Add(item1);
            _stockOfItems.Add(item2);
            _stockOfItems.Add(item3);
        }

        public WareHouseClass()
        {

        }

        public void AddToStocks(string itemName, int itemCount)
        {
            Stock stock = new(itemName, itemCount);
            _stockOfItems.Add(stock);
           
        }

        public bool InStock(string itemName)
        {
            return _stockOfItems.Any(item => item.ItemName == itemName && item.Quantity > 0);
        }

        public void TakeFromStock(string itemName, int quantity)
        {
            Stock? stock = _stockOfItems.FirstOrDefault(item => item.ItemName == itemName && item.Quantity > 0);

            if (stock != null)
            {
                stock.Quantity -= quantity;

                if (stock.Quantity < 0)
                {
                    
                    throw new Exception("Negative stock quantity for " + itemName);
                }
            }
            else
            {
                throw new Exception("Oversold " + itemName);
            }
        }

        public int StockCount(string itemName)
        {
            //var matches = _stockOfItems.Where(item => item.ItemName == itemName);
            //return matches.Count();
            return _stockOfItems.Where(item => item.ItemName == itemName).Sum(item => item.Quantity);
        }

    }

    

}

