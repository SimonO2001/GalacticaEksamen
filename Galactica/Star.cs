namespace Galactica
{
    internal class Star : SpaceObject
    {
        // Opretter star.
        public Star()
        {
            Pos = new();
            Name = "Sun";
            Pos.PosX = 0;
            Pos.PosY = 0;

        }

        private int temperature;

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

         

        // Opretter liste til at indsætte vores planeter i.
        public List<Planet> PlanetList { get; set; } = new();

        
    }

        


    
}
