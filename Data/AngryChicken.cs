using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the AngryChicken entree
    /// </summary>
    public class AngryChicken: Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the AngryChicken is topped with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the AngryChicken is topped with Pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

       /// <summary>
       /// the price of the AngryChicken
       /// </summary>
        public override double  Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the AngryChicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the AngryChicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");


                return instructions;
            }
        }
        public override string ToString()
        {
            return "AngryChicken";
        }
    }
}

