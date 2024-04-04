namespace _10_Abstract.Models
{
    internal abstract class ComputerShop : Electronic
    {
        public abstract void ComMark();

        public override void GoodsType()
        {
            Console.WriteLine("Computer shop");
        }
    }
}
