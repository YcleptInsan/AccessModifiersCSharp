using System;

namespace AccessModifier
{
    class Accessibility 
    {
        static void Main()
        {
            Public accessible = new Public();
            accessible.Accessible();
           // The  code  below will give  an  error due  to  its  protection level
           // accessible.PrivateAccessiblity();

           // The Code  below is  inacccessible due to it not being in derrived class  or  apart  of the  same class
           // Protected newProtected  = new Protected();
           // newProtected.ProtectedAccessibility();
            Access newAccess =  new Access();
            newAccess.Protect();
        }
    }

    public class Public : Private
    {
        public void Accessible()
        {
            Console.WriteLine("Public access levels allow for this code to be acccessed in the same assembly or another assemby that references it.");
        }
    }

    public class Private 
    {
        private void PrivateAccessiblity()
        {
            Console.WriteLine("Private members can be accessed only by code in the same class or struct.");
        }
    }

    public class Protected
    {
        protected void ProtectedAccessibility()
        {
         
            Console.WriteLine("The type or member can be accessed only by code in the same class, or in a class that is derived from that class");
        }

    }

    public class Access
    {
       // private field:
       private int priv = 3;

        // protected internal property:
       protected internal int protec
       {
           get { return this.priv; }
       }

       // protected method:
       protected internal void Protect() 
       { 
           Console.WriteLine(protec);
       }

    }
}
