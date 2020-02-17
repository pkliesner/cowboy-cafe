//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//ChiliCheeseFries

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Gets and sets the size of the side
        /// </summary>
        public enum Size
        {
            small, medium, large
        }
        
        /// <summary>
        /// Gets and sets the calories of the side
        /// </summary>
        public override double Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 433;
                        break;
                    case (Size.Medium):
                        return 524;
                        break;
                    case (Size.Large):
                        return 610;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets and sets the price of the side
        /// </summary>
        public override uint Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.99;
                        break;
                    case (Size.Medium):
                        return 2.99;
                        break;
                    case (Size.Large):
                        return 3.99;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
