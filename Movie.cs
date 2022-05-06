using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    class Movie : Product
    {
        public FormatMovie FormatMovie { get; set; }

        public string Playtime { get; set; }
        public override string Description
        {
            get
            {
                return string.Format("Playtime: {0} Format:{1}", Playtime, this.FormatMovie.ToString());
            }
            set => base.Description = value;
        }
    }
    enum FormatMovie
    {
        DVD,
        BluRay,
        unknown
    }
}
