﻿//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//RustersRibs

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Entrees
{
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();



                return instructions;
            }
        }

        /// <summary>
        /// Overrides the toString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
