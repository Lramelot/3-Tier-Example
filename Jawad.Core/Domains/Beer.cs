namespace Jawad.Core.Domains
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double AlcoolPercentage { get; set; }

        public Brewer Brewer { get; set; }
    }
}