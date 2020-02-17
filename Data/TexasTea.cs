﻿//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Texas Tea

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class for the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// If the drink is sweet?
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        private bool lemon = false;
        /// <summary>
        /// If the drink has lemon
        /// </summary>
        private bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// The calories change on if the drink is sweet or not.
        /// </summary>
        public override double Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        if (sweet) return 10;
                        else if (!sweet) return 5;
                        break;
                    case (Size.Medium):
                        if (sweet) return 22;
                        else if (!sweet) return 11;
                        break;
                    case (Size.Large):
                        if (sweet) return 36;
                        else if (!sweet) return 18;
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
                        return 1.00;
                        break;
                    case (Size.Medium):
                        return 1.50;
                        break;
                    case (Size.Large):
                        return 2.00;
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
                if (lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }
    }
}
