using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trail Burger entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
       
        private bool bread = true;
        /// <summary>
        /// If the Trail Burger is topped with bun
        /// </summary>
        /// 
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

       


        private bool pickle = true;
        /// <summary>
        /// If the Trail Burger is topped with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }



        /// <summary>
        /// The price of the Trail Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the Trail Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Trail Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!pickle) instructions.Add("hold pickle");
                if (!bread) instructions.Add("hold bread");

                return instructions;
            }
        }

    }
}

