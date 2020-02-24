using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{ /// <summary>
  /// the Chili Cheese Fries are a side that comes in different sizes
  /// </summary>
    public class ChiliCheeseFries : Side

    {
        /// <summary>
        /// callories for all sizes of Chili Cheese Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
            
                
           

        }
        public override string ToString()
        {
            return this.Size.ToString()+ "Chilli Cheese Fries";
        }


        /// <summary>
        /// the price for each side for the Chili Cheese Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }






    }
}
