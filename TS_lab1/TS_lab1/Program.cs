using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();

            p.OnChange += () => Console.WriteLine("Subscriber 1!");

            p.OnChange += () => Console.WriteLine("Subscriber 2!");


            p.Raise();

            //After this Raise() method is called
            //all subscribers callback methods will get invoked

            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();

        
    }
    }


    public class Pub
    {
        //OnChange property containing all the 
        //list of subscribers callback methods
        public Action OnChange { get; set; }

        public void Raise()
        {
            //Check if OnChange Action is set before invoking it
            if (OnChange != null)
            {
                //Invoke OnChange Action
                OnChange();
            }
        }
    }



}

