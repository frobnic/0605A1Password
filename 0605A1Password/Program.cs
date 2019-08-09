using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0605A1Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwort = "";
            int i;      
            Random zuf = new Random();

            // vier kleinbuchstaben generieren:
            for (i = 1; i < 5; i++)
            {
                passwort = passwort + (char)zuf.Next(0x61, 0x7a);
            }

            // einen grossbuchstaben generieren:
            for (i = 1; i < 2; i++)
            {
                passwort = passwort + (char)zuf.Next(0x41, 0x5a);
            }

            // zwei ziffern generieren:
            for (i = 1; i <= 2; i++)
            {
                passwort = passwort + (char)zuf.Next(0x30, 0x39);
            }

            // ein sonderzeichen generieren:
            for (i = 1; i <= 2; i++)
            {
                passwort = passwort + (char)zuf.Next(0x21, 0x2f);
            }

            Console.WriteLine("Die generierte Zeichenmenge lautet:  {0}", passwort);

            char[] c = passwort.ToArray();
            char t;
            int a, b;

            for ( i = 1; i < 10; i++)
            {
                // zeichen irgendwie wuerfeln
                a = zuf.Next(1, 9);
                b = zuf.Next(1, 9);

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

        }
    }
}
