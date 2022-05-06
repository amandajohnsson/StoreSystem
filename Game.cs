using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    class Game : Product
    {
        public Platform Platform { get; set; }
        public override string Description
        {
            get
            {
                return string.Format("Platform: {0}", this.Platform.ToString());
            }
            set => base.Description = value;
        }
    }
    enum Platform
    {
        PC,
        Playstation5,
        unknown,
    }
}
