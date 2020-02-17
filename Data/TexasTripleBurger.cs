//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/9/2020
//TexasTripleBurger

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger : Entree
    {
        private bool tomato = true;
        /// <summary>
        /// If the burger has a tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { bun = value; }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger is topped with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger is topped with mustard
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        private bool bacon = true;
        /// <summary>
        /// If the burger is topped with bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }
        private bool egg = true;
        /// <summary>
        /// If the burger is topped with egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }


        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!tomato) itructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;
            }
        }
    }
}
