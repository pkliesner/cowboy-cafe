//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Baked Beans

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Gets and sets the size of the side
    /// </summary>
    public enum Size
    {
        small, medium, large
    }
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
                        break;
                    case (Size.Medium):
                        return 378;
                        break;
                    case (Size.Large):
                        return 410;
                        break;
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
                        break;
                    case (Size.Medium):
                        return 1.79;
                        break;
                    case (Size.Large):
                        return 1.99;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
