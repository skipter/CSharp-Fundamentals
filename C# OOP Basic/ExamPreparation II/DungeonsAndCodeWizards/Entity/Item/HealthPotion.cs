﻿using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entity.Character;

namespace DungeonsAndCodeWizards.Entity.Item
{
    public class HealthPotion : Item
    {
        private const int HealthPotionWeight = 5;

        public HealthPotion() 
            : base(HealthPotionWeight)
        {
        }

        public override void AffectCharacter(Character.Character character)
        {
            base.AffectCharacter(character);
        }
    }
}