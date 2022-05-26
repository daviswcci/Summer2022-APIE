using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEExamples
{
    internal abstract class Media : IRatable
    {
        public string Title;
        public List<string> Genres;
        public double Cost;
        public double Rating;

        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }

        public void IncreaseRating(double change)
        {
            Rating += change;
        }

        public void DecreaseRating(double change)
        {
            Rating -= change;
        }

        // accessModifier optional returnType methodName(inputs) ...
        // abstract - any children class needs to provide their own functionality for these methods
        // downsides of using abstract: forces us to declare the class as abstract
        // classes declared abstract cannot have objects instantantiated from them
        public abstract void Play();
    }
}
