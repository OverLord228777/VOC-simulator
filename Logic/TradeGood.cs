namespace VOC_simulator
{
    public class TradeGood
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Базовая цена товара
        public double BasePrice { get; set; }

        // Волатильность цены (0..1 или в процентах)
        public double Volatility { get; set; }
    }
}


