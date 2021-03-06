﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animals
{
    class Pig : Animal
    {
        public Pig(string name, int energy, int happiness, int procedureTime)
            : base(name, energy, happiness, procedureTime)
        {
        }

        public override string ToString()
        {
            return $"    Animal type: {GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
