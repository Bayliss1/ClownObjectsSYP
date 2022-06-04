using System;

namespace ClownObjectsSYP

{
    class Clown
    {
        // fields
        public string Name;
        public int Height;

        // method
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clown oneClown = new Clown(); // creates new object called oneClown in Clown class
            oneClown.Name = "Boffo"; // sets Name field for oneClown object in Clown class
            oneClown.Height = 14; // sets Height field for oneClown object in Clown class
            oneClown.TalkAboutYourself(); // runs TalkAboutYourself method for oneClown object from Clown class
            // My name is Boffo and I'm 14 inches tall.

            Clown anotherClown = new Clown();
            anotherClown.Name = "Biff";
            anotherClown.Height = 16;
            anotherClown.TalkAboutYourself();
            // My name is Biff and I'm 16 inches tall.

            Clown clown3 = new Clown();
            clown3.Name = anotherClown.Name;
            clown3.Height = oneClown.Height - 3;
            clown3.TalkAboutYourself();
            // My name is Biff and I'm 11 inches tall.

            anotherClown.Height *= 2;
            anotherClown.TalkAboutYourself();
            // My name is Biff and I'm 32 inches tall.
        }
    }
}
