﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonTrainer
{
    internal class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
    }
}
