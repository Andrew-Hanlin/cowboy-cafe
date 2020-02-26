using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {

        List<string> SpecialIstructions { get; }

        double Price { get; }



    }
}
