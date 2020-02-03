using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree
    {
        /// <summary>
        /// price of the item
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// callories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// any special instructions for the entree
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }

    }
}
