﻿//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Entree

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Entrees
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of the entree
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }
    }
}
