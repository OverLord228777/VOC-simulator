using System.Collections.Generic;

namespace VOC_simulator
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Id персонажа-владельца (например, директора)
        public int OwnerId { get; set; }

        // Казна компании
        public double Treasury { get; set; }

        // Флот компании
        public List<Ship> Fleet { get; set; } = new List<Ship>();
    }
}


