using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
    public interface IFiguur
    {
        void Teken();
        //void Omtrek();
    }
    class Driehoek : IFiguur
    {
        //verplicht te implementeren omdt ik een IFiguur ben
        public void Teken() { Console.WriteLine("ik ben een driehoek"); }
    }
    class Vierkant : IFiguur
    {
        //verplicht te implementeren omdt ik een IFiguur ben
        public void Teken() { Console.WriteLine("ik ben een vierkant"); }
    }
    class Cirkel : IFiguur
    {
        //verplicht te implementeren omdt ik een IFiguur ben
        public void Teken() { Console.WriteLine("ik ben een cirkel"); }

        public void Omtrek() { Console.WriteLine("ik ben een omtrek"); }
    }
    //==========================================================================================================
}
