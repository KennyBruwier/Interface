using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Interface
{

    /*
     * Wat is een interface?
     * 
     * Kort:
     *  Klassen kunnen worden verbonden aan elkaar door ze te koppelen met een interface.
     *  Met een interface zeg je welke methodens de gelinkte klassens moeten hebben. 
     *  Die interface gebruik je dan als nieuw datatype om zo toegang te krijgen tot 
     *  de methodes van de onderliggende klassens.
     *  
     *  Alsof je een toetsenbord maakt waarbij de toetsen gekoppeld zijn aan een methoden 
     *  binnen al uw gelinkte klassens. Wanneer je één toets indrukt, voer je die methoden 
     *  uit binnen al die sub klassens. Zo kan je met uw "interface-toetsbord" 
     *  verschillende methodens tegelijk laten uitvoeren binnen al uw gelinkte klassens.
     */

    class Program
    {
        static void Main(string[] args)
        {
            //in een statishe classe bestaat blijkbaar 'this' niet... dus dan maar via omweggeske
            new userInterface();

            Figuren();
        }

        static void Figuren()
        {
            List<IFiguur> lstFiguren = new List<IFiguur>();

            lstFiguren.Add(new Cirkel());
            lstFiguren.Add(new Vierkant());
            lstFiguren.Add(new Driehoek());
            lstFiguren.Add(new Cirkel());
            lstFiguren.Add(new Cirkel());
            lstFiguren.Add(new Vierkant());
            lstFiguren.Add(new Driehoek());

            foreach (IFiguur item in lstFiguren)
            {
                item.Teken();
                //item.Omtrek();
            }
            Console.ReadKey();
        }

    }
    
}
