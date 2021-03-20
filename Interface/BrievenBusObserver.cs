using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Interface
{
    //===========================================================================================
    //heb deze nu hier staan, normaal zet je deze interface en klasse in apparte bestanden
    public interface IBrievenBusObserver
    {
        void OnPostOntvangen(string aBrief);
    }
    //===========================================================================================
    public class Postbode
    {
        private IBrievenBusObserver _brievenBusObserver;

        public Postbode(IBrievenBusObserver aBrievenBusObserver)//constructor
        {
            this._brievenBusObserver = aBrievenBusObserver;
            new Thread(eenMethodeDatAfEnToePostStuurt).Start();
        }
        private void eenMethodeDatAfEnToePostStuurt()
        {
            Random rnd = new Random();
            while (true)
            {
                Thread.Sleep(rnd.Next(500, 3000));
                _brievenBusObserver.OnPostOntvangen($"ik ben post bezorgt door Postbode");
            }
        }
    }

    //==========================================================================================

    public class userInterface : IBrievenBusObserver
    {
        public userInterface()
        {
            Postbode postbode = new Postbode(this); //je geeft this, want this is nu ook een type IBrievenbusobser
        }
        //je kan
        //omdat je de interface IBrievenBusObserver implementeerd ben je verplicht deze 
        //methode te schrijven, anders compileerfout
        public void OnPostOntvangen(string aBrief)
        {
            Console.WriteLine(aBrief);
        }
    }
}
