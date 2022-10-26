using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2
{
    public class exe2
    {
        public static void Main()
        {

            int[] tab = new int[10];
            int i, t, pos = 0, val;
            Console.Write("entrer la taille de tableau  : ");
            t = Convert.ToInt32(Console.ReadLine());

         
            
            Console.Write("inserer elemnt tableau par un ordre croissante :", t);
            for (i = 0; i < t; i++)
            {
                Console.Write("element - {0} : ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("entrer la valeur que voulez inserer  : ");
            val = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < t; i++)                                                                      
                Console.Write("element {0} ", tab[i]);
            

            
            for (i = 0; i < t; i++)
                if (val < tab[i])
                {
                    pos = i;
                    break;
                }

            for (i = t; i >= pos; i--)
            {
                tab[i] = tab[i - 1];

                tab[pos] = val;
            }
            Console.Write("\n le  tableau finale :\n ");
            for (i = 0; i <= t; i++)
                Console.Write("{0} ", tab[i]);
            Console.Write("\n");
        }
    }
}
