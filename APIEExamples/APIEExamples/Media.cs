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
        public List<Genre> Genres;
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

        // method overloading - creating more methods with the same NAME, but different parameters
        public void ClassifyMedia(Genre genre)
        {
            Genres.Add(genre);
        }

        public void ClassifyMedia(int genre)
        {
            Genres.Add((Genre)genre); // typecasting
        }

        // accessModifier optional returnType methodName(inputs) ...
        // abstract - any children class needs to provide their own functionality for these methods
        // downsides of using abstract: forces us to declare the class as abstract
        // classes declared abstract cannot have objects instantantiated from them
        public abstract void Play();
    }

    public enum Genre
    {
        Horror, // zero-base index, being indexed at zero. 0 to (length-1)
        Comedy,
        Romcom,
        Fantasy,
        Action,
        Adventure
    }
}
