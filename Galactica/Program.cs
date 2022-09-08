using Galactica;

namespace Galactica
{

    public class lol
    {
        static void Main(string[] args)
        {
            Star star = new();
            
            
            // Opretter nye objekter af Planet og tildeler dem navn.
            Planet Mercury = new Planet("Mercury");
            Planet Venus = new Planet("Venus");
            Planet Earth = new Planet("Earth");
            Planet Mars = new Planet("Mars");

            Planet Jupiter = new Planet("Jupiter");
            Planet Saturn = new Planet("Saturn");
            Planet Uranus = new Planet("Uranus");
            Planet Neptune = new Planet("Neptune");

            // Opretter nye objekter af Moon, og tildeler dem navn.
            Moon Luna = new Moon("Luna");
            Moon Titan = new Moon("Titan");
            Moon Phobos = new Moon("Phobos");
            Moon Europe = new Moon("Europe");

            Moon Deimos = new Moon("Deimos");
            Moon Ganymedes = new Moon("Ganymedes");
            Moon Io = new Moon("Io");
            Moon Mimas = new Moon("Mimas");

            // Tilføjer måner deres orbiting planet.
            Luna.Orbiting = Mercury;
            Titan.Orbiting = Venus;
            Phobos.Orbiting = Earth;
            Europe.Orbiting = Mars;
            Deimos.Orbiting = Jupiter;
            Ganymedes.Orbiting = Saturn;
            Io.Orbiting = Uranus;
            Mimas.Orbiting = Neptune;

            // Tilføjer planeterne til liste.
            star.PlanetList.Add(Mercury);
            star.PlanetList.Add(Venus);
            star.PlanetList.Add(Earth);
            star.PlanetList.Add(Mars);
            star.PlanetList.Add(Jupiter);
            star.PlanetList.Add(Saturn);
            star.PlanetList.Add(Uranus);
            star.PlanetList.Add(Neptune);

            // Tilføjer månerne til liste.
            Mercury.MoonList.Add(Luna);
            Venus.MoonList.Add(Titan);
            Earth.MoonList.Add(Phobos);
            Mars.MoonList.Add(Europe);
            Jupiter.MoonList.Add(Deimos);
            Saturn.MoonList.Add(Ganymedes);
            Uranus.MoonList.Add(Io);
            Neptune.MoonList.Add(Mimas);

            // Udskriver vores data fra planetlist.
            foreach (Planet planet in star.PlanetList)
            {
                Console.WriteLine($"Name: {planet.name}\t\tType: {planet.PlanetType}\t\tDiameter: {planet.diameter}\n" +
                    $"Rotation: {planet.RotationPeriod}\t\tRevolution: {planet.RevolutionPeriod}\t\t Distance to sun: {planet.Distance(star.Pos.PosX, star.Pos.PosY)}");
                
                
                // udskriver vores data fra MoonList.
                foreach (var Moon in planet.MoonList)
                {
                    Console.WriteLine($"Name: {Moon.Name}\t\tOrbiting planet: {Moon.Orbiting.Name}\t\t");
                }
            }

        }


    }


}

