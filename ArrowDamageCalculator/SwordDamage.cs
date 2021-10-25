using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamageCalculator
{ 
    class SwordDamage : WeaponDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        /// <summary>
        /// The constructor calculates damage based on default Magic
        /// and Flaming value and a starting 3d6 roll
        /// </summary>
        /// <param name="startingRoll"></param>
        public SwordDamage(int startingRoll) : base(startingRoll) { } // The constructor sets the backing field for the Roll property
        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }

    }
}
