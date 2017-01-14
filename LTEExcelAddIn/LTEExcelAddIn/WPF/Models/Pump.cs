using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTEExcelAddIn.WPF.Models
{
    class Pump
    {
        public int Artikul { get; set; }
        public int? OldArtikul { get; set; }
        public string Name { get; set; }
        public int? Height { get; set; }
        public string Diametr { get; set; }
        public int? Capacitor { get; set; }
        public int? ArtikulRotor { get; set; }
        public string NameRotor { get; set; }
        public int? ArtikulWheel { get; set; }
        public string NameWheel { get; set; }
        public int Quantity { get; set; }
    }
}