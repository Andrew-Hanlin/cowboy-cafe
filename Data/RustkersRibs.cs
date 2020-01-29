using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class RustlersRibs
    {
     
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

               // instructions.Add("no speical instructions");

                return instructions;
            }
        }
    }
}

