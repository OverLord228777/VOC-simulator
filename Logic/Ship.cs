namespace VOC_simulator
{
    public class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Грузоподъёмность корабля
        public double CargoCapacity { get; set; }

        // Текущий объём груза на борту
        public double CurrentCargo { get; set; }

        // Целевой порт назначения
        public City Destination { get; set; }

        // Количество дней в море
        public int DaysAtSea { get; set; }
    }
}


