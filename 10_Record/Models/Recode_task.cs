using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Record.Models
{
    internal record Recode_task 
    { 
    
        public string a ;
        public int b;
        public decimal c;

        public Recode_task(string a, int b, decimal c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
