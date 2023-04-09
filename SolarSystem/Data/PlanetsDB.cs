namespace SolarSystem.Data
{
    public static class PlanetsDB
    {
        public static List<Planet> GetListOfPlanets()
        {
            return new List<Planet>()
            {
                new Planet()
                {
                    Id = new Guid(),
                    OrderInTheSolarSystem = 1,
                    Name = "Mercurio",
                    Description = "Mercurio es el planeta del sistema solar más cercano al Sol y el más pequeño",
                    Mass = "3,302×10^23",
                    Volume = "6,083×10^10",
                    Density = 5.43f,
                    Radio = 2439.7f,
                    Surface = 4879.4f,
                    Gravity = 3.7f
                },
                new Planet()
                {
                    Id = new Guid(),
                    Name = "Venus",
                    OrderInTheSolarSystem = 2,
                    Description = "Venus es el segundo planeta del sistema solar en orden de proximidad al Sol y el tercero más pequeño después de Mercurio y Marte.",
                    Mass = "4,869×10^24",
                    Volume = "9,28x10^11",
                    Density = 5.24f,
                    Radio = 6051.8f,
                    Surface = 12103.6f,
                    Gravity = 8.87f,
                    AtmosphericPressure = 9321.9f
                },
                new Planet()
                {
                    Id = new Guid(),
                    Name = "Tierra",
                    OrderInTheSolarSystem = 3,
                    Description = "La Tierra (del latín Terra, deidad romana equivalente a Gea, diosa griega de la feminidad y la fecundidad) es un planeta del sistema solar que gira alrededor de su estrella, el Sol",
                    Mass = "5,9736×10^24",
                    Volume = "1,08321×10 12",
                    Density = 5.515f,
                    Radio = 6378.1f,
                    Surface = 0,
                    Gravity = 9.80665f,
                    AtmosphericPressure = 101.325f
                },
                new Planet()
                {
                    Id = new Guid(),
                    Name = "Marte",
                    OrderInTheSolarSystem = 4,
                    Description = "Marte es el cuarto planeta en orden de distancia al Sol y el segundo más pequeño del sistema solar, después de Mercurio",
                    Mass = "6,4185×10^23",
                    Volume = "1,6318×10^11",
                    Density = 3.9335f,
                    Radio = 3389.50f,
                    Surface = 6794.4f,
                    Gravity = 3.72076f,
                    AtmosphericPressure = 0.636f
                },
                new Planet()
                {
                    Id = new Guid(),
                    Name = "Júpiter",
                    OrderInTheSolarSystem = 5,
                    Description = "Júpiter es el planeta más grande del sistema solar y el quinto en orden de lejanía al Sol",
                    Mass = "1,899×10^27",
                    Volume = "1,4313×10^15",
                    Density = 1336f,
                    Radio = 71492f,
                    Surface = 142984f,
                    Gravity = 24.79f
                },
                new Planet()
                {
                    Id = new Guid(),
                    Name = "Saturno",
                    OrderInTheSolarSystem = 6,
                    Description = "Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después de Júpiter y el único con un sistema de anillos visible desde la Tierra.",
                    Mass = "5,688×10^26",
                    Volume = "8,27×10^23",
                    Density = 690f,
                    Radio = 58232f,
                    Surface = 120536f,
                    Gravity = 10.44f,
                    AtmosphericPressure = 1400f
                },
                new Planet()
                {
                    Id = new Guid(),
                    Name = "Urano",
                    OrderInTheSolarSystem = 7,
                    Description = "Urano es el séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo. Se llama así en honor de la divinidad griega del cielo Urano (del griego antiguo Οὐρανός), el padre de Crono (Saturno) y el abuelo de Zeus (Júpiter)",
                    Mass = "8,686×10^25",
                    Volume = "6,833×10^13",
                    Density = 1274f,
                    Radio = 25362f,
                    Surface = 51118f,
                    Gravity = 8.69f,
                    AtmosphericPressure = 120f
                },
                new Planet()
                {
                    Id = new Guid(),
                    Name = "Neptuno",
                    OrderInTheSolarSystem = 8,
                    Description = "Neptuno es el octavo planeta en distancia respecto al Sol y el más lejano del sistema solar. Forma parte de los denominados planetas exteriores, y dentro de estos, es uno de los gigantes helados, y es el primero que fue descubierto gracias a predicciones matemáticas.",
                    Mass = "1,024×10^26",
                    Volume = "6,254×10^13",
                    Density = 1.64f,
                    Radio = 24622f,
                    Surface = 49572f,
                    Gravity = 11.15f,
                    AtmosphericPressure = 100000
                }
            };
        }
    }
}
