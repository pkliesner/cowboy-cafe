//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Cowboy Coffee

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{   
    /// <summary>
    /// A class for the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        private bool ice = false;
        /// <summary>
        /// If the drink has ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If the drink has room for cream
        /// </summary>
        private bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

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
                        return 3;
                        break;
                    case (Size.Medium):
                        return 5;
                        break;
                    case (Size.Large):
                        return 7;
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
                        return 0.60;
                        break;
                    case (Size.Medium):
                        return 1.10;
                        break;
                    case (Size.Large):
                        return 1.60;
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

                if (ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }
    }
}
