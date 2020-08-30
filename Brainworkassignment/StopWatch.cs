using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Brainworkassignment
{
    public class Stopwatch
    {
        private DateTime start;
        private DateTime stop;
       
        public Stopwatch()
        {
            start = new DateTime();
            stop = new DateTime();
         



        }

        public void Start() 
        {
          
            
                start = DateTime.Now;
             

                Console.WriteLine("start time" + start.Hour + ":" + start.Minute + ":" + start.Second + ":" + start.Millisecond);

            
        
        }

        public void Stop()
        {

    

            

            stop = DateTime.Now;
            
            Console.WriteLine("start time" + stop.Hour + ":" + stop.Minute + ":" + stop.Second + ":" + stop.Millisecond);
            TimeSpan duration = start - stop;
            Duration(duration);



        }



        private void Duration(TimeSpan duration)
        {


            Console.WriteLine("Dureation:" + duration.Seconds + "seconds" + duration.Milliseconds + "milliseconds");

        }

    }
}
