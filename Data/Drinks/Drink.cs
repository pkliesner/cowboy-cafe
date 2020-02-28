//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Drink

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Drinks
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of the drink
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }

        /// <summary>
        /// Gets and sets the ice value for the drink, default true
        /// </summary>
        public bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
    }
}
