using _10_Abstract.Models;

namespace _10_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsusRog asusrog = new AsusRog();
            AsusViva asusviva = new AsusViva();

            asusrog.GoodsType();
            asusviva.GoodsType();
        }
    }
}