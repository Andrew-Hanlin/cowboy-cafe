using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// the baked breans are a side that comes in different sizes
    /// </summary>
    public class BakedBeans  : Side

    {
        /// <summary>
        /// callories for all sizes of baked beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
            
                
           

        }

    

        /// <summary>
        /// the price for each side for the baked beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }





        public override string ToString()
        {
            return this.Size.ToString()+ " Baked Beans";
        }
    }
}
