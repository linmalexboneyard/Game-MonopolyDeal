﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;
using MonopolyConsole.PropertyCards;

namespace MonopolyConsole.PropertyWildcards
{
    class YellowRed: PropertyCard
    {
        public YellowRed()
        {
            Value = 3;
            Name = "Yellow or Red";
        }
    }
}
