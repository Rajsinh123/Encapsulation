using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Encapsulation
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulation eb = new Encapsulation();
            eb.Id = 11;
            eb.Name = "RAMA";
            eb.Email = "Rama@gmail.com";
            Console.WriteLine("Id :" + eb.Id);
            Console.WriteLine("Name :" + eb.Name);
            Console.WriteLine("Email :" + eb.Email);
            Console.ReadLine();
        }

    }
}
