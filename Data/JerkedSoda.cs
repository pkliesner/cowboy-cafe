//Patrick Kliesner
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

        private SodaFlavor Flavor;
        
        /// <summary>
        /// Gets and sets the calories of the drink
        /// </summary>
        public override double Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 110;
                        break;
                    case (Size.Medium):
                        return 146;
                        break;
                    case (Size.Large):
                        return 198;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets and sets the price of the drink
        /// </summary>
        public override uint Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                        break;
                    case (Size.Medium):
                        return 2.10;
                        break;
                    case (Size.Large):
                        return 2.59;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public List<string> SpecialInstructions
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
