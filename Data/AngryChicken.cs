using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the chicken has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickel = true;
        /// <summary>
        /// If the chicken is topped with pickel
        /// </summary>
        public bool Pickel
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// The price of the chicken
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
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
