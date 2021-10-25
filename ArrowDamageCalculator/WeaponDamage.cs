using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamageCalculator
{
    class WeaponDamage
    { 
        /// <summary>
        /// Contains the calculated damage
        /// </summary>
        public int Damage { get; protected set; }

        private int roll;
        /// <summary>
        /// Sets or gets the 3d6 roll
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool magic;
        /// <summary>
        /// True if the sword is magic, false otherwise
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        /// <summary>
        /// True if the sword is flaming, false otherwise
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        protected virtual void CalculateDamage()
        {
            /* The subclass override this*/
        }
        public WeaponDamage(int startingRoll)
        {
            Roll = startingRoll;
            CalculateDamage();
        }
    }
}
