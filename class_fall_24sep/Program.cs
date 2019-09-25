using System;

namespace class_fall_24sep
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Relative r = new Relative("Mr.", "Sai", "AKshith", "Brother");
            Console.WriteLine(r.getPrintName());
            Console.WriteLine(r.getRelation());
            

            
        }
    }
}
