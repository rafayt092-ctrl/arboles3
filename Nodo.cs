using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolbusqbin {
    internal class Nodo {
        public int Dato { get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }

        public Nodo(int dato) {
            Dato = dato;
            Izq = null;
            Der = null;
        }

        public override string? ToString() {
            return Dato.ToString();
        }
    }
}
