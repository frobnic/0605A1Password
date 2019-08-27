using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0605A1Password
{
    class Program
    {
        static Random zufall = new Random();

        static char zufallschar(string zeichenmenge)
        {
            int len = zeichenmenge.Length;
            int pos;
            char[] zeichen = zeichenmenge.ToCharArray();

            pos = zufall.Next(0, len);
            return zeichen[pos];
        }

        static void Main(string[] args)
        {
            string passwort = "";
            string anderespasswort = "";
            int i;      
            Random zuf = new Random();

            string kleinbuchstaben = "abcdefghijklmnopqrstuvwxyzäöüß";
            string grobbuchstaben = kleinbuchstaben.ToUpper();
            string ziffern = "0123456789";
            string sonderzeichen = "<>|,.-;:_°^!\"§$%&/()=?´`+*~#'";

            // vier kleinbuchstaben generieren:
            for (i = 1; i < 5; i++)
            {
                passwort = passwort + (char)zuf.Next(0x61, 0x7a);
                anderespasswort += zufallschar(kleinbuchstaben+grobbuchstaben);
            }
            // einen grossbuchstaben generieren:
            for (i = 1; i < 2; i++)
            {
                passwort = passwort + (char)zuf.Next(0x41, 0x5a);
                anderespasswort += zufallschar(grobbuchstaben);
            }


            // zwei ziffern generieren:
            for (i = 1; i <= 2; i++)
            {
                passwort = passwort + (char)zuf.Next(0x30, 0x39);
                anderespasswort += zufallschar(ziffern);
            }
            // ein sonderzeichen generieren:
            for (i = 1; i <= 2; i++)
            {
                passwort = passwort + (char)zuf.Next(0x21, 0x2f);
                anderespasswort += zufallschar(sonderzeichen);
            }

            Console.WriteLine("Die generierte  Zeichenmenge lautet: {0}", passwort);
            Console.WriteLine("Die andere      Zeichenmenge lautet: {0}", anderespasswort);

            char[] c = passwort.ToArray();
            char t;
            int a, b;

            for ( i = 1; i < 10; i++)
            {
                // zeichen irgendwie wuerfeln
                a = zuf.Next(0, 9);
                b = zuf.Next(0, 9);

                t = c[a];
                c[a] = c[b];
                c[b] = t;

            }

            Console.Write("Die gewuerfelte Zeichenmenge lautet: ");
            foreach (char u in c)
            {
                Console.Write("{0}", u);
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
