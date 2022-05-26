using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEExamples
{
    internal class Game : Media
    {
        // properties and methods
        // accessModifier type name
        public int Copies;
        public bool IsCoop;
        public int TimePlayed;
        // this is a perfect opportunity for a child class - properties that exist on some but not all
        public int MaxLevel;
        public List<string> Inventory;

        // constructors, how can we create this object?
        //public Game(string title)
        //{
        //    Title = title;
        //}

        // methods, what actions can we do with this object?
        // accessModifier optional returnType name(input){code to run}
        public override void Play()
        {
            Console.WriteLine("How many hours did you play today?");
            int hours = Int32.Parse(Console.ReadLine());
            TimePlayed += hours;
        }

        // method overloading
        public void Play(int hours)
        {
            TimePlayed += hours;
        }
    }
}
