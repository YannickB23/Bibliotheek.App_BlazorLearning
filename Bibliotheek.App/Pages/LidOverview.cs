using Bibliotheek.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotheek.App.Pages
{
    public partial class LidOverview
    {
        public IEnumerable<Lid> Leden { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeLeden();
            return base.OnInitializedAsync();
        }
        private void InitializeLeden()
        {
            var l1 = new Lid { LedenId = 987321, Voornaam = "Elvis", Familienaam = "Presley", Geboortedatum = new DateTime(1935, 8, 1) };
            var l2 = new Lid { LedenId = 123789, Voornaam = "John", Familienaam = "Lennon", Geboortedatum = new DateTime(1940, 9, 10 ) };
            Leden = new List<Lid> { l1, l2 };
        }
    }
}
