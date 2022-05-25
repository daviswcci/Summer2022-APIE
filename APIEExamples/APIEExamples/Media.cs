using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEExamples
{
    internal class Media
    {
        public string Title;
        public List<string> Genres;
        public double Cost;

        public void Play()
        {
            Console.WriteLine("This piece of media slaps!");
        }

        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }
    }
}
