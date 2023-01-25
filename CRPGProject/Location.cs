﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGProject
{
    public class Location
    {
        public int ID;
        public string Name;
        public string Description;
        public Location LocationToNorth;
        public Location LocationToEast;
        public Location LocationToSouth;
        public Location LocationToWest;

        //Constructor

        public Location(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }

       

    }
}
