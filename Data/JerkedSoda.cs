﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public override double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }
        public override string ToString()
        {
            string flavor;
            switch (this.Flavor)
            {
                case SodaFlavor.CreamSoda:
                    flavor = " Cream Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    flavor = " Orange Soda";
                    break;
                case SodaFlavor.Sarsparilla:
                    flavor = " Sarsparilla";
                    break;
                case SodaFlavor.BirchBeer:
                    flavor = " Birch Beer";
                    break;
                case SodaFlavor.RootBeer:
                    flavor = " Root Beer";
                    break;
                default:
                    flavor = null;
                    break;
            }

            return this.Size.ToString() +flavor+" Jerked Soda";
        }

        public override uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }
        //   public bool Sweet { get; set; } = true;
        //  public bool Lemon { get; set; } = false;
        public SodaFlavor Flavor { get; set; }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
              //  if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
