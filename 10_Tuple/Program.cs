namespace _10_Tuple_Record_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int, string) tup1 = (18, "ibrahim");
            (int, string, int) tup2 = (18, "ibrahim",75);
            (int, string, decimal, float) tup3 = (18, "ibrahim", 43m , 34f);
        }
    }
}