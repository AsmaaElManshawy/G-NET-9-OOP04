using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            Console.WriteLine("Assignment 4 OOP");
            Console.WriteLine("\n" + new string('-',70) + "\n");



            #region Assignment

            #region Part 01 : Theoretical Questions

            #region Question 1

            //Q1: What is the difference between static binding and dynamic binding? When does each one happen?
            //--------------------------------------------------------
            //            Static Binding(Compile-Time Binding)
            //--------------------------------------------------------
            //The method call is resolved at compile time.

            //The compiler decides which method to execute before the program runs.

            //Happens with method overloading or when methods are not declared virtual.
            //--------------------------------------------------------
            //            Dynamic Binding(Run-Time Binding)
            //--------------------------------------------------------
            //The method call is resolved at runtime.

            //The method that executes depends on the actual object type.

            //Happens with method overriding using virtual and override.

            #endregion

            #region Question 2

            //Q2 :  What is the difference between method overloading and method overriding?

            //-------------------------------------------------------------------------------------------------------------------
            // | Feature    |         Method Overloading                     |               Method Overriding                  |
            // | ---------- | ---------------------------------------------- | -------------------------------------------------|
            // | Definition | Same method name with different parameters     | Redefining a virtual method from a base class    |
            // | Occurs     | Same class                                     | Base class and derived class                     |
            // | Binding    | Static(Compile-time)                           | Dynamic(Run-time)                                |
            // | Parameters | Must be different                              | Must be same signature                           |
            // | Keywords   | No special keywords required                   | Uses `virtual` and `override`                    |
            //-------------------------------------------------------------------------------------------------------------------


            #endregion

            #region Question 3

            //Q3: What keywords are used for Method Overriding? What does each one mean ?
            //--------------------------------------------------------------
            //Overriding Keywords → virtual, override, base
            //-----------------------------
            //            1. virtual
            //-----------------------------
            //1- Used in the base class method.
            //2- Indicates that the method can be overridden in a derived class.
            //----------------------------
            //            2. override
            //-----------------------------
            //1- Used in the derived class.
            //2- Replaces the base class implementation.
            //-----------------------------
            //            3. base (often used with overriding)
            //-----------------------------
            // Used to call the base class method inside the overridden method.

            #endregion

            #endregion

            #region Part 02 : Practical

            //Part 02 : Practical(Extending the Movie Ticket Booking System)
            //In the previous assignments, you built a Movie Ticket Booking System with inheritance, properties,
            //and static members.Now you will apply polymorphism to make the system flexible and extensible.

            #region five

              //5. In Main:
              
              //a.Create a Cinema and open it.
              //b.Create one StandardTicket, one VIPTicket, and one IMAXTicket.
              //c.Test both versions of SetPrice on one ticket.
              //d.Add all tickets to the Cinema and call PrintAllTickets().
              //e.Call ProcessTicket() with one of the tickets.
              //f.Close the Cinema.
              //---------------------------------------------------------------
              
              //Cinema cinema = new Cinema("My Cinema");
              
              //    cinema.OpenCinema();
              
              //    Console.WriteLine("\n========== SetPrice Test ==========");
              
              //    StandardTicket t1 = new StandardTicket("Inception", "A-5");
              //    t1.SetPrice(150);
              //    Console.WriteLine($"Setting price directly: {t1.Price}");
              
              //    t1.SetPrice(100, 1.5m);
              //    Console.WriteLine($"Setting price with multiplier: 100 x 1.5 = {t1.Price}");
              
              //    VIPTicket t2 = new VIPTicket("Avengers", true, 50);
              //    t2.SetPrice(200);
              
              //    IMAXTicket t3 = new IMAXTicket("Dune", false);
              //    t3.SetPrice(180);
              
              //    cinema.AddTicket(t1);
              //    cinema.AddTicket(t2);
              //    cinema.AddTicket(t3);
              
              //    cinema.PrintAllTickets();
              
              //    Cinema.ProcessTicket(t2);
              
              //    cinema.CloseCinema();

            #endregion

            #endregion

            #endregion


            Console.WriteLine("\n" + new string('-', 70) + "\n");

        }
    }
}
