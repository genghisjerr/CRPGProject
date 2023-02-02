﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGProject
{
    public class Items
    {
        public int ID;
        public string Name;
        public string NamePlural;

        public Items(int iD, string name, string namePlural)
        {
            ID = iD;
            Name = name;
            NamePlural = namePlural;
        }

        public Items() { }
    }
}
