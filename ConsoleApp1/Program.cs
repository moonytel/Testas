using System.Diagnostics;

namespace Consoleapp1
{
   class programa
    {
        static void Main(string[] args)
        {
            //skaiciavimui kiek programa veiks laiko
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();


            //naudojama klasė iš kitos bylos
            klase1.seka myObj = new klase1.seka();
            myObj.sek();

            //baigiama skaiciuoti programos veikimo laika.
            stopwatch.Stop();

            Console.WriteLine("Praejas laikas: {0} ms", stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}