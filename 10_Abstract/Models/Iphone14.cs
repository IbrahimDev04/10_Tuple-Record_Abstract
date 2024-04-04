using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Abstract.Models
{
    internal class Iphone14 : Iphone
    {
        public override void WhichType()
        {
            Console.WriteLine("Electronic market");
        }

        public override void GoodsType()
        {
            Console.WriteLine("Mobil Shop");
        }

        public override void TelMark()
        {
            Console.WriteLine("Iphone Shop");
        }

        public override void PhoneVersion()
        {
            Console.WriteLine("Iphone 14");
        }
    }
}
