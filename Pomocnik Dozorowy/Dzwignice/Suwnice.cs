using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomocnik_Dozorowy.Dzwignice
{
    internal class Suwnice
    {
        //Dane Identyfikacyjne
        public string? ID { get; set; }
        public string? NrFabryczny { get; set; }
        public string? Producent { get; set; }
        public string? TypModel { get; set; }
        public string? RokProdukcji { get; set; }
        public string? RokMontazu { get; set; }
        public string? Lokalizacja { get; set; }
        public string? Wlasciciel { get; set; }

        //Dane Techniczne
        public string? RodzajSuwnicy { get; set; } // Pomostowa / Bramowa / Półbramowa
        public string? UdzwigNominalny { get; set; } // kg/t
        public string? Rozpietosc { get; set; } // Podawane w metrach
        public string? WysokoscPodnoszenia { get; set; } //Podawane w metrach
        public string? PredkoscPodnoszenia { get; set; } // Podawane w m/min
        public string? PredkoscJazdyMostu { get; set; } // Podawane w m/min
        public string? PredkoscJazdyWozka { get; set; } // Podawane w m/min
        public string? LiczbaBiegow { get; set; }
        public string? KlasaPracy { get; set; } // np: FEM / ISO
        public string? Zasilanie { get; set; } // np 3x400V, szynoprzewód
        public string? TypSterowania { get; set; } // kaseta / radio / kabina
        public string? GrupaNatezeniaPracy { get; set; } // A1, A7, G3 itp //Dane Identyfikacyjne suwnicy

        //Dane UDT
        public string? NumerEwidencyjny { get; set; }
        public string? RodzajDozoru { get; set; } // Pełny / Ograniczony / Uproszczony
        public string? DataOstatniegoBadania { get; set; }
        public string? DataWaznosciDecyzji { get; set; }
        public string? Status { get; set; } // Dopuszczona / Wstrzymana / Wyłączona
        public string? JednostkaUDT { get; set; }
    }
}
