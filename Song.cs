using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Song
    {
        private string name;
        private string author;
        private Song prev;
        public Song() 
        {
        }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }
        public string Title()
        {
            return name + " - " + author;
        }
        public override bool Equals(object d)
        {
            bool b = (d as Song).name.Equals(name) && (d as Song).author.Equals(author);
            return b;
            //return d != null &&
            //name.Equals(((Song)d).name) &&
            //author.Equals(((Song)d).author);
        }
    }
}
