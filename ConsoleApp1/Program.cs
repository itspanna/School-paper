using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Program
    {
        static void Kiir(IEnumerable<object> szemely)
        {
            foreach (var item in szemely)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            AbContext db = new AbContext();

            if (!db.People.Any())
            {
                var sorok = File.ReadAllLines(@"\Database\2.csv").Skip(1);
                foreach (var line in sorok)
                {
                    db.People.Add(new People(line));
                }
                db.SaveChanges();
            }
            Kiir(db.People);
        }
    }
}
