﻿//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Jerked Soda

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class fro the JerkedSoda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        public SodaFlavor Flavor;
        
        /// <summary>
        /// Gets and sets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 110;
                    case (Size.Medium):
                        return 146;
                    case (Size.Large):
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets and sets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Large):
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
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
                return instructions;
            }
        }
    }
}
