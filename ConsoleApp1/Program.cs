using System.Security.Principal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 : Theoretical Questions


            #region  //Q1: Identify the type of relationship in each scenario below(Inheritance, Association, Aggregation, Composition, or Dependency):


            /*
            a) A University has Departments. If the university is closed, the departments no longer exist

            -- Composition

            b) A Driver uses a Car. The driver does not own the car.
            
            -- Association

            c) A Dog is an Animal.

            -- Inheritance

            d) A Team has Players. If the team is deleted, the players still exist.

            -- Aggregation

            e) A method receives a Logger as a parameter and calls it inside the method only

            -- Dependency

             */
            #endregion



            #region //Q2 : Answer the following questions about access modifiers and sealed:
            /*
             
             
            a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?   
             
            -- Yes, a child class in a different assembly can access the protected field because it inherits from the parent class.

            -- No, it cannot be accessed through an object instance from outside the class because protected members are only accessible within the class and its derived classes.
             
            b) What is the difference between protected internal and private protected?

            -- protected internal allows access from any class in the same assemly or from anouther assembly but only from derived classes.
            -- private protected allows access only from derived classes within the same assembly.

            c) What does the sealed keyword do when applied to a class? What about when applied to a method?

            -- if a class is marked as sealed, it cannot be inherited by any other class.
            -- if a method is marked as sealed, it cannot be overridden by any derived class.

            d) Can you create an object from a sealed class using new? Why or why not?

            -- yes we can create an object from a sealed class using new because sealing a class only prevents it from being inherited, but it does not prevent instantiation .
             */

            #endregion
            #endregion



        }
    }
}
