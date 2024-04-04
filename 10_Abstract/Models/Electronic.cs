using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Abstract.Models
{
    abstract class Electronic : Shops
    {

        public abstract void GoodsType();

        public override void WhichType()
        {
            Console.WriteLine("Here is market");
        }
    }
}
