using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        private bool bread = true;
        /// <summary>
        /// If the pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickel = true;
        /// <summary>
        /// If the pork is topped with pickel
        /// </summary>
        public bool Pickel
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// The price of the pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pork
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) itructions.Add("hold bread");
                if (!pickel) instructions.Add("hold pickel");

                return instructions;
            }
        }
    }
}
