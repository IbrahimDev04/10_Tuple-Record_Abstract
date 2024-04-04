using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Abstract.Models
{
    internal class AsusRog : Asus
    {
        public override void AsusVersion()
        {
            Console.WriteLine("Asus Rog Strix");
        }

        public override void ComMark()
        {
            Console.WriteLine("Asus Shop");
        }

        public override void WhichType()
        {
            Console.WriteLine("Electronic");
        }
    }
}
