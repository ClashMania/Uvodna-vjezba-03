using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Napišite program koji će provjeriti jesu li vrijednosti sadržane u int varijablama x, y i z stranice pravokutnog trokuta.
//U program uključite i provjeru da vrijednosti varijabli za ovakav primjer imaju smislene vrijednosti (iznosi moraju biti veći od 0).



namespace Uvodna_vježba_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
   ponovno:
            Console.WriteLine("Upišite stranicu x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upišite stranicu y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upišite stranicu z: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x <= 0 || y <= 0 || z <= 0)
                {
                Console.WriteLine("Broj koji ste stavili u varijablu je netočna!");
                goto ponovno;
                }


          if ((z*z)==(x*x)+(y*y))
            {
                Console.WriteLine("Vaš trokut je pravokutan!");
            }



           
              

            Console.ReadKey(); 
        }
    }
}
