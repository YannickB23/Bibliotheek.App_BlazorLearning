using Bibliotheek.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotheek.App.Pages
{
    public partial class BezoekerOverview
    {
        public IEnumerable<Bezoeker> Bezoekers { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitialiazeBezoeker();
            return base.OnInitializedAsync();
        }
        private void InitialiazeBezoeker()
        {
            var b1 = new Bezoeker {Voornaam = "Tom", Familienaam = "Jones" };
            var b2 = new Bezoeker {  Voornaam = "Stevie", Familienaam = "Wonder" };
            Bezoekers = new List<Bezoeker> { b1, b2 };
        }
    }
}
