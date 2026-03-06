using System;
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

            #endregion

            #endregion

            #region Part 02 : Practical

            //Part 02 : Practical(Extending the Movie Ticket Booking System)
            //In the previous assignments, you built a Movie Ticket Booking System with inheritance, properties,
            //and static members.Now you will apply polymorphism to make the system flexible and extensible.

            //What you need to build:

            #region one

            //1.Refactor the base Ticket class:

            //a.Add a PrintTicket() method that prints: TicketId, MovieName, Price, PriceAfterTax.
            //Child classes should be able to provide their own version of this method.

            //b.Add two versions of a SetPrice method — one that takes a decimal (sets price directly)
            //and one that takes a decimal base price and a decimal multiplier(sets price = base × multiplier).

            #endregion

            #region two

            //2. In each child class, provide its own version of PrintTicket():

            //a.StandardTicket — prints the base ticket info and the SeatNumber.
            //b.VIPTicket — prints the base ticket info, LoungeAccess, and ServiceFee.
            //c.IMAXTicket — prints the base ticket info and whether it is 3D.

            #endregion

            #region three

            //3. In the Cinema class, update PrintAllTickets() so it loops through the Ticket[] array
            //and calls PrintTicket() on each one.

            #endregion

            #region four

            //4. Create a static method ProcessTicket(Ticket t) that takes any Ticket and calls PrintTicket() on it.

            #endregion

            #region five

            //5. In Main:

            //a.Create a Cinema and open it.
            //b.Create one StandardTicket, one VIPTicket, and one IMAXTicket.
            //c.Test both versions of SetPrice on one ticket.
            //d.Add all tickets to the Cinema and call PrintAllTickets().
            //e.Call ProcessTicket() with one of the tickets.
            //f.Close the Cinema.



            #endregion

            #endregion

            #endregion


            Console.WriteLine("\n" + new string('-', 70) + "\n");

        }
    }
}
