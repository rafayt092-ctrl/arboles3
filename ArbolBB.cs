using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolbusqbin {
    internal class ArbolBB {
        private Nodo Raiz {  get; set; }
        public ArbolBB() {
            Raiz = null;
        }
        public void Insertar(int v) {
            Raiz = InsertarRecursivo(Raiz, v);
        }
        private Nodo InsertarRecursivo(Nodo r, int valor) {
            if (r == null) {
                return new Nodo(valor);
            } else if (valor < r.Dato) {
                r.Izq = InsertarRecursivo(r.Izq, valor);
            } else if (valor > r.Dato) {
                r.Der = InsertarRecursivo(r.Der, valor);
            }
            return r;
        }
    }
}
