namespace SolarSystem.Data
{
    public class Planet
    {
        public Guid Id { get; set; }
        public int OrderInTheSolarSystem { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Mass { get; set; } // Kg
        public string? Volume { get; set; } // Km³
        public float? Density { get; set; } // g/cm³
        public float? Radio { get; set; } // km
        public float? Surface { get; set; } // km
        public float? Gravity { get; set; } // m/s²
        public float? AtmosphericPressure { get; set; } // kPa
    }
}
