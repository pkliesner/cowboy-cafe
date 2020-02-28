//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//Cowboy Coffee

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Drinks
{   
    /// <summary>
    /// A class for the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        private new bool ice = false;
        /// <summary>
        /// If the drink has ice
        /// </summary>
        public new bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool decaf = false;
        /// <summary>
        /// If the drink is decaf
        /// </summary>
        public  bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If the drink has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        /// <summary>
        /// Gets and sets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 3;
                    case (Size.Medium):
                        return 5;
                    case (Size.Large):
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets and sets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 0.60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Large):
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
   
        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the toString method
        /// </summary>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size.ToString() + " Decaf Cowboy Coffee";
            }
            else
            {
                return Size.ToString() + " Cowboy Coffee";
            }
        }
    }
}
