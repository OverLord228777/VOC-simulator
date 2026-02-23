using System.Collections.Generic;

namespace VOC_simulator
{
    public class TradeRoute
    {
        public int Id { get; set; }

        // Стартовый и конечный города торгового пути
        public City From { get; set; }
        public City To { get; set; }

        // Товары, которыми обычно торгуют по этому маршруту
        public List<TradeGood> Goods { get; set; } = new List<TradeGood>();

        // Примерная продолжительность путешествия (в днях)
        public int EstimatedDays { get; set; }
    }
}


