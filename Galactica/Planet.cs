namespace Galactica
{
    internal class Planet : SpaceObject
    {
        Star star = new();
        

        // Opretter forskellige properties til planet.

        private StarType starType;

        public StarType StarType
        {
            get { return starType; }
            set { starType = value; }
        }


        public PlanetType planetType;
        
        public PlanetType PlanetType
        {
            get { return planetType; }
            set { planetType = value; }
        }

        public int diameter;

        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public int rotationPeriod;

        public int RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }

        public int revolutionPeriod;

        public int RevolutionPeriod
        {
            get { return revolutionPeriod; }
            set { revolutionPeriod = value; }
        }

        // Opretter en liste til at indsætte vores måne værdier.
        public List<Moon> MoonList { get; set; } = new();


        // Metode for at beregne distancen.
        public double Distance(double x2, double y2)
        {
            

            double finalDistance = Math.Sqrt((Math.Pow(x2 - Pos.PosX, 2) + Math.Pow(y2 - Pos.PosY, 2)));

            

            return finalDistance;
            


        }
        public Planet()
        {

        }

        // CTOR for Planet, hvor man kun selv skal indsætte navn, og så opretter den selv de andre properties.
        public Planet(string name)
        {
            Random rand = new();
            Pos = new();
            Id = 1;

            this.name = name;
            Id = Id++;
            revolutionPeriod = rand.Next(1, 69);
            rotationPeriod = rand.Next(3, 69);
            diameter = rand.Next(300000, 6900000);
            planetType = (PlanetType)rand.Next(0, 4);
            
            Pos.PosX = rand.Next(69, 420000);
            Pos.PosY = rand.Next(69, 420000);
            


        }
    }
}
