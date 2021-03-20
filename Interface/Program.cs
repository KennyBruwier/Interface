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
     *  Classes kunnen worden verbonden aan elkaar door ze te koppelen met een interface.
     *  Met een interface zeg je welke methodes de gelinkte classes moeten hebben. 
     *  Die interface gebruik je dan als nieuw datatype om zo toegang te krijgen tot 
     *  de methodes en structures die je verplicht hebt.
     *  Dus i.p.v. een parent classe te maken, ga je een interface gebruiken.
     *  Alsof je een toetsenbord maakt waarbij de verschillende toetsen de verplichte methodens voorstellen.
     *  Wanneer je één toets indrukt, voer je de methodes uit binnen al die sub classens. 
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
