// Default ref libs next 5 lines
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacktheplanet // no real benifit other then knowing where the heck the app starts
{ // start of app proper

    class Program // here be dragons!!!!

    {
        // look into the void and have it look back

       
        
        static void Main(string[] args) // the args string will contain cmdln paras
        {
            // hello world v2.0
            Console.WriteLine("HACK THE PLANET");
            Console.Write("enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine("doing what now " + username ) ;

            //interpolated strings
            // Console.WriteLine($"doing what now "  {username} ) ;

            // Console.WriteLine has a string formatter overload as well
            // Console.WriteLine("doing what now, {0};  username ) ;

            Console.Write("Choose a number wisely: ");
            string firstentry = Console.ReadLine();
            int firstnumber = int.Parse(firstentry);
           


            Console.Write("Choose another number wisely: ");
            string secondentry = Console.ReadLine();
            int secondnumber = Convert.ToInt32(secondentry);


            //Console.WriteLine("Adding strings wisely: " + (firstentry + secondentry));
            //Console.WriteLine("Adding number wisely: " + (firstnumber + secondnumber));

            Console.Write("Pick an operator (* + - / : )");
            string userOperator = Console.ReadLine();

            //use some if statements to compute based on user choice

            // well ok i'll play nice for now

            //if (userOperator == "+")
            //{
            //    Console.WriteLine("Adding strings wisely: " + (firstnumber + secondnumber));
            //}


            //if (userOperator == "-")
            //{
            //    Console.WriteLine("Subtracting strings wisely: " + (firstnumber - secondnumber));
            //}

            //if (userOperator == "/")
            //{
            //    Console.WriteLine("Dividing strings wisely: " + (firstnumber / secondnumber));
            //}

            //if (userOperator == "*")
            //{
            //    Console.WriteLine("multipling strings wisely: " + (firstnumber * secondnumber));
            //}


            //switch (userOperator)
            //{
            //    case "+":
            //        Console.WriteLine("Adding strings wisely: " + (firstnumber + secondnumber));
            //        break;
            //   case "-":
            //        Console.WriteLine("Subtracting strings wisely: " + (firstnumber - secondnumber));
            //        break;
            //   case "/":
            //        Console.WriteLine("Dividing strings wisely: " + (firstnumber / secondnumber));
            //        break;
            //  case "*":
            //        Console.WriteLine("multipling strings wisely: " + (firstnumber * secondnumber));
            //        break;
            //}


            while(true)
            {

                Console.WriteLine("looping...");
                //Console.Write("Press enter to continue");
                //Console.Read();

                Console.Write("Continue (y/n)?");
                string userContinue = Console.ReadLine();
                if (userContinue == "n")
                {
                    break;
                }
 

            }




            Console.Read();
        }


    }


} // end of all things
