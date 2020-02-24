using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {







        //public bool Ice = false;
        public override double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }
        public override string ToString()
        {
            string decaf = "";
            if (this.Decaf) { decaf = " Decaf"; }
            return this.Size.ToString()+decaf+" Cowboy Coffee";
        }
        public CowboyCoffee(){
            Ice = false;
        }
        public override uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }
           public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; }
        // public SodaFlavor Flavor { get; set; }
        
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
               
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
    }
}
