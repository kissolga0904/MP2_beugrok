using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga
{
    //1 írj egy osztályt, amelynek a konstruktora egy egész paramétert vár,
    //és egy saját kivételt dob, ha a paraméter értéke nem megfelelő! a főprogram
    //kezeli a kivételt. (try-catch?)

    //2.írj egy interface-t egy egész propertyvel! írj egy másik interface-t egy
    //string paraméterű eljárással. majd írj egy osztályt amely implementálja mindkettőt.

    //3. írj egy egyszerű user osztályt usernévvel, életkorral és irányítószámmal.
    //szűrd le a listából a(z) fiatal usereket

    //4.írj egy osztályt két logikai mezővel, az osztály implementálja az ICloneable interface-t

    //5. írj egy osztályt egy lebegőpontos csak olvasható propertyvel, ami értékvizsgálatot végez

    //6. írj egy egyszerű Product osztályt árunévvel, azzal és megrendelési dátummal rendezd a listát
    //a lambda kifejezés segítségével dátum szerint növekvő sorrendbe
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                elso e = new elso(-5);
            }
            catch (EgyediException ex)
            {

                throw;
            }

            //3:
            List<User> lista = new List<User>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Eletkor < 18)
                {

                }
            }

            //6.
            List<Product> products = new List<Product>();
            products.OrderBy(p => p.arunev).ThenBy(p => p.datum);

            for (int i = 0; i < length; i++)
            {

            }
            for (int i = length - 1; i >= 0; i--)
            {

            }
            
        }
    }
}
