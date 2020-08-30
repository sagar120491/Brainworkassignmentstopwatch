using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainworkassignment
{
    class Program
    {
        static void Main(string[] args)
        {

            var stopWatch = new Stopwatch();

            Boolean flag = true;

           

                Console.WriteLine("Enter option 1 for start and 2 for stop");



            
            do {

                  int option = Convert.ToInt32(Console.ReadLine());

                  switch (option)
                    {
                       case 1:

                        stopWatch.Start();
                        break;


                      case 2:

                        stopWatch.Stop();

                        flag = false;
                        break;

                     default:


                        // throw new InvalidOperationException();

                        Console.WriteLine("please enter correwct option");
                        
                        break;


                       // Console.ReadLine();

                    
                }




            } while (flag == true);

           

           


        }
        
    }
}
