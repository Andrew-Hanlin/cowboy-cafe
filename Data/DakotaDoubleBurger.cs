﻿using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        private bool cheese = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool bun = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with bun
        /// </summary>
        /// 
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with sour cream
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with green onions
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }


        private bool tomato = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with lettuce
        /// </summary>
        /// 
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the Dakota Double Burger is topped with sour cream
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }


        /// <summary>
        /// The price of the Dakota Double Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the Dakota Double Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!tomato) instructions.Add("hold tomato");

                return instructions;
            }
        }
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}

