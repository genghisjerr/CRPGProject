using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGProject
{
    public class World
    {
        public static readonly string WorldName = "Elder Plane";
        public static readonly List<Location> Locations = new List<Location>();

        //Start providing IDs for locations
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_FOREST_PATH = 2;
        public const int LOCATION_ID_LAB = 3;
        
        //Constructor for the World
        static World()
        {
            PopulateLocations();
        }

        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "this is your house???");
            Location forestPath = new Location(LOCATION_ID_FOREST_PATH, "Forest Path", "a path in the middle of the woods");
            Location lab = new Location(LOCATION_ID_LAB, "Lab", "a secret laboratory. ooohhhh");
        }

    }
}
