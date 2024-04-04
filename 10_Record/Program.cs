using _10_Record.Models;

namespace _10_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var newRecord = new Recode_task("ibrahim", 12, 34m);

            var newnewRecord = new Another_Record_task(12, "ibrahim", 34m);

            Console.WriteLine(newRecord.a);
            Console.WriteLine(newnewRecord.a);
        }
    }

    
}