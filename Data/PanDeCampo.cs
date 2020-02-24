using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{ /// <summary>
  /// the Pan De Campo are a side that comes in different sizes
  /// </summary>
    public class PanDeCampo : Side

    {  /// <summary>
       /// callories for all sizes of Pan De Campo
       /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
            
                
           

        }

        public override string ToString()
        {
            return this.Size.ToString()+" Pan de Campo";
        }


        /// <summary>
        /// the price for each side for the Pan De Campo
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






    }
}
