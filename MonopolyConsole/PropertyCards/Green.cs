﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class Green:Card
    {
        public Green(string name)
        {
            Value = 4;
            Name = name;
            Description = "";
        }
    }
}
