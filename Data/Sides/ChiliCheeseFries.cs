//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//ChiliCheeseFries

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Sides
{
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Gets and sets the calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 433;
                    case (Size.Medium):
                        return 524;
                    case (Size.Large):
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets and sets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.99;
                    case (Size.Medium):
                        return 2.99;
                    case (Size.Large):
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Overrides the toString method
        /// </summary>
        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";
        }
    }
}
