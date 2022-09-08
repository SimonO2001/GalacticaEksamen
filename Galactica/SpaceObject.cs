namespace Galactica
{
    internal abstract class SpaceObject
    {

        // Opretter properties som skal nedarves til alle klasserne.

        public int iD;

        public int Id
        {
            get { return iD; }
            set { iD = value; }
        }

        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual Position? Pos { get; set; }

        public class Position
        { 
            public int PosX { get; set; }
            public int PosY { get; set; }

        }

        
        // Metode som vil skrive kordianterne ind i den rigtige format (x,y).
        public override string ToString()
        {
            if (Pos != null)
                return ($"{Pos.PosX},{Pos.PosY}");
            else return String.Empty;
        }

      

    }

    // Opretter enum at type StarType, og PlanetType.
    public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
    public enum PlanetType { Terrestial, Giant, Dwarf, GasGiant }

    
      

        

    
}
