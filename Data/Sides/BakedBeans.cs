//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Baked Beans

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Sides
{
    public class BakedBeans : Side
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
                        return 312;
                    case (Size.Medium):
                        return 378;
                    case (Size.Large):
                        return 410;
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
                        return 1.59;
                    case (Size.Medium):
                        return 1.79;
                    case (Size.Large):
                        return 1.99;
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
            return Size.ToString() + " Baked Beans";
        }
    }
}
