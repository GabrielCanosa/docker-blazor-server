namespace SolarSystem.Data
{
    public class PlanetService
    {
        public List<Planet> GetAllPlanets()
        {
            return PlanetsDB.GetListOfPlanets();
        }

        public Planet? GetPlanetByOrder(int id)
        {
            return PlanetsDB.GetListOfPlanets().Where(x => x.OrderInTheSolarSystem == id).FirstOrDefault();
        }
    }
}
