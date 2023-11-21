using System;

namespace klase1
{
    public class seka
    {
        //teko pasinaudoti void, nes while skliaustus priskyre prie public class seka ir dave daug erroru.
        public void sek()
            { 
            double a = 1;
            double b = 2;
            double c = 1;
            double i = 0;
            double l = Math.Pow(10, 15);

            while (c < l)
            {
                c = a * b;
                a = b;
                b = c;
                i = c;
            }
            Console.WriteLine(i);
        }
    }
}
