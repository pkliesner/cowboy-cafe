//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Side

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Sides
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }


        public virtual Size Size { get; set; }

        public List<string> SpecialInstructions => throw new NotImplementedException();
    }
}
