using Bibliotheek.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotheek.App.Pages
{
    public partial class LedenDetail
    {
        [Parameter]
        public string LedenId { get; set; }
        public Lid Lid { get; set; } = new Lid();

        protected override Task OnInitializedAsync()
        {
            InitializeLeden();
            Lid = Leden.FirstOrDefault(e => e.LedenId == int.Parse(LedenId));
            return base.OnInitializedAsync();
        }
        public IEnumerable<Lid> Leden { get; set; }
        private void InitializeLeden()
        {
            var l1 = new Lid { LedenId = 987321, Voornaam = "Elvis", Familienaam = "Presley", Geboortedatum = new DateTime(1935, 8, 1) };
            var l2 = new Lid { LedenId = 123789, Voornaam = "John", Familienaam = "Lennon", Geboortedatum = new DateTime(1940, 9, 10) };
            Leden = new List<Lid> { l1, l2 };
        }
    }
}
