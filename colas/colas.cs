using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colas
{
    class Cola
    {
        object[] cola;
        int frente;
        int posterior;
//        Ahora explicaremos cada parte:
//Creamos una clase y lo llamamos cola, creamos un arreglo global de tipo objeto, esta sera nuestra cola, un frente y un posterior de tipo entero, estos seran los indices de nuestra cola.
//Estos los inicializamos con un constructor.
        public Cola(int tamano)
        {
            posterior = 0;
            cola = new object[tamano];
            for (int i = 0; i < tamano; i++)
            {
                cola[i] = null;
            }
        }
        public int incremento(int i, int tamano)
        {
            return (i + 1) % tamano;
        }
        public bool llena()
        {
            if (incremento(posterior, cola.Length) == frente)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool vacia()
        {
            if (posterior == frente)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void push(object x)
        {
            if (!llena())
            {
                cola[posterior] = x;
                posterior = incremento(posterior, cola.Length);
            }
        }
        public object top()
        {
            if (!vacia())
            {
                return cola[frente];
            }
            else
            {
                return null;
            }
        }
        public void pop()
        {
            if (!vacia())
            {
                frente = incremento(frente, cola.Length);
            }
        }
    }

}
