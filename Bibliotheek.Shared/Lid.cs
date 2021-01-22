using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheek.Shared
{
    public class Lid : Bezoeker
    {
        public int LedenId { get; set; }
        public DateTime Geboortedatum { get; set; }
    }
}
