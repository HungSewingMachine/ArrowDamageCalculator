using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamageCalculator
{
    class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        /// <summary>
        /// The constructor calculates damage based on default Magic
        /// and Flaming value and a starting 3d6 roll
        /// </summary>
        /// <param name="startingRoll"></param>
        public ArrowDamage(int startingRoll) : base(startingRoll) { }  // The constructor sets the backing field for the Roll property
                                                  // then calls CalculateDamage to make sure the Damage propety is correct
        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) baseDamage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }

    }
}
