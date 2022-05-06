using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    class Book : Product
    {

        public string Author { get; set; }
        public Genre Genre { get; set; }

        public FormatBook FormatBook { get; set; }

        public string Language { get; set; }

        public override string Description
        {
            get
            {
                return string.Format("Author: {0}. Genre: {1}. Format:{2} Language: {3}", Author, this.Genre.ToString(), this.FormatBook.ToString(), Language);
            }
            set => base.Description = value;
        }
    }

    enum Genre
    {
        Historia,
        Äventyr,
        Kursliteratur,
        Skräck,
        Noir,
        unknown
    }
    enum FormatBook
    {
        Pocket,
        Inbunden,
        EBok,
        unknown
    }
}
