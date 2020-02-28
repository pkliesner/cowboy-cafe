//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Water

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Drinks
{
    /// <summary>
    /// A class for water
    /// </summary>
    public class Water : Drink
    {

        private bool lemon = false;
        /// <summary>
        /// If the drink has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// The calories change on if the drink is sweet or not.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }


        /// <summary>
        /// Gets and sets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the toString method
        /// </summary>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
