using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        public override double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 1.0;
                    case Size.Medium:
                        return 1.5;
                    case Size.Large:
                        return 2.0;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }


        public override uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        if (!Sweet) { return 5; }
                        return 10;
                    case Size.Medium:
                        if (!Sweet) { return 11; }

                        return 22;
                    case Size.Large:
                        if (!Sweet) { return 18; }

                        return 36;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }
        public bool Sweet { get; set; } = true;
        public bool Lemon { get; set; } = false;

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        public override string ToString()
        {
            string sweet;
            if (Sweet) { sweet = "Sweet"; } else { sweet = "Plain"; }
            return this.Size.ToString() + " Texas " + sweet + " Tea";
        }
    }
}
