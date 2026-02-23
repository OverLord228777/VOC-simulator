using System.Collections.Generic;

namespace VOC_simulator
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        // Список цен на товары в городе
        // Ключ - товар, значение - текущая цена
        public Dictionary<TradeGood, double> Prices { get; set; } = new Dictionary<TradeGood, double>();
    }
}


