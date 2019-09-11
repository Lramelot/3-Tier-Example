namespace Jawad.Service.Beers.Commands
{
    public class CreateBeerCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double AlcoolPercentage { get; set; }
        public int BrewerId { get; set; }
    }
}